using Vehicle;

namespace Program
{
    class Program()
    {
        public static void Main()
        {
            Vehicle.Vehicle myVehicle = new("Ford","TUUUT TUUUT !");
            myVehicle.Honk();
        }
    }
}