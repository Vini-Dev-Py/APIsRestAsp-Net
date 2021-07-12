using RestApisWithAspNet.Hypermedia.Abstract;
using System.Collections.Generic;

namespace RestApisWithAspNet.Hypermedia.Filters
{
    public class HyperMediaFilterOptions
    {
        public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}