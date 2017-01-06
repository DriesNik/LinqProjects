using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQprojects
{
    class Storage
    {
        public void ClassRoomAverage()
        {
            List<int> studentAverage = new List<int>();
            List<string> grades = new List<string>();
            grades.Add("59,80,67,89,100,50");
            grades.Add("99,97,89,93,97,99");
            grades.Add("85,87,88,98,100,72");
            grades.Add("68,70,98,76,56,100");
            grades.Add("92,94,99,96,91,95");
            grades.Add("81,83,40,59,64,100");

            foreach (var grade in grades)
            {
                List<int> averagePerson = new List<int>();
                string[] words = grade.Split(',');
                foreach (string number in words)
                {
                    var FixedNumber = int.Parse(number);
                    averagePerson.Add(FixedNumber);

                }
                var MinGrade = (from d in averagePerson select d).Min();
                averagePerson.Remove(MinGrade);
                var gradeCount = (from personalGrade in averagePerson select personalGrade).Count();
                var gradeSum = (from personalGrade in averagePerson select personalGrade).Sum();
                var NewAverage = (gradeSum / gradeCount);
                studentAverage.Add(NewAverage);

                Console.WriteLine("Student Average Grade:");
                Console.WriteLine(NewAverage);

            }
            var ClassCount = (from counting in studentAverage select counting).Count();
            var ClassSum = (from summing in studentAverage select summing).Sum();
            var ClassAverage = (ClassSum / ClassCount);
            Console.WriteLine("Class Average Is:");
            Console.WriteLine(ClassAverage);
            Console.ReadLine();
        }
        public void ListSpecial()
        {
            List<string> specialList = new List<string>();
            specialList.Add("pie");
            specialList.Add("apple");
            specialList.Add("zebra");
            specialList.Add("cancel");
            specialList.Add("pie");

            IEnumerable<string> Unique = specialList.Distinct();

            foreach (string item in Unique)
            {
                Console.WriteLine(item);
            }


        }

        public void BreakDown()
        {
            List<string> Words = new List<string>();
            Console.WriteLine("Enter the Word");
            string Sentance = Console.ReadLine();
            foreach (char Letter in Sentance)
            {
                Words.Add(Letter.ToString());
                ///Console.WriteLine(Letter.ToString());
            }
            var query = Words.GroupBy(x => x[0]);
            foreach(var letter in query)
            {
                Console.Write("{0}{1} ", letter.Key,letter.Count());
            }
            Console.WriteLine();
        }
    }
}
