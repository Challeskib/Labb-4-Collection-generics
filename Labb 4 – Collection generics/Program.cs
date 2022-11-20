using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Labb_4___Collection_generics
{
    class Program
    {
        public void GetCount()
        {

            //Console.WriteLine($"Items left in stack = {EmpStack.Count}");
        }

        static void Main(string[] args)
        {

            //Skapar nya objekt
            Employee emp1 = new Employee(01, "Anna", "f", 30000);
            Employee emp2 = new Employee(02, "Bengt", "m", 35000);
            Employee emp3 = new Employee(03, "Charlie", "m", 40000);
            Employee emp4 = new Employee(04, "Denice", "f", 45000);
            Employee emp5 = new Employee(05, "Ellen", "f", 50000);

            //Skapa stack och pusha in objekten
            Stack<Employee> empStack = new Stack<Employee>();
            empStack.Push(emp1);
            empStack.Push(emp2);
            empStack.Push(emp3);
            empStack.Push(emp4);
            empStack.Push(emp5);


            //Lopa genom hela stacken och print
            Console.WriteLine();
            foreach (Employee item in empStack)
            {
                Console.WriteLine(item);
                Console.WriteLine($"Items left in stack = {empStack.Count}");
            }

            Console.WriteLine();
            Console.WriteLine("Retrieve using pop method: ");

            //Retrieve using pop method

            while (empStack.Count > 0)
            {
                Console.WriteLine(empStack.Pop());
                Console.WriteLine($"Items left in stack = {empStack.Count}");
            }

            //Pushing the objects again
            empStack.Push(emp1);
            empStack.Push(emp2);
            empStack.Push(emp3);
            empStack.Push(emp4);
            empStack.Push(emp5);

            //Retrieve using peek method
            Console.WriteLine();
            Console.WriteLine("Retrieve using peek method");
            Console.WriteLine(empStack.Peek());
            Console.WriteLine($"Items left in stack = {empStack.Count}");
            Console.WriteLine(empStack.Peek());
            Console.WriteLine($"Items left in stack = {empStack.Count}");

            //Villkor för om emp3 finns i stacken
            if (empStack.Contains(emp3))
            {
                Console.WriteLine("Emp 3 is in the stack");
            }

            Console.WriteLine();
            Console.WriteLine("Del 2, List");
            Console.WriteLine();

            //Create list
            List<Employee> empList = new List<Employee>();
            empList.Add(emp1);
            empList.Add(emp2);
            empList.Add(emp3);
            empList.Add(emp4);
            empList.Add(emp5);

            //Villkor för att kolla om item 2 finns i listan
            if (empList.Contains(emp2))
            {
                Console.WriteLine("Employee 2 exists in the list");
            }
            else
            {
                Console.WriteLine("Employee 2 does not exist in the list");
            }


            Console.WriteLine();
            Console.WriteLine("Finds the first element in the list containing Gender = Male");
            Console.WriteLine(empList.Find(x => x.Gender.Contains("m")));

            Console.WriteLine();
            Console.WriteLine("Finds all objects that are male");

            List<Employee> maleEmployees = empList.FindAll(x => x.Gender.Contains("m"));

            foreach (Employee item in maleEmployees)
            {
                Console.WriteLine(item);
            }
            

        }
    }
}
