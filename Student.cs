using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp
{
    public class Student
    {
        public int studentId;
        public string StudentName;
        public int age;
        public int standardId;
        internal int standardID;

        public Student(int studentId, string StudentName, int age, int standardId) {
            studentId = this.studentId;
            StudentName = this.StudentName;
            age = this.age;
            standardId = this.standardId;
                }
    }
    public class Standard {
        public int standardID;
        public string standardName;
        public Standard(int standardID, string standardName) {
            standardID = this.standardID;
            standardName = this.standardName;
        }
    }

    public class LinqTest {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>() {
        new Student(1,"Pranathi",18,1),
        new Student(2,"Prana",21,1),
        new Student(3,"Prem",18,1),
        new Student(4,"Priya",20,1),
        new Student(5,"Mary",21,1),
        };

            IList<Standard> standardList = new List<Standard>() {
    new Standard( 1, "Standard 1"),
    new Standard( 2, "Standard 2"),
    new Standard( 3, "Standard 3")
};
            var studentNames = studentList.Where(s => s.age > 18)
                                  .Select(s => s)
                                  .Where(st => st.standardID > 0)
                                  .Select(s => s.StudentName);
        }
}

    
}
