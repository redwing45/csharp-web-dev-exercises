using Microsoft.AspNetCore.Mvc;

namespace HelloASPDotNet1
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {

        //GET: /helloworld/
        [HttpGet]
        public IActionResult Index()
        {
            //string html = "<h1>" + "Hello World!" + "</h1>";
            string html = "<form method = 'post' action = '/helloworld/welcome'>" +
                "input type = 'text' name = 'name'/>" +
                "input type = 'submit' value = 'Greet me!' /> " +
                "</form>";
            return Content(html, "text/html");
        }

        //POST:/helloworld/welcome
        [HttpPost("/welcome")]
        [HttpGet("welcome/{name?}")]
        //[Route("/helloworld/welcome/{name}")]
        //[Route("/helloworld/welcome/{name?}")]
         public IActionResult Welcome(string name= "World") 
        {
            return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        }
    }
}
