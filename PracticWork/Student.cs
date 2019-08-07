using System;
using System.Collections.Generic;
using System.Text;

namespace PracticWork
{
    public class Student : IStudent
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public int[] Grades { get; set; }

        public double GetAvgGrade(int size)
        {
            double avgSum = 0;
            for (int i = 0; i < size; i++)
            {
                avgSum += Grades[i];
            }
            return avgSum / size;
        }

        public string GetFullName()
        {
            return FullName;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
