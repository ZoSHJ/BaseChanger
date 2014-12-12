using System;
using System.Text;

namespace base_changer
{

    public class basechanger
    {
        private static double result;
        private static string result1;
        public static string Bin2Dec(string inputfirst)
        {
            try
            {
                result = 0; // Reset the variable
                int lengthin = inputfirst.Length; // Created this variable so we can keep track of where we are
                char[] binput = inputfirst.ToCharArray();
                foreach (char caract in binput) // We navigate through the char array
                {
                    if (caract.ToString() == "1")
                    {
                        result += Math.Pow(2, lengthin - 1);
                    }
                    lengthin--;
                }
                return Convert.ToString(result);
            }
            catch
            {
                return "Error";
            }
        }
        public static string Dec2Bin(string inputfirst)
        {
            try
            {
                result = Convert.ToDouble(inputfirst);
                string bin = "";
                while (result > 0)
                {
                    if (result % 2 == 0)
                    {
                        bin = "0" + bin;
                    }
                    else
                    {
                        bin = "1" + bin;
                    }
                    result = result / 2;
                }
                return bin;
            }
            catch
            {
                return "Error";
            }
        }
        
        public static string Dec2Hex(string inputfirst)
        {
            try
            {
                result1 = "";
                double he = Convert.ToDouble(inputfirst);
                double resto = 0;
                while (he > 0)
                {
                    resto = he % 16;
                    if (resto < 10)
                    {
                        result1 = Convert.ToString(resto) + result1;
                    }
                    else if (resto == 10)
                    {
                        result1 = "A" + result1;
                    }
                    else if (resto == 11)
                    {
                        result1 = "B" + result1;
                    }
                    else if (resto == 12)
                    {
                        result1 = "C" + result1;
                    }
                    else if (resto == 13)
                    {
                        result1 = "D" + result1;
                    }
                    else if (resto == 14)
                    {
                        result1 = "E" + result1;
                    }
                    else if (resto == 15)
                    {
                        result1 = "F" + result1;
                    }
                    he /= 16;
                    he = Math.Truncate(he);
                }
                return result1;
            }
            catch
            {
                return "Error";
            }
        }
        public static string Dec2Oct(string inputfirst)
        {
            try
            {
                result1 = "";
                double he = Convert.ToDouble(inputfirst);
                double resto = 0;
                while (he > 0)
                {
                    resto = he % 8;
                    result1 = Convert.ToString(resto) + result1;
                    he /= 8;
                    he = Math.Truncate(he);
                }
                return result1;
            }
            catch
            {
                return "Error";
            }
        }
        public static string Oct2Dec(string inputfirst)
        {
            try
            {
                result = 0;
                int lengthin = inputfirst.Length;
                char[] binput = inputfirst.ToCharArray();
                foreach (char caract in binput)
                {

                    result += Math.Pow(8, lengthin - 1) * Convert.ToByte(caract.ToString());
                    lengthin--;
                }
                return Convert.ToString(result);
            }
            catch
            {
                return "Error";
            }
        }
        public static string Hex2Dec(string inputfirst)
        {
            try
            {
                result = 0;
                int lengthin = inputfirst.Length;
                char[] binput = inputfirst.ToCharArray();
                foreach (char caract in binput)
                {
                    string foo = caract.ToString();
                    if (foo == "A" | foo == "a")
                    {
                        bar = 10;
                    }
                    else if (foo == "B" | foo == "b")
                    {
                        bar = 11;
                    }
                    else if (foo == "C" | foo == "c")
                    {
                        bar = 12;
                    }
                    else if (foo == "D" | foo == "d")
                    {
                        bar = 13;
                    }
                    else if (foo == "E" | foo == "e")
                    {
                        bar = 14;
                    }
                    else if (foo == "F" | foo == "f")
                    {
                        bar = 15;
                    }
                    else
                    {
                        bar = Convert.ToByte(foo);
                    }
                    result += Math.Pow(16, lengthin - 1) * bar;
                    lengthin--;
                }
                return Convert.ToString(result);
            }
            catch
            {
                return "Error";
            }
        }
    }
}
