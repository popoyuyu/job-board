using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
using System;

namespace JobBoard.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/JobPosting")]
    public ActionResult JobPosting(string title, string description, string company, string name, string email, string number)
    {
      JobOpening newJob = new JobOpening(title, description, company, name, email, number);
      return View(newJob);
    }
  }
}