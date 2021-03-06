using System.Collections.Generic;
using RestApisWithAspNet.Hypermedia;
using RestApisWithAspNet.Hypermedia.Abstract;

namespace RestApisWithAspNet.Data.VO
{
    public class PersonVO : ISupportHyperMedia
    {
        public long Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string Gender { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
