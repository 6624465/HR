using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Core.Models.Master
{
    public class Country
    {
        public int Id { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string Description { get; set; }
    }
}
