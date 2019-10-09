using System;
using System.Collections.Generic;

namespace PatientManagement.Models
{
    public partial class PatientNextOfKin
    {
        public int KinId { get; set; }
        public int? PatientId { get; set; }
        public string NokName { get; set; }
        public string NokRelationshipCode { get; set; }
        public string NokAddressLine1 { get; set; }
        public string NokAddressLine2 { get; set; }
        public string NokAddressLine3 { get; set; }
        public string NokAddressLine4 { get; set; }
        public string NokPostcode { get; set; }
    }
}
