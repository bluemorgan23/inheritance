using System;
using System.Collections.Generic;

namespace inheritance_practice
{
    public interface IStation<T>
    {
        int Capacity {get; set;}

        void Refuel(List<T> vehicles);
        
    }
}