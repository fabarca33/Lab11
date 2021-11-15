using System;
class Faculty : Person
{
  public string Id {get; set;}
  public string Title {get; set;}
  public DateTime DateOfEmployment {get; set;}
  public string Employer {get; set;}
  public double YearlySalary {get; set;}
  public bool Tenured {get; set;}

  public Faculty() : base()
  {
    Title = "Instructor";
  }

  public Faculty(string fname, string lname) : base(fname, lname)
  {
    Title = "Instructor";
  }

  public void GrantTenure()
  {
    int YearsOfEmployment = DateTime.Today.Year - DateOfEmployment.Year;

    if(YearsOfEmployment >= 5)
    {
      Tenured = true;
      Console.WriteLine("This is a Tenured instructor");
    } 
    else
    {
      Tenured = false;
    }
  }

  public void Promote()
  {
    int YearsOfEmployment = DateTime.Today.Year - DateOfEmployment.Year;

    if((Title == "Instructor") && (YearsOfEmployment > 2 && YearsOfEmployment < 5))
    {
      Title = "Assistant Professor";

      Console.WriteLine("Faculty promoted to Assistant Professor rank");
    } 
    else if((Title == "Assistant Professor" || Title == "Instructor") && (YearsOfEmployment > 5 && YearsOfEmployment < 10))
    {
      Title = "Associate Professor";

      Console.WriteLine("Faculty promoted to Associate Professor rank");
    }
    else if((Title == "Associate Professor" || Title == "Assistant Professor" || Title == "Instructor") && (YearsOfEmployment > 10))
    {
      Title = "Professor";

      Console.WriteLine("Faculty promoted to Professor rank");
    }
    else if(Title == "Professor")
    {
      Console.WriteLine("No more promotion possible");
    }
    else
    {
     Title = "Instructor";
    }
  }

  public override void Intro()
  {

    base.Intro();
    Console.WriteLine("I work as " +Title +" at " +Employer +" since " +DateOfEmployment.Year);
  }

} 