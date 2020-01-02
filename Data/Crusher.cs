using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Data
{
    public class Crusher
    {

        public void Crush(IVehicle vehicle)
        {
            var name = vehicle.Name();
        }

    }

    public static class VehicleExtensions
    {
        public static string Name(this IVehicle vehicle)
        {
            return vehicle.Year + " " + vehicle.Make + " " + vehicle.Model;
        }
    }

    public interface IVehicle
    {
       int Year { get; set; }
       string Make { get; set; }
       string Model { get; set; }

 
    }

    public class Car: IVehicle
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

    }
}
