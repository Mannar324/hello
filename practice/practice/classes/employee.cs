using System;
using System.Collections.Generic;
using System.Text;

namespace practice.classes
{
    class employee
    {
        #region variables
        public int employeeid;
        public string employeename;
        public decimal salary;
        public string departmentname;
        #endregion

        #region Methods


       

        public int Employeeid
        {
            set
            {
                if (value <= 0)
                {
                    employeeid = 1;
                }
                else
                {
                    employeeid =value;
                }

                employeeid = value;
            }
            get
            {
                return employeeid;
            }
        }
        public string Employeename
        {
            get
            {
                return employeename;
            }
            set
            {
                employeename = value;
            }
        }
        #region hashed
        public void setemployeename(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                employeename = "no name";
            }
            else

                employeename = name;

        } 
        #endregion
       
        public bool requestvacation(int days)
        {
            return true;
        }
        public decimal sal { get; set; }
        public string departname { get; set; }
        public void hiremployee(employee employee)
        {
            //hiring process
        }
        #endregion
    }
}
