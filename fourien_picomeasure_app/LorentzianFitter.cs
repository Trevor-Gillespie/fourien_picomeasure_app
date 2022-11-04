using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;
using MathNet;
using MathNet.Numerics;
using MathNet.Numerics.Distributions;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace fourien_picomeasure_app
{
    internal class LorentzianFitter
    {
        public double Gaussian { get; set; }


        
        public double gauss(double x, double a, double b, double c)
        {
            var v1 = (x - b) / (2d * c * c);
            var v2 = -v1 * v1 / 2d;
            var v3 = a * Math.Exp(v2);

            return v3;
        }
    }
}
