using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Autenticar;

namespace WSAYD
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://AYD.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {
        
        [WebMethod]
        public bool Exists(string username, string password)
        {
            Autenticar.Autenticar autoriza = new Autenticar.Autenticar();

            return autoriza.Exists(username, password);
        }
    }
}