using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.DTO
{
    public class Employee_DTO
    {
        public string EMPID { get; set; }
        public string EMPNAME { get; set; }
        public string EMPADDRESS { get; set; }
        public int EMPTELEPHONE { get; set; }
        public DateTime EMPDOB { get; set; }
    }
}