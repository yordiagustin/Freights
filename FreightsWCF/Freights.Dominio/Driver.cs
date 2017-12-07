using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Freights.Dominio
{
    public class Driver
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Surname { get; set; }
        [DataMember]
        public string Dni { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string LoginCode { get; set; }
        [DataMember]
        public string LicenseNumber { get; set; }
        [DataMember]
        public string LicenseCategory { get; set; }
        [DataMember]
        public string Status { get; set; }
    }
}
