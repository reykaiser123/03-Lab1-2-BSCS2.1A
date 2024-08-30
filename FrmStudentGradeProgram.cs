using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeApplication
{
    internal class FrmStudentGradeProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Grade Application:");
            Console.Write("Name: ");
            String name = Console.ReadLine();
            Console.Write("Course: ");
            String course = Console.ReadLine();

            Console.WriteLine("Will you check this student grade? YES OR NO");
            String  grade = Console.ReadLine();

            if (grade == "yes" || grade == "Yes" || grade == "YES")
            {
                Console.WriteLine("Input Grades:");
                Console.Write("English: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Math: ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.Write("Science: ");
                double c = Convert.ToDouble(Console.ReadLine());

                Console.Write("Filipino: ");
                double d = Convert.ToDouble(Console.ReadLine());

                Console.Write("History: ");
                double e = Convert.ToDouble(Console.ReadLine());


                double sum = a + b + c + d + e;
                double[] sum2 = {a,b,c,d,e };
                double avg = sum / sum2.Length;

                if (sum > 74)
                {
                    Console.WriteLine("This student passed");
                    Console.Write("The general average of " + name + "is " + avg);
                    Console.ReadLine();
                }

                else if (sum < 75)
                {
                    Console.WriteLine("This student failed");
                    Console.Write("The general average of " + name + "is " + avg);
                    Console.ReadLine();
                }
            }
            else if (grade == "no" || grade == "No" || grade == " NO")
            {
                Console.WriteLine("Have a good day.");
                Console.ReadLine();
            }


        }
    }
}
