using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1_TTriangle
{
    public class TTriangle
    {
        private double A, B, C;

        public TTriangle(double A, double B, double C)
        {
            if (A <= 0 || B <= 0 || C <= 0)
            {
                throw new Exception("The sides of triangle must be greater then 0");
            }
                
            if (!CheckExistanceOfTriangle(A, B, C))
            {
                throw new Exception("Triangle does not exist");
            }

            this.A = A; 
            this.B = B; 
            this.C = C;
        }
        
        public bool CheckExistanceOfTriangle(double A, double B, double C)
        {
            return (A < B + C && B < A + C && C < A + B);
        }

        public double ASide
        {
            get
            {
                return A;
            }
            set
            {
                if (CheckExistanceOfTriangle(value, B, C))
                {
                    A = value;
                }

                else
                {
                    throw new Exception("Triangle does not exist");
                }
            }
        }

        public double BSide
        {
            get
            {
                return B;
            }
            set
            {
                if (CheckExistanceOfTriangle(A, value, C))
                {
                    B = value;
                }

                else
                {
                    throw new Exception("Triangle does not exist");
                }
            }
        }

        public double CSide
        {
            get
            {
                return C;
            }
            set
            {
                if (CheckExistanceOfTriangle(A, B, value))
                {
                    C = value;
                }

                else
                {
                    throw new Exception("Triangle does not exist");
                }
            }
        }

        public double GetPerimeter()
        {
            return A + B + C;
        }

        public double GetArea()
        {
            double p = (A + B + C) / 2;

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
