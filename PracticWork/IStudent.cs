using System;
using System.Collections.Generic;
using System.Text;

namespace PracticWork
{
    public interface IStudent
    {
        string Name { get; set; }
        string FullName { get; set; }
        int[] Grades { get; set; }
        String GetName();
        String GetFullName();
        Double GetAvgGrade(int size);

    }
}
