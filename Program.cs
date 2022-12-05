using System;

namespace Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grade = 1;
            int excludedGrade = 0;
            double totalGrade = 0;

            while (grade <= 12)
            {
                double secGrade = double.Parse(Console.ReadLine());

                if (secGrade < 4)
                {
                    excludedGrade++;
                }
                if (excludedGrade == 2)
                {
                    Console.WriteLine($"{name} has been excluded at {grade - 1} grade");
                    break;
                }
                totalGrade += secGrade;
                grade++;
            }
            double average = totalGrade / 12;
            if (excludedGrade < 2)
            {
                Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
            }
        }
    }
}

