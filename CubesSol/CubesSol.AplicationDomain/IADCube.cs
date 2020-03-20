using CubesSol.ObjectDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubesSol.AplicationDomain
{
    public interface IADCube
    {
        bool thereIsIntersection(cube pCube1, cube pCube2);
    }
}
