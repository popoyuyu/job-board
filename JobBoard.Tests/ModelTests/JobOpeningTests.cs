using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using JobBoard.Models;

namespace JobBoard.Tests
{
  [TestClass]
  public class JobBoardTests
  {
    [TestMethod]
    public void GetContact_ReturnsContactInfo_String()
    {
      JobOpening newJob = new JobOpening("Junior Dev", "Junior Dev Job Stuff", "Microsoft", "Jill Doe", "Jill@gmail.com", "(555)555-5555");
      string contactName = newJob.ContactInfo.Name;
      string contactNumber = newJob.ContactInfo.PhoneNumber;
      Assert.AreEqual("Jill Doe", contactName);
      Assert.AreEqual("(555)555-5555", contactNumber);
    }
  }
}