using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class Lti
    {
        public int LtiId { get; set; }
        public string TypeOfVehicle { get; set; }        
        public string VehicleYear { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public int VehicleMileage { get; set; }
        public int VinNumber { get; set; }
        public string Engine { get; set; }
        public string Clutch { get; set; }
        public string Carburetor { get; set; }
        public string FuelPump { get; set; }
        public string DieselMultiFuel { get; set; }
        public string Turbocharger { get; set; }
        public string ExhaustSystem { get; set; }
        public string CoolingSystem { get; set; }
        public string Battery { get; set; }
        public string Distributor { get; set; }
        public string Alternator { get; set; }
        public string Lights { get; set; }
        public string Regulator { get; set; }
        public string Wiring { get; set; }
        public string Transmission { get; set; }
        public string TransferCase { get; set; }
        public string DriveShaft { get; set; }
        public string FrontAxle { get; set; }
        public string ParkingBrake { get; set; }
        public string ServiceBrake { get; set; }
        public string AirSystem { get; set; }
        public string Tires { get; set; }
        public string Tracks { get; set; }
        public string Wheels { get; set; }
        public string SteeringGear { get; set; }
        public string HydraulicSystem { get; set; }
        public string Frame { get; set; }
        public string TowingConnection { get; set; }
        public string ShockAbsorbers { get; set; }
        public string Springs { get; set; }
        public string Fender { get; set; }
        public string Hood { get; set; }
        public string Body { get; set; }
        public string Cabin { get; set; }
        public string VehicleFloor { get; set; }
        public string Glass { get; set; }
        public string InteriorTrim { get; set; }
        public string SeatsAndUpholster { get; set; }
        public string VehicleAccessories { get; set; }
        public string InstrumentCluster { get; set; }
        public DateTime? DateOfInspection { get; set; }
        public int? MechanicName { get; set; }
        public string Remarks { get; set; }

        [ForeignKey("User")]
        public int User { get; set; }
        public User Owner { get; set; }
    }
}
