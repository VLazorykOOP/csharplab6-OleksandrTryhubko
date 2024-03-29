// using System;

// // Абстрактний клас Товар
// abstract class Product
// {
//     public string Name { get; set; }
//     public double Price { get; set; }
//     public DateTime ManufactureDate { get; set; }
//     public DateTime ExpiryDate { get; set; }

//     // Конструктор класу
//     public Product(string name, double price, DateTime manufactureDate, DateTime expiryDate)
//     {
//         Name = name;
//         Price = price;
//         ManufactureDate = manufactureDate;
//         ExpiryDate = expiryDate;
//     }

//     // Метод, що виводить інформацію про товар
//     public virtual void DisplayInfo()
//     {
//         Console.WriteLine($"Назва: {Name}");
//         Console.WriteLine($"Ціна: {Price}");
//         Console.WriteLine($"Дата виробництва: {ManufactureDate}");
//         Console.WriteLine($"Строк придатності: {ExpiryDate}");
//     }

//     // Метод, що перевіряє, чи товар прострочений
//     public bool IsExpired()
//     {
//         return DateTime.Now > ExpiryDate;
//     }
// }

// // Похідний клас Продукт
// class ProductItem : Product
// {
//     public ProductItem(string name, double price, DateTime manufactureDate, DateTime expiryDate) 
//         : base(name, price, manufactureDate, expiryDate)
//     {
//     }

//     // Метод, що перевизначає вивід інформації про товар
//     public override void DisplayInfo()
//     {
//         Console.WriteLine("Продукт:");
//         base.DisplayInfo();
//     }
// }

// // Похідний клас Партія
// class Batch : Product
// {
//     public int Quantity { get; set; }

//     public Batch(string name, double price, int quantity, DateTime manufactureDate, DateTime expiryDate) 
//         : base(name, price, manufactureDate, expiryDate)
//     {
//         Quantity = quantity;
//     }

//     // Метод, що перевизначає вивід інформації про товар
//     public override void DisplayInfo()
//     {
//         Console.WriteLine("Партія:");
//         base.DisplayInfo();
//         Console.WriteLine($"Кількість: {Quantity}");
//     }
// }

// // Похідний клас Комплект
// class Set : Product
// {
//     public string[] Products { get; set; }

//     public Set(string[] products, double price, DateTime manufactureDate, DateTime expiryDate) 
//         : base("Комплект", price, manufactureDate, expiryDate)
//     {
//         Products = products;
//     }

//     // Метод, що перевизначає вивід інформації про товар
//     public override void DisplayInfo()
//     {
//         Console.WriteLine("Комплект:");
//         Console.WriteLine($"Ціна: {Price}");
//         Console.WriteLine($"Дата виробництва: {ManufactureDate}");
//         Console.WriteLine($"Строк придатності: {ExpiryDate}");
//         Console.WriteLine("Склад:");
//         foreach (var product in Products)
//         {
//             Console.WriteLine(product);
//         }
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Створення бази товарів
//         Product[] products = new Product[]
//         {
//             new ProductItem("Молоко", 15.5, new DateTime(2024, 3, 1), new DateTime(2024, 4, 1)),
//             new Batch("Хліб", 10, 3, new DateTime(2024, 3, 10), new DateTime(2024, 3, 31)),
//             new Set(new string[] { "Молоко", "Хліб" }, 20, new DateTime(2024, 3, 1), new DateTime(2024, 4, 1)),
//             new ProductItem("Яблука", 12.0, new DateTime(2024, 3, 5), new DateTime(2024, 3, 20)),
//             new Batch("Масло", 30.0, 2, new DateTime(2024, 3, 8), new DateTime(2024, 4, 8)),
//             new Set(new string[] { "Масло", "Мед" }, 40, new DateTime(2024, 3, 2), new DateTime(2024, 4, 2))
//         };

//         // Виведення повної інформації з бази на екран
//         foreach (var product in products)
//         {
//             product.DisplayInfo();
//             Console.WriteLine();
//         }

//         // Пошук прострочених товарів
//         Console.WriteLine("Прострочені товари:");
//         foreach (var product in products)
//         {
//             if (product.IsExpired())
//             {
//                 product.DisplayInfo();
//                 Console.WriteLine();
//             }
//         }
//     }
// }
