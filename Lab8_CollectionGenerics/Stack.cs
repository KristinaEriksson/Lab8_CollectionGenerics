using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_CollectionGenerics
{
    class Stack
    {
        // Object with initialized properties
        Employee E1 = new Employee() { EmpId = 1, Name = "Ulrik", Gender = 'M', Salary = 34000 };
        Employee E2 = new Employee() { EmpId = 2, Name = "Kristina", Gender = 'F', Salary = 30000 };
        Employee E3 = new Employee() { EmpId = 3, Name = "Alexander", Gender = 'M', Salary = 24000 };
        Employee E4 = new Employee() { EmpId = 4, Name = "Malin", Gender = 'F', Salary = 14000 };
        Employee E5 = new Employee() { EmpId = 5, Name = "Jonathan", Gender = 'M', Salary = 7000 };

        // Create a stack to store elements in
        Stack<Employee> stackEmployee = new Stack<Employee>();


        public void MyStack()
        {
            // Clear the console
            Console.Clear();
            // Empties the stack
            Clear();
            // Adds the objects to the stack
            Push();
            Console.WriteLine("Retrieve Using Push Method");

            // Output the objects in the stack
            foreach (Employee item in stackEmployee)
            {
                Console.WriteLine(item.EmpId + " " + item.Name + " " + item.Gender + " " + item.Salary);
                Console.WriteLine("Items left in the stack = {0} ", stackEmployee.Count);
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine("Retrieve Using Pop Method");

            // Loop that remove one object from the top of the stack until the stack is empty
            for (int i = 5; i > 0; i--)
            {
                Employee employeePop = stackEmployee.Pop();
                Console.WriteLine(employeePop.EmpId + " " + employeePop.Name + " " + employeePop.Gender + " " + employeePop.Salary);
                Console.WriteLine("items left in the stack = " + stackEmployee.Count);
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine("Retrieve Using Peek Method");
            // Adds the objects to the stack once more
            Push();

            // Loop that output the element at the top of the stack twice
            for (int i = 0; i < 2; i++)
            {
                Employee employeePeek = stackEmployee.Peek();
                Console.WriteLine(employeePeek.EmpId + " " + employeePeek.Name + " " + employeePeek.Gender + " " + employeePeek.Salary);
                Console.WriteLine("items left in the stack = " + stackEmployee.Count);
            }

            Console.WriteLine("----------------------------");

            // Check if object 3 is in the stack
            if (stackEmployee.Contains(E3))
            {
                Console.WriteLine("E3 is in Stack.");
            }
            else
            {
                Console.WriteLine("Object 3 is not in stack.");
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine("\nBack to menu, press enter key.");
            Console.ReadLine();
        }

        // Method that adds the objects to the stack
        public void Push()
        {
            stackEmployee.Push(E1);
            stackEmployee.Push(E2);
            stackEmployee.Push(E3);
            stackEmployee.Push(E4);
            stackEmployee.Push(E5);
        }
         // Empties the stack
        public void Clear()
        {
            stackEmployee.Clear();
        }
    }
    
}
