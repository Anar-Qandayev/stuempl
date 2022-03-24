using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Person student = new Person("Anar", "Gandayev", 15);
            Person employee = new Person("Ilham", "Veliyev", 22);
         
            Employee e = new Employee();
            e.person = employee;

            Console.WriteLine("Worker: " + e.person.name+" "+ e.person.surname);
            Console.WriteLine(e.CalculateSalary(3, 140,e.person.age));
            Console.WriteLine("----------------------------------");
            Student st = new Student();
            st.person = student;
            Console.WriteLine("Student: " + st.person.name + " " + st.person.surname);

            Console.WriteLine("Your result: " + st.ExamResult(90, 60 , st.person.age));



        }
    }
}
