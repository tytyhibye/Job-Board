using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
using System.Collections.Generic;

namespace JobBoard.Contollers
{
  public class JobsContoller : Controller
  {
    [HttpGet("/jobs")]
    public ActionResult Index()
    {
      return View(Jobs.JobList);
    }

    [HttpGet("/jobs/new")]
    public ActionResult CreatForm()
    {
      return View();
    }

    [HttpPost("/jobs")]
    public ActionResult Create(string title, string description, string pay)
    {
    Jobs newJob = new Jobs(title, description, pay)
    return RedirectToAction("Index");
    }
  }
}
