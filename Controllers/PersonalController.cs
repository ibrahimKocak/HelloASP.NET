using HelloASP.NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloASP.NET.Controllers
{
    public class PersonalController : ApiController
    {
        private List<Personal> personals = new List<Personal>
        {
            new Personal{ Id=1, Name="İbrahim", Surname="Koçak"},
            new Personal{ Id=2, Name="Ahmet", Surname="Koçak"},
            new Personal{ Id=3, Name="Mehmet", Surname="Koçak"}
        };

        public IEnumerable<Personal> GetPersonals()
        {
            return personals;
        }
    }
}
