using System;
using System.Collections.Generic;
using System.Text;

namespace Session05Animals
{
    public interface IIBarnyardAnimal
    {
        string RestingArea { get; }
        string FeedingArea { get; set; }
    }
}
