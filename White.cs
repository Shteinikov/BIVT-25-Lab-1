﻿using System.ComponentModel.Design;
using System.IO.Pipes;
using System.Runtime.InteropServices;

namespace Lab1
{
    public class White
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            if (d > 0) answer = true;
            else answer = false;

            // end

            return answer;
        }
        public bool Task2(int n)
        {
            bool answer = false;

            // code here
            if (n % 2 == 0) answer = true;
            else answer = false;

            // end

            return answer;
        }
        public int Task3(int a, int b)
        {
            int answer = 0;

            // code here
            if (a > b) answer = a;
            else answer = b;
            

            // end

            return answer;
        }
        public double Task4(double d, double f)
        {
            double answer = 0;

            // code here
            double a = Math.Abs(f);
            double b = Math.Abs(d);
            if (a < b) answer = f;
            else
            {
                answer = d;
            }
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (Math.Abs(x) > 1) answer = 1;
            else answer = x;

                // end

                return answer;
        }
        public bool Task6(double x, double y, double r)
        {
            bool answer = false;

            // code here
            double vir = x * x + y * y - r * r;
            if (Math.Abs(vir) <= Math.Pow(10, -6) || Math.Abs(vir) <= r * r * 1e-4)
            {
                answer = true;
            }
            // end

            return answer;
        }

        public bool Task7(int n)
        {
                
            // code here
            int s = n * n;
            bool answer = false;
            if (s - n > 2 * n) 
            { 
                if (n % 2 == 0)
                {
                    answer = true;
                }
            }
            return answer;

            // end

        }
        public bool Task8(double L, int T, int M)
        {
            bool answer = false;

            // code here
            if (L / 10 <= 3)
            {
                if (T+M >= 5)
                {
                    if ( M % 2 == 0)
                        answer = true;
                }
                
            }   
            // end

            return answer;
        }
    }
}