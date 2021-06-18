using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter {
    public class Engineer : Person{

        public decimal SalaryPerMonth { get; set; }
        public string HiringDate { get; set; }

        public Engineer(): base() {

        }
        public Engineer(decimal salaryPerMonth, string date) :base(){
            SalaryPerMonth = salaryPerMonth;
            HiringDate = date;
        }
    }
}
