using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    //properties with user defined
    internal class Properties
    {
        private int _Id;
        private string _Name;


        public int Id
        {
            set
            {
                if (value > 0)
                {
                    Console.WriteLine(value);
                }
            }

            get { return this._Id; }

        }

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("please enter correct name");
                }
                else
                {
                    Console.WriteLine(value);
                }
            }

            get { return this._Name; }
        }

    }

    internal class PreDefinedProperties
    {
        public string EmpName { get; private set; }
        public int EmpId { get; private set; }

        public bool EmpExists { get; private set; }
       

        //first method to set private set with constructor
        public PreDefinedProperties(string empName, int empId)
        {
            this.EmpName = empName;
            this.EmpId = empId;

            setEmpExits();
        }

        //seocnd method to set with private set
        public void SetEmpName(string empName)
        {
            if (string.IsNullOrEmpty(empName))
            {
                throw new ArgumentException("Employee name cannot be null or empty.");
            }
            else
            {
                EmpName = empName;
            }
        }

        void setEmpExits()
        {
            EmpExists = true;
        }




    }
}
