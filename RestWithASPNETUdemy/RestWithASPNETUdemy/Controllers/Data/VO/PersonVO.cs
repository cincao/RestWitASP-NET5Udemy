using RestWithASPNETUdemy.Hypermedia;
using RestWithASPNETUdemy.Hypermedia.Abstract;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Controllers.Data.VO
{
    public class PersonVO : ISupportsHipermedia
    {
        public long Id { get; set; }
        public string FistName { get; set; }
        public string LastName{ get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
