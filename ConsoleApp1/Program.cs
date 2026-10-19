using System;
using System.Linq;
using System.Collections;

namespace LINQ
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int[] Scores { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrList = new ArrayList();
            arrList.Add(new Student { FirstName = "Svetlana", LastName = "Omelchenko", Scores = new int[] { 98, 92, 81, 60 } });
            arrList.Add(new Student
            {
                FirstName = "Claire",
                LastName = "O’Donnell",
                Scores = new int[] { 75, 84, 91, 39 }
            });
            arrList.Add(new Student
            {
                FirstName = "Sven",
                LastName = "Mortensen",
                Scores = new int[] { 88, 94, 65, 91 }
            });
            arrList.Add(new Student
            {
                FirstName = "Cesar",
                LastName = "Garcia",
                Scores = new int[] { 97, 89, 85, 82 }
            });

            var query = from Student student in arrList
                        where student.Scores[0] > 95
                        select student;

            foreach (Student s in query)
                Console.WriteLine(s.LastName + ": " + s.Scores[0]);

            // Оставить консольное окно открытым в режиме отладки
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }

}
