# 💰 Expense Tracker (C# WinForms + SQLite)

A simple desktop **Expense Tracker** built with **C# Windows Forms** and **SQLite**.  
This app allows you to record your daily income and expenses, categorize them, and view them in a clean table.

---

## ✨ Features
- Add transactions with:
  - Amount (numeric validation)
  - Note/description
  - Category (Food, Rent, Salary, etc.)
  - Date
  - Type (Income / Expense)
- Data stored locally in an **SQLite database** (`expenses.db`)
- Automatic database + table creation on first run
- Transactions shown in a **DataGridView** with sorting and formatting
- Prevents invalid input (e.g., non-numeric amounts)
- Categories dropdown is locked (no duplicates, only valid choices)

---

## 🛠 Requirements
- Windows PC
- Visual Studio (2022 or later recommended)
- .NET Framework (WinForms project type)
- NuGet packages:
  - `System.Data.SQLite.Core`

---

## 🚀 How to Run
1. Clone this repository:
   ```bash
   git clone https://github.com/<your-username>/csharp-expense-tracker.git
2.Open the solution (.sln) in Visual Studio.

3.Restore NuGet packages (VS usually does this automatically).

4.Build the project (Ctrl+Shift+B).

5.Run the project (F5 or the green ▶ button).

6.On first run, expenses.db will be created automatically in the output folder.

📖 How to Use

1.Enter an amount (e.g., 50.00).

2.Add a note (e.g., Groceries).

3.Choose a category (Food, Rent, Salary, etc.).

4.Pick the date.

5.Select whether it’s Income or Expense.

6.Click Add Transaction.

7.Your entry will appear in the table below.

📂 Project Structure
ExpenseTracker/
├── Form1.cs           # Main form logic
├── Form1.Designer.cs  # UI designer code
├── expenses.db        # SQLite database (auto-created)
└── README.md          # Project description

🔮 Future Improvements

-Add summary labels (Total Income / Total Expense / Balance)

-Export transactions to CSV/Excel

-Add search & filters

-Multi-language support
