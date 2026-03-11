using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace ITIDatabaseSystem.Repository
{
    public class Validations
    {
        private static readonly string RgxName = @"^[a-zA-Z]+$";
        private static readonly string RgxCrsName = @"^[a-zA-Z]+( [a-zA-Z]+)*$";
        private static readonly string RgxPhone = @"^(010|011|012|015)\d{8}$";
        private static readonly string RgxNumber = @"^\d+$";
        private static readonly string RgxSalary = @"^\d+(\.\d{1,2})?$";

        public static bool CheckName(string name)
        {
            return Regex.IsMatch(name, RgxName);
        }
        public static bool CheckCrsName(string name)
        {
            return Regex.IsMatch(name, RgxCrsName);
        }
        public static bool CheckNumber(string num)
        {
            return Regex.IsMatch(num, RgxNumber);
        }
        public static bool CheckPhone(string phone)
        {
            return Regex.IsMatch(phone, RgxPhone);
        }
        public static bool CheckSalary(string salary)
        {
            return Regex.IsMatch(salary, RgxSalary);
        }
        public static bool CheckDate(string date)
        {
            return DateTime.TryParseExact(
                date,
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out _
            );
        }
    }
}
