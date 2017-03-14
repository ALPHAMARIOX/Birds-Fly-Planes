/*
Lee Harrold 
 ° March 14, 2017
 This program is to be used in documenting flight plans in an easier manner.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWAL_FLIGHT_PLAN
{
    class FlightPlan
    {
        //Attributes.
        //Top form.

        private DateTime fpDate; //Date flight was made.
        private string registration; //Registration ID.
        private string aircraftType; //Type of aircraft.
        private string captain; //Name of captain.
        private string firstOfficer; //Name of first officer.
        
        //Middle Form.
        private plr;
        private apr;
        private double crAlt;
        private trk;
        private tas;
        private string windDir;
        private double windSpd;

        //Fuel.
        private double reserve;
        private double contgy;
        private double taxi;
        private double fob;

        //Weights.
        private double pob_est;
        private double pob_act;
        private double crew;
        private double baggage;
        private double fuelWeight;
        private double lateLoad;

        //Bottom Form.
        private string clearance;
        private string weather;

        private string comments;
        
        //Public for the GUI and main program.
        //Properties.

        public DateTime FpDate { get; set; }
        public string Registration { get; set; }
        public string AircraftType { get; set; }
        public string Captain { get; set; }
        public string FirstOfficer { get; set; }

        public string CrAlt { get; set; }

        public string WindDir { get; set; }
        public double WindSpd { get; set; }

        public string Clearance { get; set; }
        public string Weather { get; set; }

        //Constructor. (Default option).
        public FlightPlan()
        {

        }

        //Constructor that requires more information to be filled in.
        public FlightPlan(DateTime fpDate, string registration, string aircraftType, string captain, string firstOfficer)
        {
            FpDate = fpDate;
            Registration = registration;
            AircraftType = aircraftType;
            Captain = captain;
            FirstOfficer = firstOfficer;
        }

        //Methods.
        public double GetBasicWeight()
        {
            return 0;
        }

        public double GetRampWeight()
        {
            return 0;
        }

        public double GetZFWT()
        {
            return 0;
        }

        public double GetTaxiBurn()
        {
            return 0;
        }

        public double GetTOWeight()
        {
            return 0;
        }

        public double GetFuelBurned()
        {
            return 0;
        }

        public double GetLanding()
        {
            return 0;
        }

        public double GetTotal()
        {
            return 0;
        }
    }
}
