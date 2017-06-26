using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcFinalProjectWCL.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public string Index()
        {
            return "Hello World!";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "Welcome to our MVC Project.";
        }
    }
}

