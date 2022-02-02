using System;
using System.Collections.Generic;

namespace addressBook
{
    public class Contact
    {
        //----Build a constructor for contact
        //In this case it needs address as a parameter
        //Constructor will hacve the same name as the class
        //Usually one constructor per class
        //Sets initial property. Will need method to change property if needed later.
        // public Contact(string name) {
            

        // }

        //----Define properties of the class
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Email {get; set;}
        public string Address {get; set;}

        //------Define public methods (public void)
        //These let us set the properties but not see them
        public string FullName {
        get
            {
              return $"{FirstName} {LastName}";
            }
        }
    }
}