using System.Collections.Generic;

namespace xml_linq
{
    internal class Student
    {
        internal double gpa;

        public List<int> Scores { get; internal set; }
        public string Last { get; internal set; }
        public string First { get; internal set; }
        public int ID { get; internal set; }
    }
}