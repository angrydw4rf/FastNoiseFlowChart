using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.Definitions
{
    public enum NoiseType { Value, ValueFractal, Perlin, PerlinFractal, Simplex, SimplexFractal, Cellular, WhiteNoise, Cubic, CubicFractal };
    public enum Interp { Linear, Hermite, Quintic };
    public enum FractalType { FBM, Billow, RigidMulti };
    public enum CellularDistanceFunction { Euclidean, Manhattan, Natural };
    public enum CellularReturnType { CellValue, NoiseLookup, Distance, Distance2, Distance2Add, Distance2Sub, Distance2Mul, Distance2Div };
}
