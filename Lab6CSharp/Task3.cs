using System;
using System.Collections;
using System.Collections.Generic;

// Абстрактний клас Товар
abstract class Product : IEnumerable<Product>
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public DateTime ProductionDate { get; set; }
    public DateTime ExpiryDate { get; set; }

    // Конструктор
    public Product(string name, decimal price, DateTime productionDate, DateTime expiryDate)
    {
        Name = name;
        Price = price;
        ProductionDate = productionDate;
        ExpiryDate = expiryDate;
    }

    // Метод, що виводить інформацію про товар на екран
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Назва: {Name}");
        Console.WriteLine($"Ціна: {Price}");
        Console.WriteLine($"Дата виробництва: {ProductionDate.ToShortDateString()}");
        Console.WriteLine($"Термін придатності: {ExpiryDate.ToShortDateString()}");
    }

    // Метод, що перевіряє чи відповідає строк придатності на поточну дату
    public bool IsExpired()
    {
        return DateTime.Now > ExpiryDate;
    }

    // Реалізація інтерфейсу IEnumerable<Product>
    public abstract IEnumerator<Product> GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

// Похідний клас Партія
class Batch : Product
{
    public int Quantity { get; set; }

    // Конструктор
    public Batch(string name, decimal price, int quantity, DateTime productionDate, DateTime expiryDate)
        : base(name, price, productionDate, expiryDate)
    {
        Quantity = quantity;
    }

    // Перевизначений метод для виведення інформації
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Кількість: {Quantity}");
    }

    // Реалізація інтерфейсу IEnumerable<Product>
    public override IEnumerator<Product> GetEnumerator()
    {
        yield return this;
    }
}

// Похідний клас Комплект
class Kit : Product
{
    public List<Product> Products { get; set; }

    // Конструктор
    public Kit(string name, decimal price, List<Product> products, DateTime expiryDate)
        : base(name, price, DateTime.Now, expiryDate)
    {
        Products = products;
    }

    // Перевизначений метод для виведення інформації
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Склад продуктів:");
        foreach (var product in Products)
        {
            product.DisplayInfo();
        }
    }

    // Реалізація інтерфейсу IEnumerable<Product>
    public override IEnumerator<Product> GetEnumerator()
    {
        foreach (var product in Products)
        {
            yield return product;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Приклад створення бази з товарів
        List<Product> products = new List<Product>
        {
            new Batch("Печиво", 25.99m, 50, new DateTime(2023, 1, 1), new DateTime(2024, 12, 31)),
            new Batch("Молоко", 30.50m, 10, new DateTime(2024, 1, 1), new DateTime(2024, 3, 15)),
            new Kit("Сніданок", 100.00m, new List<Product>
            {
                new Batch("Хліб", 15.00m, 2, new DateTime(2024, 3, 1), new DateTime(2024, 4, 1)),
                new Batch("Яйця", 20.00m, 12, new DateTime(2024, 3, 1), new DateTime(2024, 3, 15))
            }, new DateTime(2024, 4, 1))
        };

        // Виведення повної інформації з бази на екран
        Console.WriteLine("Повна інформація про товари:");
        foreach (var product in products)
        {
            product.DisplayInfo();
            Console.WriteLine();
        }

        // Пошук прострочених товарів
        Console.WriteLine("\nПрострочені товари:");
        foreach (var product in products)
        {
            if (product.IsExpired())
            {
                Console.WriteLine($"{product.Name} прострочений.");
            }
        }
    }
}
