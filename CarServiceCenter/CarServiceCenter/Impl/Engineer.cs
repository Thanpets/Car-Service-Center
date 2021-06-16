using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter {
    class Engineer {

        public decimal SalaryPerMonth { get; set; }


        public Engineer(decimal salaryPerMonth) :base(){
            SalaryPerMonth = salaryPerMonth;
        }
    }
}
