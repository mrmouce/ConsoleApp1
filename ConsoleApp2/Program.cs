using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqVar8
{
    public class Car
    {
        public string Model { get; set; }          // Название/Модель машины
        public int MaxSpeed { get; set; }          // Максимальная скорость
        public string Color { get; set; }          // Цвет
        public string Manufacturer { get; set; }   // Производитель
        public int PassengersCount { get; set; }   // Число пассажиров
    }
    public class Product
    {
        public string Name { get; set; }           // Название продукта
        public int PackagesCount { get; set; }     // Количество упаковок на складе
        public string Description { get; set; }    // Описание продукта
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] A = { "Falluot 3", "Daxter 2", "System Shok 2", "Morrowind", "Pes 2013" };
            int[] B = { 2, -7, -10, 6, 7, 9, 3 };
            string[] C = { "Light Green", "Red", "Green", "Yellow", "Purple", "Dark Green", "Light Red", "Dark Red", "Dark Yellow", "Light Yellow" };

            void Otdelenie(int length = 40)
            { Console.WriteLine(new string('-', 20)); }

            Console.WriteLine("1)	Написать запрос для нахождения элементов массива А, включающих цифры.");
            var pervoe = from elements in A
                         where elements.Any(Char.IsDigit)
                         select elements;
            foreach (string final1 in pervoe)
                Console.WriteLine(final1);
            Otdelenie();

            Console.WriteLine("2)	Написать запрос для нахождения отрицательных элементов массива В.");
            var vtoroe = from numbers in B
                         where numbers < 0
                         select numbers;
            foreach (int final2 in vtoroe)
                Console.WriteLine(final2);
            Otdelenie();

            Console.WriteLine("3)	Написать запрос для нахождения всех темных(dark) оттенков цвета в массиве С.");
            var tretie = from Tcveta in C
                         where Tcveta.Contains("Dark")
                         select Tcveta;
            foreach (string final3 in tretie)
                Console.WriteLine(final3);
            Otdelenie();

            Console.WriteLine("4)	Создать список автомобилей класса Car.Выбрать из списка автомобили белого цвета и вывести всю информацию о них.");
            List<Car> carList = new List<Car>()
            {
                new Car { Model = "Yugo", MaxSpeed = 140, Color = "White", Manufacturer = "Zastava", PassengersCount = 4 },
                new Car { Model = "Aztec", MaxSpeed = 180, Color = "Red", Manufacturer = "Pontiac", PassengersCount = 5 },
                new Car { Model = "BMW", MaxSpeed = 250, Color = "White", Manufacturer = "BMW Group", PassengersCount = 5 },
                new Car { Model = "Saab", MaxSpeed = 210, Color = "Black", Manufacturer = "Saab Automobile", PassengersCount = 5 }
            };
            var Chetvertoe = from car in carList
                             where car.Color == "White"
                             select car;
            foreach (Car final4 in Chetvertoe)
                Console.WriteLine($"Модель: {final4.Model}, Цвет: {final4.Color}, Макс. скорость: {final4.MaxSpeed} км/ч, Производитель: {final4.Manufacturer}, Пассажиров: {final4.PassengersCount}");
            Otdelenie();

            Console.WriteLine("5)	Создать список продуктов класса Product.Выбрать из списка продукты, с количеством упаковок меньше 20 единиц и вывести всю информацию о них.");
            List<Product> productList = new List<Product>()
            {
                new Product { Name = "Молоко 3.2%", PackagesCount = 50, Description = "Свежее пастеризованное молоко" },
                new Product { Name = "Хлеб Бородинский", PackagesCount = 15, Description = "Ржаной хлеб из печи" },
                new Product { Name = "Шоколад Аленка", PackagesCount = 120, Description = "Классический молочный шоколад" },
                new Product { Name = "Сыр Гауда", PackagesCount = 8, Description = "Твердый сыр, нарезка" }
            };
            var pyatoe = from prod in productList
                         where prod.PackagesCount < 20
                         select prod;
            foreach (Product final5 in pyatoe)
                Console.WriteLine($"Продукт: {final5.Name} | Остаток: {final5.PackagesCount} уп. | Описание: {final5.Description}");
            Otdelenie();

            Console.WriteLine("6)	Вывести результирующий набор списков myCars и yourCars, содержащий все элементы с повторениями.");
            List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };
            var shestoe = myCars.Concat(yourCars);
            foreach (string car in shestoe)
                Console.WriteLine(car);
        }
    }
}

