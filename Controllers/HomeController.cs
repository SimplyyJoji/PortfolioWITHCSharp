using Microsoft.AspNetCore.Mvc;

namespace HelloASP
{
  public class HomeController : Controller
  {
    //Requests
    //localhost 5000/
    //short way to set up a route
    [HttpGet("")]
    public string Index()
    {
      return "This is my Index!";
    }

    
    

    [Route("projects")]
    [HttpGet]
    public string Project()
    {
      return "These are my projects";
    }
    //localhost 5000/users/
    [HttpGet("users/{contact}")]
    public string HelloContact(string contact)
  {
    return $"Hello {contact}";
  }

  }
}