using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
using System.Collections.Generic;

namespace JobBoard.Controllers
{
  public class JobsController : Controller
  {
    [HttpGet("/jobs")]
    public ActionResult Index()
    {
      return View(Jobs.JobList);
    }

    [HttpGet("/CreateForm")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/jobs")]
    public ActionResult Create(string title, string description, string pay, string phone)
    {
      Jobs newContract = new Jobs(title, description, pay, phone);
      return RedirectToAction("Index");
    }

    [HttpPost("/jobs/delete")]
    public ActionResult DeleteAll()
    {
      Jobs.ClearAll();
      return View();
    }
  }
}