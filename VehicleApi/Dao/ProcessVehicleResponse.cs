using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleApi.Dao
{
    public enum VehicleValidationResultCode
    {
        NotSpecified,
        Invalid,
        Valid
    }

    public class ProcessVehicleResponse
    {
        public int VehicleId { get; set; }
        public VehicleValidationResultCode ReturnCode { get; set; }

        public ProcessVehicleResponse()
        {
            VehicleId = 0;
            ReturnCode = VehicleValidationResultCode.NotSpecified;
        }

        public ProcessVehicleResponse(int VehicleId, VehicleValidationResultCode ReturnCode)
        {
            this.VehicleId = VehicleId;
            this.ReturnCode = ReturnCode;
        }
    }
}
