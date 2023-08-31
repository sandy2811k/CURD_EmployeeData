using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD_EmployeeData
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int no = 0;
            EmployeeCURD curd= new EmployeeCURD();
            do
            {   Console.WriteLine("-------------------------");
                Console.WriteLine("1. Employee List: ");
                Console.WriteLine("2. Get Employee by there Id: ");
                Console.WriteLine("3. Add Employee Details:");
                Console.WriteLine("4. Update Employee Data:");
                Console.WriteLine("5. Delete Empolyee Data:");
                Console.WriteLine("Select Your Option :");

                int option =Convert .ToInt32(Console.ReadLine());

                switch(option)
                {
                    case 1: //
                        List<Employee> list=curd.GetEmployees();
                        Console.WriteLine("Id\t Name\t Department\t Salary\t ");
                        foreach(Employee emp in list)
                        {
                            Console.WriteLine($"{emp.Id}\t {emp.Name}\t {emp.Department}\t {emp.Salary}");
                        }
                        break;

                    case 2: // 
                        Console.WriteLine("Enter the Employee Id:");
                        int id=Convert .ToInt32(Console.ReadLine());
                        Employee e=curd.GetEmployeeById(id);
                        Console.WriteLine("Id\tName\tDepartment\tSalary\t ");
                        Console.WriteLine($"{e.Id}  {e.Name}     {e.Department}   {e.Salary}");
                        break;

                     case 3:
                        Employee e1 = new Employee();
                        Console.WriteLine("Enter Employee Id:");
                        e1.Id = Convert .ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Employee Name:");
                        e1.Name = Console.ReadLine();
                        Console.WriteLine("Enter department");
                        e1.Department = Console.ReadLine();
                        Console.WriteLine("Enter Employee Salary:");
                        e1.Salary=Convert.ToInt32(Console.ReadLine());
                        curd.AddEmpolyee(e1);
                        Console.WriteLine("Employee data saved..");
                        break; 
                    
                    
                      case 4:
                        Employee e2 = new Employee();
                        Console.WriteLine("Enter Empolyee Id:");
                        e2.Id=Convert .ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Employee Name:");
                        e2.Name = Console.ReadLine();
                        Console.WriteLine("Enter department");
                        e2.Department = Console.ReadLine();
                        Console.WriteLine("Enter Employee Salary:");
                        e2.Salary = Convert.ToInt32(Console.ReadLine());
                        curd.AddEmpolyee(e2);
                        Console.WriteLine("Employee data updated..");
                        break;
                      case 5:
                        Console.WriteLine("Enter the Employee id");
                        int id2= Convert .ToInt32(Console.ReadLine());
                        curd.DeleteEmployee(id2);
                        Console.WriteLine($"{id2}Employee Data deleted");

                        break;
                }
                Console.WriteLine("Press 1 for Continue...");
                no =Convert .ToInt32(Console.ReadLine());
            
            }
            while (no ==1);
        }
    }
}
