using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class Outsourced : Part
    {
        private string companyName;

        public void SetCompanyName(string newCompanyName)
        {
            companyName = newCompanyName;
        }

        public string GetCompanyName()
        {
            return companyName;
        }
    }
}
