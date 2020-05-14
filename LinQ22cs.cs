using AspTest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspTest
{
    class LinQ22cs
    {
       static BetaGrpContex com = new BetaGrpContex();
        static void Main(string[] args)
        {
            var method1 = com.EmployeeTbls;
            var method2 = com.DepartmentTbls;

            Console.Write("Enter ID::");
            var input = int.Parse(Console.ReadLine());

            #region Details API
            //Details of Employee By ID


            // var method = com.EmployeeTbls.Where(x => x.ID == input).FirstOrDefault() ;

            //Console.WriteLine(method.ID+"  " + method.Name +" "+ method.Gender);
            // Console.ReadLine();
            #endregion

            #region Report
            var join = com.DepartmentTbls.Join(
                                         com.EmployeeTbls,
                                         dept => dept.ID,
                                         emp => emp.DepartmentId,
                                         (dept, emp) => new
                                         {
                                             dp = dept,
                                             em = emp,
                                         });

            var Result = com.EmployeeTbls.Where(x => x.DepartmentId == input);
            var Total = new
                           {
                            sum = Result.Sum(x => x.Salary),
                            count = Result.Count(),

                            };               
                                   
          //foreach (var i in join)
          //{
          //    Console.WriteLine("total " + i.a);
          //}
            Console.WriteLine($" Total Salary {input} is: {Total.sum}\n Total Employee of {input} is: {Total.count}");
            Console.ReadLine();

            #endregion

        }

    }
}
