# SOLID Principles: Professional Summary and Practical Applications

## Table of Contents
1. [Introduction](#introduction)
2. [Professional Summary](#professional-summary)
3. [Visual Application: Diagrams](#visual-application-diagrams)
4. [SOLID Principles Summary](#solid-principles-summary)
    1. [Single Responsibility Principle (SRP)](#1-single-responsibility-principle-srp)
    2. [Open/Closed Principle (OCP)](#2-openclosed-principle-ocp)
    3. [Liskov Substitution Principle (LSP)](#3-liskov-substitution-principle-lsp)
    4. [Interface Segregation Principle (ISP)](#4-interface-segregation-principle-isp)
    5. [Dependency Inversion Principle (DIP)](#5-dependency-inversion-principle-dip)
5. [Professional Relevance](#professional-relevance)
6. [Conclusion](#conclusion)

---

## Introduction
The SOLID principles are five key rules in object-oriented design that help you create scalable, maintainable, and robust software. These were promoted by Robert C. Martin (Uncle Bob), and the acronym was coined by Michael Feathers.

---

## Professional Summary

| Principle | Objective | Key Benefit |
|----------|----------|------------------|
| SRP - Single Responsibility | A class should only have one reason to change. | Cohesive and easily maintainable classes |
| OCP - Open/Closed | Code should be open for extension but closed for modification. | Fewer bugs when extending functionality |
| LSP - Liskov Substitution | Subclasses should replace base classes without unexpected behavior. | Reliable inheritance and safe polymorphism |
| ISP - Interface Segregation | Many small interfaces are better than a general-purpose one. | Flexible, reusable modules |
| DIP - Dependency Inversion | Depend on abstractions, not concrete classes. | Low coupling and high flexibility |

---

## Visual Application: Diagrams

1. **Invoice Diagram (SRP and OCP)**:
   - Business logic (Invoice), printing (InvoicePrint), and persistence (InvoicePersistence) are separated.
   - Interface use enables extensibility (save to file, database, etc.).

2. **Parking Diagram (ISP)**:
   - Separate interfaces for different parking types.
   - FreeParking is not forced to implement payment logic.

---

## SOLID Principles Summary

### 1. Single Responsibility Principle (SRP)
- A class should have only one reason to change.

**Before Refactor**:
```csharp
public class CEmployee {
    private string name;
    private string position;
    private int age;
    private double salary;

    public CEmployee(string name, string position, int age, double salary) {
        this.name = name;
        this.position = position;
        this.age = age;
        this.salary = salary;
    }

    public override string ToString() {
        return $"Name: {name}, Position: {position}, Age: {age}, Salary: {salary}";
    }

    public double CI(){
        return salary * 0.1; // 10% commission
    }

    public void PI(){
        double imp = CI();
        Console.WriteLine($"Pay {imp} in {name}");
    }
}
```
This class violates SRP by handling:
- Employee data
- Commission calculation
- Payment display

**After Refactor**:
```csharp
public class CEmployee {
    public string Name { get; set; }
    public double Salary { get; set; }
    public CEmployee(string name, string position, int age, double salary) {
        Name = name;
        Salary = salary;
        // other fields omitted for SRP
    }
    public override string ToString() {
        return $"Name: {Name}, Salary: {Salary}";
    }
}

public static class CTaxesDepartment {
    public static double CI(CEmployee employee) {
        return employee.Salary * 0.1;
    }

    public static void PI(CEmployee employee) {
        double imp = CI(employee);
        Console.WriteLine($"Pay {imp} in {employee.Name}");
    }
}
```
This separation ensures each class has only one responsibility:
- `CEmployee`: holds data
- `CTaxesDepartment`: manages tax logic

![SRP Diagram](srp-diagram-placeholder)

### 2. Open/Closed Principle (OCP)
- Open for extension, closed for modification.

**Before Refactor**:
```csharp
public class CStore {
    private List<CProduct> products = new List<CProduct>();

    public CStore(List<CProduct> pProducts) {
        this.products = pProducts;
    }

    public void CI(){
        double total = 0;
        foreach (CProduct cProduct in products){
            Console.WriteLine(cProduct);
            total += cProduct.Price;
        }

        // Discount logic by category
        foreach(CProduct cProduct in products){
            if (cProduct.Category == 1){
                total += cProduct.Price * 0.9; // 10% discount
            } else if (cProduct.Category == 2){
                total += cProduct.Price * 0.8; // 20% discount
            }
        }
    }
}
```
This implementation violates OCP since new categories require modifying the `CI` method directly.

**After Refactor**:
```csharp
abstract class CBaseInventory {
    protected CProduct product;

    public CProduct Product {
        get { return product; }
        set { product = value; }
    }

    public CBaseInventory(CProduct product) {
        this.product = product;
    }

    public abstract double GetPrice();
}

class CAlimentInventory : CBaseInventory {
    public CAlimentInventory(CProduct product) : base(product) {}
    public override double GetPrice() {
        product.Price *= 1.2; // 20% markup
        return product.Price;
    }
}

class CMedicamentInventory : CBaseInventory {
    public CMedicamentInventory(CProduct product) : base(product) {}
    public override double GetPrice() {
        product.Price *= 0.8; // 20% discount
        return product.Price;
    }
}

class CStore {
    private List<CBaseInventory> products;

    public CStore(List<CBaseInventory> pProducts) {
        products = pProducts;
    }

    public void CI() {
        double total = 0;
        foreach (CBaseInventory product in products) {
            product.GetPrice();
            Console.WriteLine(product);
            total += product.Product.Price;
        }
        Console.WriteLine("Total is {0}", total);
    }
}
```
This refactor applies the Strategy Pattern and follows the Open/Closed Principle:
- New categories can be added via subclasses of `CBaseInventory`.
- Existing logic is untouched.

![OCP Diagram](ocp-diagram-placeholder)

### 3. Liskov Substitution Principle (LSP)
- Subclasses must behave like their base classes.
- **Example**: `Square` inherits from `Rectangle` but breaks expected behavior, causing test failures.

### 4. Interface Segregation Principle (ISP)
- Interfaces should be small and specific.
- **Example**: `FreeParking` benefits from separated interfaces for payment and capacity.

### 5. Dependency Inversion Principle (DIP)
- Depend on abstractions, not on concrete implementations.
- **Example**: `PersistenceManager` uses `InvoicePersistence` instead of specific classes.

---

## Professional Relevance
- **Code Quality**: Cleaner, more readable, and maintainable.
- **Scalability**: Easier to add new features.
- **Team Collaboration**: Fewer merge conflicts, clear class/module ownership.
- **Testing**: Easier to test decoupled, cohesive classes.

---

## Conclusion
Applying SOLID leads to highly cohesive, loosely coupled, and change-resilient software. Learning these principles is essential for any professional object-oriented developer.

> "Design is the way we structure code so that change becomes a safe and simple operation."

