using System.Collections.Generic;

namespace RestWithASPNETUdemy.Hypermedia.Abstract
{
    public interface ISupportsHipermedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}
