﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroGenerics
{
    public class ExploreGenericColl
    {
        public static void Start()
        {
            // Create a new empty List for Employee objects 
            List<Employee> empList = new List<Employee>();

            #region Initialize Data

            // Add some records to the list
            empList.Add(new Employee("John Doe", 50000));
            empList.Add(new Employee("Jane Smith", 60000));
            empList.Add(new Employee("Nick Slick", 55000));
            empList.Add(new Employee("Mildred Mintz", 70000));

            // Inspect some List properties
            Console.WriteLine("empList Capacity is: {0}", empList.Capacity);
            Console.WriteLine("empList Count is: {0}", empList.Count);

            #endregion

            // Use Exists() and Find()
            // List will call delegate for all of list items/ which meets some condition.
            if (empList.Exists(HighPay))
            {
                Console.WriteLine("\nHighly Paid Employee Found!\n");
            }

            Employee e = empList.Find(x => x.mName.StartsWith("J"));
            if (e != null)
            {
                Console.WriteLine("Found employee whose name starts with J: {0}", e.mName);
            }

            // Use ForEach to iterate over each item
            empList.ForEach(TotalSalaries);
            Console.WriteLine("Total payroll is: {0}\n", total);

        }

        // delegate function to use for the Exists method
        static Boolean HighPay(Employee emp)
        {
            return emp.mSalary >= 65000;
        }

        // Iterator function for the ForEach method
        static int total = 0;
        static void TotalSalaries(Employee e)
        {
            total += e.mSalary;
        }

    }

    class Employee
    {
        public string mName;
        public int mSalary;

        public Employee(string name, int salary)
        {
            mName = name;
            mSalary = salary;
        }
    }
}
