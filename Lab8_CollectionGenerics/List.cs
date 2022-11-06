using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_CollectionGenerics
{
    class List
    {
        // Objects with initialized properties
        Employee E1 = new Employee() { EmpId = 1, Name = "Ulrik", Gender = 'M', Salary = 34000 };
        Employee E2 = new Employee() { EmpId = 2, Name = "Kristina", Gender = 'F', Salary = 30000 };
        Employee E3 = new Employee() { EmpId = 3, Name = "Alexander", Gender = 'M', Salary = 24000 };
        Employee E4 = new Employee() { EmpId = 4, Name = "Malin", Gender = 'F', Salary = 14000 };
        Employee E5 = new Employee() { EmpId = 5, Name = "Jonathan", Gender = 'M', Salary = 7000 };

        // Create a list to store elements in
        List<Employee> listEmployee = new List<Employee>();

        public void MyList()
        {
            // Clear the console
            Console.Clear();

            // Empties the list
            Clear();

            // Add the Employee objects to the list
            Add();

            // Check if object 2 exist in the list
            if (listEmployee.Contains(E2))
            {
                Console.WriteLine("Employee 2 (E2) object exist in the list.");
            }
            else
            {
                Console.WriteLine("Employee 2 (E2) does not exist in the list.");
            }

            Console.WriteLine("-----------------------------------------------------");
            

            // Output the first male in the list
            Employee firstMale = listEmployee.Find(e => e.Gender == 'M');
            Console.WriteLine("First male on the list:\n");
            Console.WriteLine($"ID = {firstMale.EmpId}, Name = {firstMale.Name}, Gender = {firstMale.Gender}, Salary = {firstMale.Salary}");
            Console.WriteLine("-----------------------------------------------------");
            

            // A list that store all the male employees
            List<Employee> allMaleEmployees = listEmployee.FindAll(e => e.Gender == 'M');
            Console.WriteLine("All males on the list:\n");
            
            // Outout all the male employees
            foreach (var employee in allMaleEmployees)
            {
                Console.WriteLine($"ID = {employee.EmpId}, Name = {employee.Name}, Gender = {employee.Gender}, Salary = {employee.Salary}");
            }
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("\nBack to menu, press enter key.");
            Console.ReadLine();
        }

        // Method that adds the objects into the list
        public void Add()
        {
            listEmployee.Add(E1);
            listEmployee.Add(E2);
            listEmployee.Add(E3);
            listEmployee.Add(E4);
            listEmployee.Add(E5);
        }

        // Method that empties the list
        public void Clear()
        {
            listEmployee.Clear();
        }
    }
}
