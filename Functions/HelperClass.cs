using System;
using System.Drawing;
using System.Text.RegularExpressions;
using BackEnd;
using Microsoft.EntityFrameworkCore;

namespace Functions
{
    public static class HelperClass
    {
        public static FunctionClass functions = new FunctionClass();

        public static string StringWashPhone(string phoneNumber)
        {

            Regex washIt = new Regex(@"^[0-9\s]{1,10}$");
            phoneNumber = Regex.Replace(phoneNumber, "\\s+", string.Empty).Trim();

            if (!washIt.IsMatch(phoneNumber))
            {
                throw new FormatException("Input contains invalid characters.");
                //return null;
            }
            string washed = phoneNumber;
            return washed;
        }

        public static string StringWashName(string name)
        {
          string specialChar = @"\|!#$%&/()=?»«@£§€{}.;'<>_,0123456789";

            foreach (var item in specialChar)
            {
                try
                {
                    if (name.Contains(item)) { name = null; }
                    if (name == null) throw new ArgumentNullException();
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return name;
        }
        public static Color ChangeBackColorPhone(string phoneNumber)
        {
            phoneNumber = StringWashPhone(phoneNumber);
            Color color;
            if (phoneNumber != null)
            {
                color = Color.LightGreen;
            }
            else
            {
                color = Color.White; //Används aldrig.
            }
            return color;
        }
        public static Color ChangeBackColorName(string name)
        {
            name = StringWashName(name);
            Color color;
            if (name != null)
            {
                color = Color.LightGreen;
            }
            else
            {
                color = Color.White; //Används aldrig.
            }
            return color;
        }
    }
}
