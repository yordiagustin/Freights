using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Freights.Domain
{
    [DataContract]
    public class Incidence
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Latitude { get; set; }
        [DataMember]
        public string Longitude { get; set; }
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public int OrderId { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
    }
}
