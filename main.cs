using System;

class Program {
  public static void Main (string[] args) {
    
    Faculty f1 = new Faculty();
    f1.FirstName = "John";
    f1.LastName = "Smith";
    f1.Id = "12345";
    Console.WriteLine("ID = " +f1.Id);
    f1.DateOfEmployment = Convert.ToDateTime("11/01/2020");
    f1.Employer = "Tri-C";
    f1.GrantTenure();
    f1.Promote();
    f1.Intro();

    Faculty f2 = new Faculty("Rick", "Sanchez");
    f2.Id ="12321";
    f2.DateOfEmployment = Convert.ToDateTime("11/01/2018");
    f2.Employer = "OSU";
    f2.GrantTenure();
    f2.Promote();
    f2.Intro();

    Faculty f3 = new Faculty("Axel", "Roses");
    f3.DateOfEmployment = Convert.ToDateTime("11/01/2013");
    f3.Employer = "CSU";
    f3.GrantTenure();
    f3.Promote();
    f3.Intro();

    Faculty f4 = new Faculty("Robert","De Niro");
    f4.DateOfEmployment = Convert.ToDateTime("11/01/2010");
    f4.Employer = "PSU";
    f4.GrantTenure();
    f4.Promote();
    f4.Intro();
    f4.Promote();


    
  }
}