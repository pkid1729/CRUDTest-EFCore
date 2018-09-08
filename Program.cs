using System;
using System.Collections.Generic;
using System.Linq;

namespace CRUD_Test
{
    class Program
    {
        private static StudentContext _context = new StudentContext();

        public static IEnumerable<object> Students { get;  set; }

        static void Main(string[] args)
        {
          //   CreateStudents();
             ReadStudents();
            // UpdateStudent();
          //  DeleteStudent();
        }

        private static void DeleteStudent()
        {
           var student =_context.Students.FirstOrDefault(s => s.Name == "Krishnan");
            _context.Students.Remove(student);
            _context.SaveChanges();
        }

        private static void UpdateStudent()
        {
            var student = _context.Students.FirstOrDefault();
            student.Name = "Krishnan";
            _context.SaveChanges();
        }

        private static void ReadStudents()
        {
            //  var students = _context.Students.ToList();
            // var students = _context.Students.OrderBy(x => x.Name).Select(x => x.Name);//.ToList();
            // var s = students.ToList();
            // var students=_context.Students.Where(q => q.Name.Contains("Pranav")).Select(x=>x.Name);
            var students = _context.Students.OrderBy(x => x.Roll_No).Where(q => q.Roll_No.Contains("002")).Select(x => x.Name);
            var s = students.ToList();
            MemoryReader mr = new MemoryStream();


            // foreach (var student in students)
            // {
            //     Console.WriteLine(student);
            //     Console.ReadLine();
            // }
            
        }

        private static void CreateStudents()
        {
            var student = new Student { Name = "Pranav", Roll_No = "001" };
            // var student = new Student { Name = "Mukesh", Roll_No = "002" };
            var student3 = new Student { Name = "Aadhar", Roll_No = "003" };
            var student4 = new Student { Name = "Ankit", Roll_No = "004" };
            var student5 = new Student { Name = "Arpit", Roll_No = "005" };
            var student6 = new Student { Name = "Alokit", Roll_No = "006" };
            var student7 = new Student { Name = "Parth", Roll_No = "007" };
            var student8 = new Student { Name = "Kshitij", Roll_No = "008" };
            var student9 = new Student { Name = "Subham", Roll_No = "009" };

            _context.Students.Add(student);
           _context.Students.Add(student3);
            _context.Students.Add(student4);
            _context.Students.Add(student5);
            _context.Students.Add(student6);
            _context.Students.Add(student7);
            _context.Students.Add(student8);
            _context.Students.Add(student9);

            _context.SaveChanges();
           // _context.SaveChanges();




        }
    }
}
