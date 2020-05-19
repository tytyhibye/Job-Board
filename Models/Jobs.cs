using System.Collections.Generic;

namespace JobBoard.Models
{
  public class Jobs
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public string Phone { get; set; }
    public string Pay { get; set; }

    public Jobs (string title, string description, string phone, string pay)
    {
      Title = title;
      Description = description;
      Phone = phone;
      Pay = pay;
    }
  }
}