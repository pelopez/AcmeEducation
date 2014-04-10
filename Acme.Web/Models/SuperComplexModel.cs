using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Acme.Web.Models
{
    public class SuperComplexModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return string.Format("{0} {1}", FirstName, LastName); } }
    }
}