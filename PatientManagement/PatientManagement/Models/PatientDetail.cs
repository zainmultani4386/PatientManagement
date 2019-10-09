using System;
using System.Collections.Generic;

namespace PatientManagement.Models
{
    public partial class PatientDetail
    {
        public int? PasNumber { get; set; }
        public string ForeName { get; set; }
        public string SurName { get; set; }
        public string SexCode { get; set; }
        public string HomeTelePhoneNumber { get; set; }
        public string DateOfBirth { get; set; }
        public string NokName { get; set; }
        public string NokRelationShipCode { get; set; }
        public string NokAddressLine1 { get; set; }
        public string NokAddressLine2 { get; set; }
        public string NokAddressLine3 { get; set; }
        public string NokAddressLine4 { get; set; }
        public string NokPostcode { get; set; }
        public string Gpcode { get; set; }
        public string Gpsurname { get; set; }
        public string Gpinitials { get; set; }
        public string Gpphone { get; set; }
        public int Id { get; set; }
    }
}
