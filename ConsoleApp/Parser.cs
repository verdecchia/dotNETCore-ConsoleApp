using System;

namespace ConsoleApp
{
    public class Parser
    {
        public int? Parse(string value) {
            if(String.IsNullOrEmpty(value)) return null;
            if(value.Contains(",") || value.Contains(".")) return null;
            
            int result;
            if(Int32.TryParse(value, out result)) return result;

            return null;
        }
    }
}