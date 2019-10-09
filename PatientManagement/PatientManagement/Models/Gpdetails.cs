using System;
using System.Collections.Generic;

namespace PatientManagement.Models
{
    public partial class Gpdetails
    {
        public int Id { get; set; }
        public int? PatientId { get; set; }
        public int? Gpcode { get; set; }
        public string Gpsurname { get; set; }
        public string Gpinitials { get; set; }
        public string Gpphone { get; set; }
    }
}
