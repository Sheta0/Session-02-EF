using Demo_02.Contexts;
using Demo_02.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Demo_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Revision
            // EF Core: ORM in .NET

            // 1. Mapping 
            //    Core First (Generate Table Per Class)
            //    DB First (Generate Class Per Table)

            // 2. L2E (C# Code (LINQ) => EF Core => SQL)

            // Ways to generate :-
            // 1. TPC (Table Per Class)
            // 2. TPH (Table Per Hierarchy)
            // 3. TPCC (Table Per Concrete Class) 
            #endregion

            #region DB Connection 
            //// CRUD Operations
            //// Create - Read - Update - Delete

            ////EFDemo02DbContext context = new EFDemo02DbContext();

            ////try
            ////{
            ////    // Code
            ////}
            ////finally
            ////{
            ////    context.Dispose();
            ////}

            ////using(EFDemo02DbContext context = new EFDemo02DbContext())
            ////{
            ////    // CRUD Operations
            ////}

            //using EFDemo02DbContext context = new EFDemo02DbContext();  
            #endregion

            using EFDemo02DbContext context = new EFDemo02DbContext();

            #region Create - Insert
            //// Create - Insert

            //var employee = new Employee()
            //{
            //    Name = "Rosee",
            //    Age = 24,
            //    Salary = 8_000,
            //    Address = "Alex",
            //};


            ////Console.WriteLine(context.Entry(employee).State); // Deatatched

            //////context.Employees.Add(employee);
            ////context.Add(employee);

            ////Console.WriteLine(context.Entry(employee).State); // Added

            ////var result = context.SaveChanges();

            ////Console.WriteLine(context.Entry(employee).State); // Unchanged

            ////employee.Name = "Haerin";

            ////Console.WriteLine(context.Entry(employee).State);
            ////Console.WriteLine(result);

            //Console.WriteLine(context.Entry(employee).State); // Deatatched

            //context.Entry(employee).State = EntityState.Added;

            //Console.WriteLine(context.Entry(employee).State); // Added

            //context.SaveChanges(); 
            #endregion

            #region Read - Select
            // /*
            // Select *
            // from Employees
            // where Id = 10
            // */

            ////var result = context.Employees.Where(E => E.Id == 10).FirstOrDefault();
            //var result = context.Employees.FirstOrDefault(E => E.Id == 10);

            ////Console.WriteLine(result);

            //var result = context.Employees.Select(E => E.Name);

            //Console.WriteLine(context.Entry(result).State); // unchanged

            //result.Name = "Haerin";

            //Console.WriteLine(context.Entry(result).State); // modified



            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Update
            //// Update 

            //var result = context.Employees.FirstOrDefault(E => E.Id == 10);

            //Console.WriteLine(context.Entry(result).State); // Unchanged

            //result.Age = 19;

            //Console.WriteLine(context.Entry(result).State); // Modified

            //context.SaveChanges();

            //Console.WriteLine(context.Entry(result).State); // Unchanged 
            #endregion

            #region Delete
            //// Delete

            //var result = context.Employees.SingleOrDefault(E => E.Id == 20);

            //Console.WriteLine(context.Entry(result).State); // Unchanged


            //context.Employees.Remove(result);

            //Console.WriteLine(context.Entry(result).State); // Deleted

            //context.SaveChanges();

            //Console.WriteLine(context.Entry(result).State); // Deatached 
            #endregion



        }
    }
}
