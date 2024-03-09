using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchVehicles.Domain
{
    public class Constants
    {
        public const string RESOURCE_GET_VEHICLE_BY_LOCALITY = "GetVehiclesByLocality";
        public const string MESSAGE_ID_LOCATION_COLLECTION_NULL = "Id Location Collection is invalid or empty";
        public const string ERROR_CODE_ID_LOCATION_COLLECTION_NULL = "1010";
        public const string MESSAGE_ID_LOCATION_RETURN_NULL = "Id Location Return is invalid or empty";
        public const string ERROR_CODE_ID_LOCATION_RETURN_NULL = "1020";
        public const string APPLICATION_ERROR_CODE = "999";

        public const string MESSAGE_VEHICLES_NOT_FOUND = "Vehicles not avalaible with this Locations";
        public const string ERROR_CODE_VEHICLES_NOT_FOUND = "1030";
    }
}
