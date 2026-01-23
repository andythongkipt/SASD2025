using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring101
{
    // Do Refactoring the following code:
    public class QuestionsAndAnswers
    {
        // 1. Mysterious Name
        public double Calc(double a, double b)
        {
            return a > b ? a : b;
        }

        public void Print()
        {
            string name = "   Mr.Harry Potter";

            PrintSection();
            PrintSection();
            PrintSection();
        }

        private void PrintSection()
        {
            Console.WriteLine("***********************");
            PrintBody();
            Console.WriteLine("***********************");
            Console.WriteLine();
        }

        private void PrintBody()
        {
            Console.WriteLine("...");
        }

    }

    // 3. Shotgun Surgery
    public class Shotgun1
        {
            public void DisplayStudents()
            {
                Console.WriteLine("Student Count = " + 48);
            }
        }
        public class Shotgun2
        {
            public void PrintTotal()
            {
                Console.WriteLine("Total Students : " + 48);
            }
        

        // 4. Data Clump
        public void PrintDate(int day, int month, int year)
        {
            Console.WriteLine($"{day:00}/{month:00}/{year:0000}");
        }
        // 5. Feature Envy
        //     จากข้อที่แล้ว น่าจะได้สร้างคลาส Date ขึ้นมา
        //     ในคลาส Date นั้นให้สร้าง method: public string Format()
        //      ปรับให้ PrintDate(...) ของเดิม ไปเรียก date.Format() ดังกล่าว
    }
}
