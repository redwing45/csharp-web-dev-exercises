using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;

namespace HelloASPDotNET.Controllers
{
    public class HelloController
    {
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post'>" +
                "<input type='text' name='name' />" +
                "<select name='language'><option value='english' selected>English</option>" +
                "<option value='spanish'>Spanish</spanish>" +
                "<option value='vietnamese'>Vietnamese</option>" +
                "<option value='french'>French</option></select>" +
                "<input type='submit' value='Greet Me!'/>" +
                "</form>";

            return Content(html, "text/html");

        }
        public static CreateMessage(string name, string language)
        {
            string hello = "";
            if (language = "French")
            {
                else if(language = Spanish)
                {

                }else
                {
                    heloo = "Hello";
                }
            }
            return hello + name;
        }
    }
}
