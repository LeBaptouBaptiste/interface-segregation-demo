# Interface Segregation Principle (ISP)

This repository provides a short and accessible explanation of the **I** in **SOLID**: the *Interface Segregation Principle*.  
It includes theory, benefits, and clear examples of both incorrect and correct implementations.

---

## 📘 Overview

The **SOLID** principles are five guidelines for writing clean, maintainable, and extensible object‑oriented code.  
This project focuses on the **I — Interface Segregation Principle (ISP)**.

**Definition:**  
> A class should not be forced to implement methods it does not use.  
> Prefer several small, specific interfaces instead of one large, general one.

---

## 🧠 Why ISP Matters

- Avoids “fat” interfaces filled with unrelated responsibilities  
- Reduces unnecessary dependencies  
- Makes code easier to maintain  
- Prevents empty methods or `NotImplementedException`  
- Increases flexibility and testability  

---

## ❌ Bad Example (Violating ISP)

```csharp
public interface IWorker
{
    void Work();
    void Eat();
}

public class Robot : IWorker
{
    public void Work()
    {
        Console.WriteLine("Robot working...");
    }

    public void Eat()
    {
        // A robot does not eat.
        throw new NotImplementedException();
    }
}
```

The robot is forced to implement a method that makes no sense for it.

---

## ✔ Good Example (Respecting ISP)

```csharp
public interface IWork
{
    void Work();
}

public interface IEat
{
    void Eat();
}

public class Human : IWork, IEat
{
    public void Work() => Console.WriteLine("Human working...");
    public void Eat() => Console.WriteLine("Human eating...");
}

public class Robot : IWork
{
    public void Work() => Console.WriteLine("Robot working...");
}
```

Each class only implements what it actually needs.

---

## 📂 Repository Structure

```
/theory
    isp-overview.md
/examples
    bad-example.cs
    good-example.cs
README.md
```

---

## 🎯 Purpose

This repository is designed for students and developers who want a simple, clean introduction to the Interface Segregation Principle, with examples they can reuse in class or adapt for personal projects.

---

Happy learning!
