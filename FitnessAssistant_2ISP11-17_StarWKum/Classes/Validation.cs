using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAssistant_2ISP11_17_StarWKum.Classes
{
    public class Validation
    {
        public static bool ValidationPassword(string password)
        {

            if (password.Length < 8 || password.Length > 20)
            {
                return false;

            }
            if (!password.Any(char.IsUpper))
            {
                return false;
            }
            if (!password.Any(char.IsLower))
            {
                return false;
            }
            if (!password.Any(char.IsDigit))
            {
                return false;
            }
            if (!password.Any(char.IsPunctuation))
            {
                return false;
            }
            if (password == "")
            {
                return false;
            }
            if (password.Any(char.IsWhiteSpace))
            {
                return false;
            }
            return true;
        }
        public static bool ValidationFLP(string fname)
        {
            if (fname.Any(char.IsDigit))
            {
                return false;
            }
            if (!fname.Any(char.IsWhiteSpace) )
            {
                return true;
            }
            if (fname.Intersect("-").Count() >= 0)
            {
                return true;
            }
            if (!fname[0].ToString().Any(char.IsUpper))
            {
                return false;
            }
            if (fname == "")
            {
                return false;
            }
            if (fname.Intersect("_").Count() >= 0)
            {
                return false;
            }
            if (fname.Intersect(" ").Count() >= 0)
            {
                return false;
            }
            return true;
        }
        public static bool ValidationHeightWeight(string height)
        {
            if (height == "")
            {
                return false;
            }
            if (!height.All(char.IsDigit))
            {
                return false;
            }
            if (Convert.ToInt32(height) < 0)
            {
                return false;
            }
            if (Convert.ToInt32(height) > 300)
            {
                return false;
            }

            if (height.Any(char.IsWhiteSpace))
            {
                return false;
            }

            return true;
        }
      
    }
}
    
