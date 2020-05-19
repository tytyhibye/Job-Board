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
      return View(); //Contracts.ContractList
    }

    [HttpGet("/jobs/new")]
    public ActionResult CreatForm()
    {
      return View();
    }

    [HttpPost("/jobs")]
    public ActionResult Create(string title, string description, string pay, string phone)
    {
    Jobs newContract = new Jobs(title, description, pay, phone);
    return RedirectToAction("Index");
    }
  }
}
