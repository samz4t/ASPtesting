using AspTest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspTest
{
    class LinQ
    {
        static void Main8(string[] args)
        {
            BetaGrpContex com = new BetaGrpContex();
      
            var query2 = from e in com.EmployeeTbls
                         select e;
            //var method = com.EmployeeTbls

            var query = from g in com.EmployeeTbls
                        group g by g.Gender;

            var method = com.DepartmentTbls.GroupJoin(
                                          com.EmployeeTbls,
                                          dept => dept.ID,
                                          emp => emp.DepartmentId,
                                          (dept, emp) => new
                                          {
                                              dp = dept,
                                              em = emp.OrderBy(x => x.Name)
                                          }
                                          ) ;


            foreach ( var e in method)
            {
                //  Console.WriteLine($"{e.Key }.......{e.Count()}"); //print key
                Console.WriteLine(e.dp.DepartmentName);
                foreach (var i in e.em)
                {
                   Console.WriteLine($"Name: {i.Name} Gender:{i.Gender}  ");//AND PRINT THE VALUE
               }
               
                //Console.WriteLine($"{ e.Key} -- {e.Count()}");// group by
                // Console.Write($"Name: {e.name}  Salary:{e.salary} ");
                //  Console.WriteLine($" Salary : {e.Salary} ");
                //foreach (var a in e.Programming )
                //{
                //    Console.Write(' ' + a);
                //}
                Console.WriteLine();


            }
            
            Console.ReadLine();
           
        }
        public void Select()
        {
            BetaGrpContex com = new BetaGrpContex();

            IEnumerable<Employee> method2 = Employee.GetEmployee().Where(x => x.Salary == 6000);
            IEnumerable<Employee> query2 = from emp in Employee.GetEmployee()
                                           where emp.Salary == 6000
                                           select emp;

            IEnumerable<Employee> method = Employee.GetEmployee().Select(x => x);

            var method3 = Employee.GetEmployee().SelectMany(x => x.Programming, (emp, pro) =>
                                                                         new {
                                                                             name = emp.FirstName,
                                                                             salary = emp.Salary,
                                                                             Prog = pro
                                                                         });

            var methodSyntex = Employee.GetEmployee().
                                  Select(x => new
                                  {
                                      FirstName = x.FirstName,
                                      LastName = x.LastName
                                  });

            var Query2 = (from emp in Employee.GetEmployee()
                          select new             // annonymous type 
                          {
                              FirstName = emp.FirstName,
                              LName = emp.LastName,
                              salary = emp.Salary,
                              bonus = emp.Salary * .2
                          });

            IEnumerable<Employee> Query = (from emp in Employee.GetEmployee()
                                           select new Employee()
                                           {
                                               FirstName = emp.FirstName,
                                               LastName = emp.LastName
                                           });

            foreach (var e in method)
            {
                //Console.WriteLine(Department : {e.Programming});
                // Console.Write($"Name: {e.name}  Salary:{e.salary} ");
                Console.Write($"ID : {e.Id} Name : {e.FirstName} {e.LastName} Salary : {e.Salary} Programming:");
                foreach (var a in e.Programming)
                {
                    Console.Write(' ' + a);
                }
                Console.WriteLine();


            }

            #region GroupBy
            var method4 = com.EmployeeTbls.GroupBy(x => x.Gender);
            var query = from g in com.EmployeeTbls
                        group g by g.Gender;
            foreach (var e in method4)
            {
                Console.WriteLine($"{ e.Key}.......{e.Count()}"); //print key
                foreach (var i in e)
                {
                    Console.WriteLine($"Name: {i.Name} Gender:{i.Gender}  ");//AND PRINT THE VALUE
                }

                
                Console.WriteLine();


            }
            #endregion

        }
    }
    

}
