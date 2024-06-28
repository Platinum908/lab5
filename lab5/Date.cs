using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class Date
    {
        public int years { get; set; }
        public int months { get; set; }
        public int days { get; set; }

        public Date(int years, int months, int days)
        {
            this.years = years;
            this.months = months;
            this.days = days;
        }
    }
}
