using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD_EmployeeData
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
    }
    
    public class EmployeeCURD
    {
        private List<Employee> employees;

        public EmployeeCURD() 
        { 
            employees = new List<Employee>()
            {
                 new Employee { Id = 1, Name = "Chidanand G",Department = "HR", Salary = 60000, } ,
                 new Employee { Id = 2, Name = "Shubham D", Department = "Finance", Salary = 65000 }
            };        
        }
        //Display list
        public List <Employee> GetEmployees()
        {
            return employees;
        }
        //Get single Employee
        public Employee GetEmployeeById(int id)
        {
            //Sreach for id in the collection
            Employee employee=new Employee();
            foreach(Employee e in employees)
            {
                if(e.Id == id) //match id in the collection
                {
                    employee = e;
                    break;
                }
            }
            return employee;
        }
        //Add new Employee
        public void AddEmpolyee(Employee e)
        {
            employees.Add(e);
        }
        //Modify the Employee
        public void UpdateEmpolyee(Employee e)
        {
            foreach (Employee emp in employees)
            {


                if (emp.Id == e.Id)

                {
                    //item contains 
                    emp.Id = e.Id;
                    emp.Name = e.Name;
                    emp.Department = e.Department;
                    emp.Salary = e.Salary;
                    break;
                }
            }
        }
        //Remove Product
        public void DeleteEmployee(int id)
        {
            foreach(Employee emp in employees)
            {
                if(emp.Id==id)
                {
                    employees.Remove(emp);
                    break;
                }
            }
        }
                

    }
}
