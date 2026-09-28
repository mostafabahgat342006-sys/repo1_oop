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




        DeliveryAddress address01 =
            new DeliveryAddress("Cairo", "Tahrir Street", 15);

        DeliveryAddress address02 = address01;

        // before the modyfying
        Console.WriteLine("Address 1: " + address01.GetFullAddress());
        Console.WriteLine("Address 2: " + address02.GetFullAddress());
        Console.WriteLine("-----------------------------------------");
        address02.City = "Giza";
        address02.Street = "Makram Ebeid Street";
        address02.BuildingNumber = 20;

        // after the modyfying
        Console.WriteLine("Address 1: " + address01.GetFullAddress());
        Console.WriteLine("Address 2: " + address02.GetFullAddress());



        Console.WriteLine("--------------------------------------------------------------");


        DeliveryCenter center = new DeliveryCenter();

        // Read 3 shipments
        for (int i = 0 ; i < 3 ; i++)
        {
            Console.WriteLine("# Enter Shipment " + (i + 1));

            Console.Write("Tracking Code: ");
            string trackingCode = Console.ReadLine();

            Console.Write("Description: ");
            string description = Console.ReadLine();

            Console.Write("Weight: ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal deliveryFee = decimal.Parse(Console.ReadLine());

            Console.Write("City: ");
            string city = Console.ReadLine();

            Console.Write("Street: ");
            string street = Console.ReadLine();

            Console.Write("Building Number: ");
            int buildingNumber = int.Parse(Console.ReadLine());


            DeliveryAddress address =
                new DeliveryAddress(city, street, buildingNumber);

            Shipment shipment =
                new Shipment(
                    trackingCode,
                    description,
                    weight,
                    deliveryFee,
                    address
                );



            if (center.AddShipment(shipment))
            {
                Console.WriteLine("Shipment added successfully.");
            }
            else
            {
                Console.WriteLine("Shipment not added.");
            }

            Console.WriteLine();
        }

        // Print all shipments 
        Console.WriteLine("--- Shipments ---");

        for (int i = 0; i < 3; i++)
        {
            center[i].PrintShipment();
            Console.WriteLine();
        }

        // Search by tracking code
        Console.Write("Enter a tracking code to search: ");
        string searchCode = Console.ReadLine();

        Shipment found_Shipment = center[searchCode];

        if (!string.IsNullOrEmpty(found_Shipment.TrackingCode))
        {
            Console.WriteLine(
                "Shipment found: " + found_Shipment.TrackingCode + " - " + found_Shipment.Description
            );
        }
        else
        {
            Console.WriteLine("Shipment not found.");
        }

        // Demonstrate DeliveryAddress struct copy
        Console.WriteLine();
        Console.WriteLine("--- Struct Copy ---");

        DeliveryAddress address1 =
            new DeliveryAddress("Cairo", "Tahrir Street", 15);

        DeliveryAddress address2 = address1;

        address2.City = "Cairo";
        address2.Street = "Makram Ebeid Street";
        address2.BuildingNumber = 20;

        Console.WriteLine("Original Address: " + address1.GetFullAddress());

        Console.WriteLine("Copied Address: " + address2.GetFullAddress() );















    }
}
