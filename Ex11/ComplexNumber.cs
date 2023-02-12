using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    public class ComplexNumber
    {
        public double RealPart { get; set; }
        public double ImaginaryPart { get; set; }

        public ComplexNumber(double realPart, double imaginaryPart)
        {
            RealPart = realPart;
            ImaginaryPart = imaginaryPart;
        }

        public ComplexNumber()
        {
            this.RealPart = 0;
            this.ImaginaryPart = 0;
        }

        public string ShowComplexNumber()
        {
            return ($"{this.RealPart} + {this.ImaginaryPart}i");
        }

        public ComplexNumber SumTwoComplexNumber(ComplexNumber b)
        {
            double new_real = this.RealPart + b.RealPart;
            double new_imaginary = this.ImaginaryPart + b.ImaginaryPart;
            return new ComplexNumber(new_real, new_imaginary);
        }

        public ComplexNumber MultiplicationTwoComplexNumber(ComplexNumber b)
        {
            double new_real = this.RealPart * b.RealPart - this.ImaginaryPart * b.ImaginaryPart;
            double new_imaginary = this.RealPart * b.ImaginaryPart + this.ImaginaryPart * b.RealPart;
            return new ComplexNumber(new_real, new_imaginary);
        }
    }
}
