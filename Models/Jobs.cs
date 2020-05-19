using System.Collections.Generic;

namespace JobBoard.Models
{
  public class Contracts
  {
    public string Title { get: set;}
    public string Description { get; set;}
    public string Phone { get; set;}

    public Jobs (string title, string description, string phone)
    {
      Title = title;
      Description = description;
      Phone = phone;
    }
  }
}