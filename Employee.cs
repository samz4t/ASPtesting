using System;
using System.Collections.Generic;
using System.Text;

namespace AspTest
{
    class Employee
    {
        public int Id {get; set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
        public List<string > Programming { get; set; }


        public static List<Employee> GetEmployee()
        {
            List<Employee> emps = new List<Employee>()
            {
                new Employee{ Id = 101, FirstName = "Samuel", LastName = "sam", Salary = 6000, Programming= new List<string>{"C#","Java"} },
                new Employee{ Id = 102, FirstName = "Jhon", LastName = "hop", Salary = 7000, Programming= new List<string>{"Java","Python" } },
                new Employee{ Id = 103, FirstName = "Preety", LastName = "Tiwary", Salary = 6000, Programming=new List<string> { "C","HTML" }  },
                new Employee{ Id = 104, FirstName = "nicolas", LastName = "poran", Salary = 9000, Programming=new List<string> { "C++","Ruby" }  },
                new Employee{ Id = 106, FirstName = "Ab", LastName = "Deviliers", Salary = 8000, Programming=new List<string> { "Angular","PHP" }  },


            };
            return emps;
        }
    }
}
