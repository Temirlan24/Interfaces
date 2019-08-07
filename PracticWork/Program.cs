using System;

namespace PracticWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine("Введите имя студента:");
            student.Name = Console.ReadLine();
            Console.WriteLine("Введите полное имя студента:");
            student.FullName = Console.ReadLine();
            Console.WriteLine("Введите количество оценок: ");
            int.TryParse(Console.ReadLine(), out int size);
            student.Grades = new int[size];
            Console.WriteLine("Введите оценки:");
            for (int i = 0; i < size; i++)
            {
                student.Grades[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Имя студента - " + student.Name);
            Console.WriteLine("Полное имя (ФИО) студента - " + student.FullName);
            Console.WriteLine("Средняя оценка студента =" + student.GetAvgGrade(size));

        }
    }
}
