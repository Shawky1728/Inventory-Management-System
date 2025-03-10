# Inventory Management System

## Description
The **Inventory Management System** is a simple console-based application developed in C#. It allows users to add, update, and view products efficiently. The system stores product information, including name, quantity, and price, in a structured format using a 2D array.

## Features
- Add new products
- Update existing products
- View all stored products
- Simple and interactive console UI

## Installation and Usage
### Prerequisites
- .NET SDK installed on your machine

### Steps to Run
1. Clone the repository or copy the code into a C# project.
2. Open the project in a C# development environment (e.g., Visual Studio, Visual Studio Code).
3. Build and run the application.

### Running the Application
Once the application starts, you will see the following menu:
```
Welcome to The inventory system (^_^)
-----------------------------------
1 . Add product
2 . Update product
3 . View product
4 . Exit
```
Enter the number corresponding to your choice and follow the instructions.

## How It Works
1. **Adding a Product:**
   - Enter product name, quantity, and price.
   - The product is stored in the inventory array.
2. **Updating a Product:**
   - Enter the product ID (index in the array).
   - Update product details.
3. **Viewing All Products:**
   - Displays the list of stored products.
4. **Exiting:**
   - Terminates the program.

## Limitations
- Supports a maximum of 50 products (due to a fixed-size array).
- No persistent storage (data is lost when the program exits).

## Future Improvements
- Implement file/database storage for persistence.
- Improve the UI with a graphical interface.
- Add product categorization and search functionality.

## License
This project is open-source and available under the MIT License.

---
Enjoy using the **Inventory Management System**! 🚀

