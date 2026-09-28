namespace c__ass1_oop;

public struct Shipment
{

    private string trackingCode;
    private string description;
    private double weight;
    private decimal deliveryFee;


    public string TrackingCode
    {
        get
        {
            return trackingCode;
        }

        private set
        {
            if (!string.IsNullOrWhiteSpace(value)) // cannot be null, empty, or whitespace.
            {
                trackingCode = value;
            }
        }
    }

    public string Description
    {
        get
        {
            return description;
        }

        set
        {
            if (!string.IsNullOrWhiteSpace(value))  
            {
                description = value;
            }
        }
    }

    public double Weight
    {
        get
        {
            return weight;
        }

        set
        {
            if (value > 0)   // validation
            {
                weight = value;
            }
        }
    }

    public decimal DeliveryFee
    {
        get
        {
            return deliveryFee;
        }

        private set
        {
            if (value > 0)
            {
                deliveryFee = value;
            }
        }
    }

    public DeliveryAddress Destination { get; set; }

    public decimal EstimatedCost   // computed property
    {
        get
        {
            return DeliveryFee + ((decimal)Weight * 5);
        }
    }


    public Shipment(string trackingCode)
    {
        trackingCode = trackingCode;
        description = "Unknown";
        weight = 1;
        deliveryFee = 50;
        Destination = default;
    }

    public Shipment(string trackingCode, string description, double weight,
                decimal deliveryFee, DeliveryAddress destination)
    {
        trackingCode = trackingCode;
        description = description;
        weight = weight;
        deliveryFee = deliveryFee;
        Destination = destination;
    }

    public void UpdateDeliveryFee(decimal new_Fee)
    {
        if (new_Fee > 0)
        {
            DeliveryFee = new_Fee;
        }
    }

    public void PrintShipment()
    {
        Console.WriteLine("Tracking Code: " + TrackingCode);
        Console.WriteLine("Description: " + Description);
        Console.WriteLine("Weight: " + Weight);
        Console.WriteLine("Delivery Fee: " + DeliveryFee );
        Console.WriteLine("Destination: " + Destination.GetFullAddress());
        Console.WriteLine("Estimated Cost: " + EstimatedCost );
    }















}
