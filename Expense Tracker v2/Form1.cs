using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Globalization;   // for number parsing

namespace Expense_Tracker_v2
{
    public partial class Form1 : Form
    {
        // ---- DB path + connection string (absolute path next to the .exe)
        private static readonly string DbPath =
            System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "expenses.db");
        private static readonly string ConnStr = $"Data Source={DbPath};Version=3;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Ensure DB file exists
            if (!System.IO.File.Exists(DbPath))
            {
                SQLiteConnection.CreateFile(DbPath);
            }

            // Ensure table exists (handles missing-table crashes)
            using (var conn = new SQLiteConnection(ConnStr))
            {
                conn.Open();
                string sql = @"CREATE TABLE IF NOT EXISTS Transactions (
                                  Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                  Amount REAL NOT NULL,
                                  Category TEXT NOT NULL,
                                  Note TEXT,
                                  Date TEXT NOT NULL,
                                  Type TEXT NOT NULL
                               )";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }

            // Add categories once & lock dropdown to list
            if (comboBox1.Items.Count == 0)
            {
                var cats = new object[] { "Food", "Rent", "Salary", "Transport", "Other" };
                comboBox1.Items.AddRange(cats);
            }
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            // Default type selection
            rbExpense.Checked = true;

            // Load data
            LoadData();

            // Optional: press Enter to submit
            this.AcceptButton = button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate amount from textBox1
            if (!decimal.TryParse(textBox1.Text, System.Globalization.NumberStyles.Number,
                                  System.Globalization.CultureInfo.InvariantCulture, out var amount))
            {
                MessageBox.Show("Please enter a valid numeric amount.", "Invalid Amount",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                textBox1.SelectAll();
                return;
            }

            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Please choose a category.", "Missing Category",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox1.DroppedDown = true;
                return;
            }

            using (var conn = new SQLiteConnection(ConnStr))
            {
                conn.Open();
                string sql = "INSERT INTO Transactions (Amount, Category, Note, Date, Type) " +
                             "VALUES (@Amount, @Category, @Note, @Date, @Type)";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.Add("@Amount", DbType.Double).Value = (double)amount;
                    cmd.Parameters.AddWithValue("@Category", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@Note", textBox2.Text); // note from textBox2
                    cmd.Parameters.AddWithValue("@Date", datePicker.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Type", rbIncome.Checked ? "Income" : "Expense");
                    cmd.ExecuteNonQuery();
                }
            }

            // Clear inputs
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            rbExpense.Checked = true;
            textBox1.Focus();

            LoadData();
        }

        private void LoadData()
        {
            using (var conn = new SQLiteConnection(ConnStr))
            {
                conn.Open();
                string sql = "SELECT * FROM Transactions ORDER BY Date DESC, Id DESC";
                using (var da = new SQLiteDataAdapter(sql, conn))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }

            ConfigureGrid();
        }

        private void ConfigureGrid()
        {
            var gv = dataGridView1;

            gv.AllowUserToAddRows = false;
            gv.AllowUserToDeleteRows = false;
            gv.ReadOnly = true;
            gv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gv.MultiSelect = false;
            gv.RowHeadersVisible = false;
            gv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

            if (gv.Columns.Contains("Id")) gv.Columns["Id"].HeaderText = "#";
            if (gv.Columns.Contains("Amount"))
            {
                gv.Columns["Amount"].HeaderText = "Amount";
                gv.Columns["Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                gv.Columns["Amount"].DefaultCellStyle.Format = "N2";
                gv.Columns["Amount"].FillWeight = 90;
            }
            if (gv.Columns.Contains("Category")) gv.Columns["Category"].FillWeight = 120;
            if (gv.Columns.Contains("Note")) gv.Columns["Note"].FillWeight = 200;
            if (gv.Columns.Contains("Date"))
            {
                gv.Columns["Date"].HeaderText = "Date";
                gv.Columns["Date"].DefaultCellStyle.Format = "yyyy-MM-dd";
                gv.Columns["Date"].FillWeight = 110;
            }
            if (gv.Columns.Contains("Type")) gv.Columns["Type"].FillWeight = 90;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // not used
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // not used
        }
    }
}
