using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;


namespace Log4Net.Car
{
    public class Car
    {
        public enum CarColour
        {
            Red,Blue,White,Black,Gray
        }
        public string Name { get; set; }
        public List<Tire> Tire { get; set; }
        public CarColour Colour { get; set; }
        public static void RepaintCar(Car car, CarColour colour) {
            car.Colour = colour;
            //return car;
        }
    }

    
}
