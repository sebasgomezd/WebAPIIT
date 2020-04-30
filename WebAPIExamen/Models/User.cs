using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIExamen.Models
{
    public class User
    {
        public string usuario { get; set; }
        public string  password { get; set; }
       
        public override string ToString()
        {
            return string.Format("Usuario: {0}",usuario);
        }
    }
}