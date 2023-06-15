using ChatApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatApi.Model
{
    public partial class ResponceEmployee
    {
        public ResponceEmployee(Employee employee)
        {
            id = employee.id;
            FullName = employee.FullName;
            username = employee.username;
            password = employee.password;
        }

        public int id { get; set; }
        public string FullName { get; set; }
        public string username { get; set; }
        public string password { get; set; }
  
    }
}