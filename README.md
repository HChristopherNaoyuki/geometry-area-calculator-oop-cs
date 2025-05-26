# Geometry Area Calculator

A simple object-oriented console application written in C# to calculate and display the area of geometric shapes such as rectangles and circles.

---

## Project Name
**`geometry-area-calculator-oop-cs`**

---

## Features

- Calculate area of **Rectangle**
- Calculate area of **Circle**
- Uses **Object-Oriented Programming (OOP)** principles:
  - Inheritance
  - Polymorphism
  - Abstraction
  - Interfaces

---

## Project Structure

```bash
geometry-area-calculator-oop-cs/
│
├── Program.cs          // Entry point for user interaction
├── Solution.cs         // Core logic to handle shapes
├── Shape.cs            // Base abstract class for shapes
├── IShape.cs           // Interface defining area calculation
├── Rectangle.cs        // Rectangle class implementing Shape and IShape
├── Circle.cs           // Circle class implementing Shape and IShape
└── README.md           // Project documentation
```

---

## Technologies Used

- C#
- .NET Console Application
- OOP Design

---

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/en-us/download)
- C# development environment (Visual Studio / VS Code / JetBrains Rider)

### Running the Application

1. **Clone the repository:**
   ```bash
   git clone https://github.com/your-username/geometry-area-calculator-oop-cs.git
   cd geometry-area-calculator-oop-cs
   ```

2. **Build and run the project:**

   ```bash
   dotnet run
   ```

3. **Expected Output:**

   ```
   Shape: My Rectangle
   Rectangle Area: 50
   Shape: My Circle
   Circle Area: 153.93804002589985
   ```

---

## OOP Principles Demonstrated

| Principle    | Description                                                                |
| ------------ | -------------------------------------------------------------------------- |
| Inheritance  | `Rectangle` and `Circle` inherit from the base class `Shape`.              |
| Abstraction  | `Shape` class provides a common interface for all shapes.                  |
| Polymorphism | `Display` method can be overridden by derived classes.                     |
| Interface    | `IShape` enforces the implementation of `CalculateArea` across all shapes. |

---

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

## Contributing

Feel free to fork this repo, open issues, or submit pull requests to improve functionality or add new shape types.

---
