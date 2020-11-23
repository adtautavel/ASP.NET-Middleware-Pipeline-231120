using System;

namespace ASP_MW_Pipeline_quest231120
{
    public class Allow
    {
        public string PrintAllow(string parameter)
        {
            if (parameter == "allow")
                return "Hello World!";
            
            else
                throw new NotImplementedException();
        }
    }
}
