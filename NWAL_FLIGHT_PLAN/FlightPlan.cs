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
        private string registration;
        private string aircraftType;
        private string captain;
        private string firstOfficer;
        
        //Middle Form.
        private plr;
        private apr;
        private double crAlt;
        private trk;
        private windDir;

        //Bottom Form.

        
        //Public for the GUI and main program.
        //Properties.
        public DateTime FpDate { get; set; }
        public string Registration { get; set; }
        public string AircraftType { get; set; }
        public string Captain { get; set; }
        public string FirstOfficer { get; set; }

        //Constructor. (Default option).
        public FlightPlan()
        {

        }

        public FlightPlan(DateTime fpDate, string registration, string aircraftType, string captain, string firstOfficer)
        {
            FpDate = fpDate;
            Registration = registration;
            AircraftType = aircraftType;
            Captain = captain;
            FirstOfficer = firstOfficer;
        }
    }
}
