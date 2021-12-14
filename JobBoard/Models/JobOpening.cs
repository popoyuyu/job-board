using System;

namespace JobBoard.Models
{
  public class JobOpening
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public Contact ContactInfo { get; set; }

    public JobOpening(string title, string description, string company, string name, string email, string number)
    {
      Title = title;
      Description = description;
      ContactInfo = new Contact(company, name, email, number);
    }
  }
}