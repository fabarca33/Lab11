  using System;
  
  class Person
  {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual DateTime DateOfBirth { get; set; }
        public string SocialSecurity { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        
        

        public Person() 
        {
          
          Console.WriteLine("Person constructor");
        }

        public Person(string fname, string lname) 
        {
          FirstName = fname;
          LastName = lname;
          Console.WriteLine("Person constructor");
        }

        public virtual void Intro()
        {
            Console.WriteLine("Hello my name is "+ FirstName +" "+ LastName);
            
        }
      
    }