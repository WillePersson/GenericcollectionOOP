using System.IO;

namespace GenericcollectionOOP            //Wille Persson - .Net23 - Labb 8 OOP Generic Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();//obejcts created from Class Employee
            e1.Id = 100;
            e1.Name = "Lars";
            e1.Gender = "Male";
            e1.Salary = 45000;

            Employee e2 = new Employee();
            e2.Id = 101;
            e2.Name = "Lisa";
            e2.Gender = "Female";
            e2.Salary = 39000;

            Employee e3 = new Employee();
            e3.Id = 102;
            e3.Name = "Roger";
            e3.Gender = "Male";
            e3.Salary = 42000;

            Employee e4 = new Employee();
            e4.Id = 103;
            e4.Name = "Ove";
            e4.Gender = "Male";
            e4.Salary = 49000;
            
            Employee e5 = new Employee();
            e5.Id = 104;
            e5.Name = "Marie";
            e5.Gender = "Female";
            e5.Salary = 47000;

            var employeestack = new Stack<Employee>();//creating new stack 

            employeestack.Push(e1);//pushign the object in to stack
            employeestack.Push(e2);
            employeestack.Push(e3);
            employeestack.Push(e4);
            employeestack.Push(e5);

            foreach (var employee in employeestack)//Types out all the objects in stack
            {
                Console.WriteLine($"{employee.Id} - {employee.Name} - {employee.Gender} - {employee.Salary}");
                Console.WriteLine("Objects left in Stack: {0}", employeestack.Count);
            }
            Console.WriteLine("-------------------------------");

            Console.WriteLine("Using the pop method");
           
            while (employeestack.Count > 0)//while the stack of the count is bigger than 0 it will keep typing them out
            {
                Employee emp = employeestack.Pop();//types out and removes the object from stack
                Console.WriteLine($"{emp.Id} - {emp.Name} - {emp.Gender} - {emp.Salary}");
                Console.WriteLine("objects left in Stack: {0}", employeestack.Count);
            }

            employeestack.Push(e1);
            employeestack.Push(e2);
            employeestack.Push(e3);
            employeestack.Push(e4);
            employeestack.Push(e5);

            Console.WriteLine("-------------------------------");

            Console.WriteLine("Using the peek method");

            Employee emps = employeestack.Peek();//peeks to get the first object in the stack 2 times
            Console.WriteLine($"{emps.Id} - {emps.Name} - {emps.Gender} - {emps.Salary}");
            Console.WriteLine("objects left in Stack: {0}", employeestack.Count);
            Console.WriteLine($"{emps.Id} - {emps.Name} - {emps.Gender} - {emps.Salary}");
            Console.WriteLine("objects left in Stack: {0}", employeestack.Count);

            Console.WriteLine("-------------------------------");

            if (employeestack.Contains(e3))//Checks if object 3 is still in the stack
            {
                Console.WriteLine("employee 3 is in stack");
            }
            else
            Console.WriteLine("employee 3 is not in stack");

            Console.WriteLine("-------------------------------");
            
            var employeeList = new List<Employee>();//creating new list

            employeeList.Add(e1);//Adding the objects to the list
            employeeList.Add(e2);
            employeeList.Add(e3);
            employeeList.Add(e4);
            employeeList.Add(e5);

            if (employeeList.Contains(e2))//Checks if 2 object in list is there and types out if it is or not
            {
                Console.WriteLine("Employee2 object exists in the list");
            }
            else
                Console.WriteLine("Employee2 object does not exist in the list");

            Console.WriteLine();

            Employee foundItem = employeeList.Find(x => x.Gender == "Male");//find the first object with Gender Male
            Console.WriteLine($"Id = {foundItem.Id},  Name = {foundItem.Name},  Gender = {foundItem.Gender},  Salary = {foundItem.Salary}");

            Console.WriteLine();

            List<Employee> malesFound = employeeList.FindAll(x => x.Gender == "Male");//Find all obejct with Gender Male
            foreach(var maleFound in malesFound)//Types out all OBjects with gender Male
                Console.WriteLine($"Id = {maleFound.Id},  Name = {maleFound.Name},  Gender = {maleFound.Gender},  Salary = {maleFound.Salary}");
        }
    }
    public class Employee //base class
    {   //Fields
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
    }
}