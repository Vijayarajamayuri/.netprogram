using System;
using System.Collections.Generic;

namespace Student
{
   
    class StudentDriver
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Student> stuList = new List<Student>();

            stuList.Add(new Student("Adam", 33, 23));
            stuList.Add(new Student("Bob", 30, 23));
            stuList.Add(new Student("Charlie", 29, 23));
            stuList.Add(new Student("Dan", 60, 23));

            Student.computeClassification(stuList, classify);
            ugClassifireDel classify = new ugClassifireDel(UMKC);
            void UMKC(Student s)
            {

            
          
                if (s.Credits == 30)
                {
                    Console.WriteLine(s.Name + " will be a freshman");
                }
                else if (s.Credits == 60)
                {
                    Console.WriteLine(s.Name + " You will be a sophomore");
                }
                else
                {
                    Console.WriteLine(s.Name + " Invalid Data");
                }
            }
        }
    }

      delegate void classifierDel(Student s);

    class Student
    {
        private string sName;
        private int creditHoursFinished;
        private int age;

        public Student(string sName, int creditHoursFinished, int age)
        {
            this.sName = sName;
            this.creditHoursFinished = creditHoursFinished;
            this.age = age;
        }

        public int Credits
        {
            get { return creditHoursFinished; }
            set { creditHoursFinished = value; }
        }

        public string Name
        {
            get { return sName; }
            set { sName = value; }
        }

        public override string ToString()
        {
            return creditHoursFinished+" " +age;
        }

        public static void computeClassification(List<Student> stuList, ugClassifireDel del)
        {
            foreach (Student s in stuList)
            {
                del(s);
            }
        }
    }
}