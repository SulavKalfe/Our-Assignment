class Car
{
    private string brand;
    private int year;
    private float price;

    public Car(string brand, int year, float price)
    {
        this.brand = brand;
        this.year = year;
        this.price = price;
    }
    public void CarDetails()
    {
        Console.WriteLine($"Brand: {brand}");
        Console.WriteLine($"Year: {year}");
        Console.WriteLine($"Price: ${price}");
    }
}

//class Program
//{
//    static void Main()
//    {
//        Car myCar = new Car("Bugatti", 2018, 500000.00f);
//        myCar.CarDetails();
//    }
//}
