using System;

namespace JobBoard.Models
{
  public class Contact
  {
    public string CompanyName { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }

    public Contact(string company, string name, string email, string number)
    {
      CompanyName = company;
      Name = name;
      Email = email;
      PhoneNumber = number;
    }
  }
}