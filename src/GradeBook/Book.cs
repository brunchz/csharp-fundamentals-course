using System;
using System.Collections.Generic;

namespace GradeBook
{
    
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }
        public void AddGrade(double grade)
        {
            if(grade >= 0 && grade <= 100)
            {
                grades.Add(grade);

            }else
            {
                System.Console.WriteLine("Invalid value");
            }
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            // Find the sum of numbers in an array 
            for(var i = 0; i < grades.Count; i++)
            {
                result.High = Math.Max(grades[i], result.High);
                result.Low = Math.Min(grades[i], result.Low);
                result.Average += grades[i];
            } 
            // Find the average of all the numbers in the array.
            result.Average /= grades.Count;
                

            return result;
        }


        private List<double> grades;
        public string Name;
    }
} 