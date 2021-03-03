using System;

namespace AntiqueShop
{

    public class Customer
    {
        public string FirstName { get; }

        public string LastName { get; }

        //computed property
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        //fields
        private decimal _minPrice;
        private decimal _maxPrice;

        //Constructor
        public Customer(string firstName, string lastName, decimal minPrice, decimal maxPrice)
        {
            FirstName = firstName;
            LastName = lastName;
            _minPrice = minPrice;
            _maxPrice = maxPrice;
        }

        //Method
        public void PresentItem(AntigueItem item)
        {
            if (item.Price >= _minPrice && item.Price < _maxPrice)
            {
                Console.WriteLine($"Would add {item.Name} to Purchase List");
            }
            else if (item.Price >= _minPrice && item.Price > _maxPrice)
            {
                Console.WriteLine($"Would add {item.Name} to Wish List");
            }
        }

    }

}


//Computed Property: A 'get' only property that doesn't save any data, but uses other properties to compute a value when it is accessed.

//Constructor: A special method in a class that executes when the class is initialized. Runs when a 'new' object is created. Only 'get' properties can be set in the constructor.
//How to spot a constructor: Has the same name as the class, or It does NOT have a 'return' type.

//Properties are uppercase and parameters are lowercase

//Fields are almost always private. !!Does not have a 'get' or a 'set'!!
//Naming convention for fields: begin with an underscore _ 

//Method: A function defined in a class. Is some kind of "action" or "operation". 
