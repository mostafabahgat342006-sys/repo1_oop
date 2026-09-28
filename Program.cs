namespace c__ass1_oop;

internal class Program
{
    static void Main(string[] args)
    {



        /*
         Q1 (a):
        
           when struct is copied ; modyfying in the copied variable
           does not affect the original variable because -> we have 2 copy 
         
        -----------------------------------------------------------------------
       
         Q1 (b):
          
           When class variable is copied both variables reference the same object. 
           Therefore, modifying in the object 
           affects on the other object .
         
        */

        /*
         Q2 (a):

           1- because the word " public " mean that anyone outside shipment 
              can change the value direct

           2- no validation because prevent negative weight

           3- no control in  changes 

          ---------------------------------------------------------------------

        Q2 (b): 

          this will ensure that no onr outside shipment can directle 
          change thw weight 
         
        */




        DeliveryAddress address1 =
            new DeliveryAddress("Cairo", "Tahrir Street", 15);

        DeliveryAddress address2 = address1;

        // before the modyfying
        Console.WriteLine("Address 1: " + address1.GetFullAddress());
        Console.WriteLine("Address 2: " + address2.GetFullAddress());
        Console.WriteLine("-----------------------------------------");
        address2.City = "Giza";
        address2.Street = "Makram Ebeid Street";
        address2.BuildingNumber = 20;

        // after the modyfying
        Console.WriteLine("Address 1: " + address1.GetFullAddress());
        Console.WriteLine("Address 2: " + address2.GetFullAddress());
















    }
}
