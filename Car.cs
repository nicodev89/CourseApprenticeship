using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNicoloRossi
{
    internal class Car
    {

        public string VehicleRegNo { get; set; }
        public string Make { get; set;}
        public string EngineSize { get; set; }
        public DateTime DateRegistered { get; set; }
        public decimal RentalPerDay { get; set; }
        public bool Available { get; set; }

        public override string ToString()
        {
            return $" Registration N. = {VehicleRegNo}\nMake = {Make}\n" +
                $"EngineSize = {EngineSize}\nDataRegistered = {DateRegistered}\n" +
                $"RentalPerDay = {RentalPerDay}\nAvailable = {Available}";
        }

    }
}
