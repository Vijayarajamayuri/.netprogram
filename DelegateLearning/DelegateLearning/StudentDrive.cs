using System;
using System.Collections.Generic;
namespace DelegateLearning
{
    class StudentDrive
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Student> stuList = new List<Student>();

            stuList.Add(new Student("Adam", 33, 23));
            stuList.Add(new Student("Bob", 30, 23));
            stuList.Add(new Student("Charlie", 29, 23));
            stuList.Add(new Student("Dan", 60, 23));


            DelStudent del = new DelStudent(myRules);
            Student.computeclassification(stuList, del);
            void myRules(Student s)
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

        delegate void DelStudent(Student s);
        class Student
        {
            private string name;
            private int creditHours;
            private int age;

            public Student(string name, int creditHours, int age)
            {
                this.name = name;
                this.creditHours = creditHours;
                this.age = age;
            }
            public string Name
            {
                get {
                    return name; }
                set
                {
                    name = value;
                }
            }
            public int Credits
            {
                get
                {
                    return creditHours;
                }
                set
                {
                    creditHours = value;
                }
            }
            public override string ToString()
            {
                return creditHours+"" + age;
            }
            public static void computeclassification(List<Student> stuList, DelStudent del)
            {
                foreach (Student s in stuList)
                {
                    del(s);
                }
            }
            }
        }
    }

