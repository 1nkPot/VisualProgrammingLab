using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Classes
{
    public int CustomerId { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}

public class RetailCustomer : Classes
{
    public string CreditCardType { get; set; }
    public string CreditCardNo { get; set; }
}

public class CorporateCustomer : Classes
{
    public string CompanyName { get; set; }
    public int FrequentFlyerPts { get; set; }
    public string BillingAccountNo { get; set; }
}

public class Seat
{
    public int RowNo { get; set; }
    public int SeatNo { get; set; }
    public decimal Price { get; set; }
    public string Status { get; set; }
}

public class Flight
{
    public int FlightId { get; set; }
    public DateTime Date { get; set; }
    public string Origin { get; set; }
    public string Destination { get; set; }
    public TimeSpan DepartureTime { get; set; }
    public TimeSpan ArrivalTime { get; set; }
    public int SeatingCapacity { get; set; }
    public Flight()
    {
       
    }
}

public class Reservation
{
    public int ReservationNo { get; set; }
    public DateTime Date { get; set; }
    public Flight Flight { get; set; }
    public Reservation()
    {
        
    }
}