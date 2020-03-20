using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CubesSol.AplicationDomain;
using CubesSol.ObjectDomain;

namespace CubesSol.WebApi.Controllers
{
    public class CubeServiceController : ApiController
    {

        private readonly IADCube _IADCube;

        public CubeServiceController(IADCube iADCube)
        {
            _IADCube = iADCube;
        }

        /// <summary>
        /// This service is for to know if 2 cubes given are colliding.
        /// </summary>
        /// <param name="dimensionC1">This value represent the size of the cube 1 (high, long, wide).</param>
        /// <param name="x1">Coordinate x from cube 1</param>
        /// <param name="y1">Coordinate y from cube 1</param>
        /// <param name="z1">Coordinate z from cube 1</param>
        /// <param name="dimensionC2">This value represent the size of the cube 2 (high, long, wide).</param>
        /// <param name="x2">Coordinate x from cube 2</param>
        /// <param name="y2">Coordinate y from cube 2</param>
        /// <param name="z2">Coordinate z from cube 2</param>
        /// <returns></returns>
        [HttpGet]
        public bool ThoseCubesAreIntersected(int dimensionC1, int x1, int y1, int z1, int dimensionC2, int x2, int y2, int z2)
        {
            cube cube1 = new cube();
            cube1.dimension = dimensionC1;
            cube1.xCoord = x1;
            cube1.yCoord = y1;
            cube1.zCoord = z1;

            cube cube2 = new cube();
            cube2.dimension = dimensionC2;
            cube2.xCoord = x2;
            cube2.yCoord = y2;
            cube2.zCoord = z2;

            return _IADCube.thereIsIntersection(cube1, cube2);
        }

        /// <summary>
        /// This service is for to know the cubes's intersection volume.
        /// </summary>
        /// <param name="dimensionC1">This value represent the size of the cube 1 (high, long, wide).</param>
        /// <param name="x1">Coordinate x from cube 1</param>
        /// <param name="y1">Coordinate y from cube 1</param>
        /// <param name="z1">Coordinate z from cube 1</param>
        /// <param name="dimensionC2">This value represent the size of the cube 2 (high, long, wide).</param>
        /// <param name="x2">Coordinate x from cube 2</param>
        /// <param name="y2">Coordinate y from cube 2</param>
        /// <param name="z2">Coordinate z from cube 2</param>
        /// <returns></returns>
        [HttpGet]
        public int GetIntersectionVolume(int dimensionC1, int x1, int y1, int z1, int dimensionC2, int x2, int y2, int z2)
        {
            cube cube1 = new cube();
            cube1.dimension = dimensionC1;
            cube1.xCoord = x1;
            cube1.yCoord = y1;
            cube1.zCoord = z1;

            cube cube2 = new cube();
            cube2.dimension = dimensionC2;
            cube2.xCoord = x2;
            cube2.yCoord = y2;
            cube2.zCoord = z2;

            return _IADCube.IntersectionVolume(cube1, cube2);
        }
    }
}
