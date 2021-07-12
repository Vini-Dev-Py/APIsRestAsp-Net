using System.Collections.Generic;

namespace RestApisWithAspNet.Hypermedia.Abstract
{
    public interface ISupportHyperMedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}