// using System;

// // Інтерфейс інтерфейсу користувача
// interface IUserInterface
// {
//     void Show();
// }

// // Інтерфейс .NET
// interface IDotNet
// {
//     void UseDotNetFeatures();
// }

// // Базовий клас "Персона"
// class Person : IUserInterface
// {
//     // Характеристики базового класу
//     public string Name { get; set; }
//     public int Age { get; set; }

//     public Person(string name, int age)
//     {
//         Name = name;
//         Age = age;
//     }

//     public void Show()
//     {
//         Console.WriteLine($"Name: {Name}, Age: {Age}");
//     }
// }

// // Похідний клас "Студент"
// class Student : Person, IDotNet
// {
//     // Характеристики класу "Студент"
//     public string StudentID { get; set; }
//     public string Major { get; set; }

//     public Student(string name, int age, string studentID, string major) : base(name, age)
//     {
//         StudentID = studentID;
//         Major = major;
//     }

//     public new void Show()
//     {
//         base.Show();
//         Console.WriteLine($"Student ID: {StudentID}, Major: {Major}");
//     }

//     public void UseDotNetFeatures()
//     {
//         Console.WriteLine("Using .NET features as a student.");
//     }
// }

// // Похідний клас "Викладач"
// class Teacher : Person, IDotNet
// {
//     // Характеристики класу "Викладач"
//     public string Department { get; set; }
//     public string Subject { get; set; }

//     public Teacher(string name, int age, string department, string subject) : base(name, age)
//     {
//         Department = department;
//         Subject = subject;
//     }

//     public new void Show()
//     {
//         base.Show();
//         Console.WriteLine($"Department: {Department}, Subject: {Subject}");
//     }

//     public void UseDotNetFeatures()
//     {
//         Console.WriteLine("Using .NET features as a teacher.");
//     }
// }

// // Похідний клас "Завідувач кафедри"
// class DepartmentHead : Teacher
// {
//     public DepartmentHead(string name, int age, string department, string subject) : base(name, age, department, subject)
//     {
//     }

//     public new void Show()
//     {
//         base.Show();
//         Console.WriteLine("Position: Department Head");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Student student = new Student("John Doe", 20, "S12345", "Computer Science");
//         Teacher teacher = new Teacher("Jane Smith", 35, "Computer Science", "Programming");
//         DepartmentHead departmentHead = new DepartmentHead("Dr. William Johnson", 50, "Computer Science", "Computer Engineering");

//         Console.WriteLine("Student Information:");
//         student.Show();
//         Console.WriteLine();

//         Console.WriteLine("Teacher Information:");
//         teacher.Show();
//         Console.WriteLine();

//         Console.WriteLine("Department Head Information:");
//         departmentHead.Show();
//     }
// }
