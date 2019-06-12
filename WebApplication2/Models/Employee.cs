using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Employee
    {
        public string EMPID { get; set; }
        public string EMPNAME { get; set; }
        public string EMPADDRESS { get; set; }
        public int EMPTELEPHONE { get; set; }
        public DateTime EMPDOB { get; set; }
    }
}