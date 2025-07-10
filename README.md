# 📦 Stock Manager 8.0

Welcome to **Stock Manager 8.0**, a simple and efficient stock management console application written in C#.  
This project was originally built to help my mom manage inventory for her online shop — but it can be easily adapted for any small business or learning purpose.

---

## 🚀 Features

- ✅ **Add products** (Physical Products, eBooks, Online Courses)
- 📋 **List all registered products**
- ➕ **Add stock** to existing items
- ➖ **Remove stock** from products
- ❌ **Delete products** from inventory
- 💾 **Data persistence** via JSON (`products.json`)
- 🔐 **Input validation** to avoid bad entries and crashes

---

## 🛠️ Technologies Used

- **C#** (.NET Console App)
- **Newtonsoft.Json** for serialization
- **OOP principles** (Interfaces, Abstraction, Inheritance)
- No external DB — all data is saved locally in a `.json` file

---

## 🧠 How It Works

When you launch the app, you'll be presented with a simple menu:

Welcome to the Stock Manager 8.0 developed by SolarX!

Please select an option from the menu below:

List Products

Add Products

Remove Products

Stock Entry

Stock Removal

Exit

yaml
Copiar
Editar

Each menu option walks you through cleanly formatted, validated steps to manage your product inventory.

---

## 📁 Data Example (products.json)

```json
[
  {
    "$type": "StockManager.PhysicalProduct, StockManager",
    "name": "Notebook",
    "price": 25.99,
    "deliveryFee": 5.5,
    "stockQuantity": 10
  }
]
💡 Motivation
My mom needed a lightweight and reliable way to manage her online shop's stock without a complex interface or expensive tools.
I built this project from scratch to help her — and also to practice my C# skills in real-world scenarios.
Now, I’m sharing it in case it helps someone else too.

🛤️ Future Improvements
✅ Better user prompts

✅ Float and string input validation

⌛ Replace int.Parse() with TryParse() for safer input handling

⌛ Export report summaries

⌛ Add authentication for multi-user support

👩‍💻 Author
SolarX
🎯 Built with care for real-world use — powered by C#


📝 License
Feel free to use and modify for personal or educational purposes.
(If you do something cool with it, let me know!)
