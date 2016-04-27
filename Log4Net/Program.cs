using System.Collections.Generic;
using log4net;
using Log4Net.Car;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace Log4Net
{
    class Program
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static readonly ILog log = LogManager.GetLogger("LogFileAppender");
        private static readonly ILog perLog = LogManager.GetLogger("PerformanceLogFileAppender");

        static void Main(string[] args) {
            var car = new Car.Car {
                Colour = Car.Car.CarColour.Black,
                Name = "Volvo",
                Tire =
                    new List<Tire> {
                        new Tire {TyreType = Season.Summer},
                        new Tire {TyreType = Season.Summer},
                        new Tire {TyreType = Season.Summer},
                        new Tire {TyreType = Season.Summer}
                    }
            };
            Car.Car.RepaintCar(car, Car.Car.CarColour.Red);
            log.DebugFormat("message");

            perLog.DebugFormat("Performance");
        }
    }
}
