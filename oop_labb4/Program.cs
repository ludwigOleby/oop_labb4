using System;
using System.Collections.Generic;

namespace oop_labb4
{
    class Program
    {
        static void Main(string[] args)
        {
            employee e1 = new employee(); e1.id = 101; e1.name = "Ludwig"; e1.gender = "male"; e1.salary = 20000;
            employee e2 = new employee(); e2.id = 101; e2.name = "Anna"; e2.gender = "female"; e2.salary = 22000;
            employee e3 = new employee(); e3.id = 101; e3.name = "Anas"; e3.gender = "male"; e3.salary = 40000;
            employee e4 = new employee(); e4.id = 101; e4.name = "Tobias"; e4.gender = "male"; e4.salary = 40000;
            employee e5 = new employee(); e5.id = 101; e5.name = "Sara"; e5.gender = "female"; e5.salary = 25000;

            Stack<employee> empStack = new Stack<employee>();
            empStack.Push(e1);
            empStack.Push(e2);
            empStack.Push(e3);
            empStack.Push(e4);
            empStack.Push(e5);

            foreach (employee x in empStack)
            {
                Console.WriteLine("ID = {0} \nName = {1} \nGender = {2} \nSalary = {3}",x.id ,x.name ,x.gender ,x.salary);
                Console.WriteLine("Items left in stack: " + empStack.Count);
                Console.WriteLine("----------");
            }

            Console.WriteLine("Retrieve using Pop Method");

            while (empStack.Count > 0)
            {
                employee employeeFromStack = empStack.Pop();
                Console.WriteLine("ID = {0} \nName = {1} \nGender = {2} \nSalary = {3}", employeeFromStack.id, employeeFromStack.name, employeeFromStack.gender, employeeFromStack.salary);
                Console.WriteLine("Items left in stack: " + empStack.Count);
                Console.WriteLine("----------");
            }

            empStack.Push(e1);
            empStack.Push(e2);
            empStack.Push(e3);
            empStack.Push(e4);
            empStack.Push(e5);

            Console.WriteLine("Retrieve using Peek method");

                employee peekEmp = empStack.Peek();
                Console.WriteLine("ID = {0} \nName = {1} \nGender = {2} \nSalary = {3}", peekEmp.id, peekEmp.name, peekEmp.gender, peekEmp.salary);
                Console.WriteLine("Items left in stack: " + empStack.Count);
                Console.WriteLine("----------");

            if (empStack.Contains(e3))
            {
                Console.WriteLine("Employee 3 is in stack");
            }
            else
            {
                Console.WriteLine("Employee 3 is not in stack");
            }

            Console.WriteLine("*************\n LIST:");

            List < employee > empList = new List<employee>();
            empList.Add(e1);
            empList.Add(e2);
            empList.Add(e3);
            empList.Add(e4);
            empList.Add(e5);

            if (empList.Contains(e2))
            {
                Console.WriteLine("Employee 2 exists in the list");
            }
            else
            {
                Console.WriteLine("Employee 2 does not exist in the list");
            }

            employee result = empList.Find(x => x.gender == "male");
            Console.WriteLine("ID = {0} \nName = {1} \nGender = {2} \nSalary = {3}", result.id, result.name, result.gender, result.salary);

            List<employee> allResult = empList.FindAll(y => y.gender == "male");
            foreach (employee item in allResult)
            {
                Console.WriteLine("ID = {0} \nName = {1} \nGender = {2} \nSalary = {3}", item.id, item.name, item.gender, item.salary);
            }
            
            
            




            Console.ReadKey();

        }
    }
}
