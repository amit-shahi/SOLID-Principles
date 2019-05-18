namespace Car_Inheritance
{
    public interface ICar
    {
        bool GetIsSedan();
        string GetMileage();
        string GetNoOfSeats();
        string Print(CarType carType);
    }
}