using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.Impl {

    public class ServiceTask : Entity {

        public String Code  { get; set; }
        public String Description { get; set; }
        public decimal PricePerHour { get; set; }


        public ServiceTask() {

        }

        public ServiceTask(string code, string description, decimal pricePerHour ): base() {
            Code = code;
            Description = description;
            PricePerHour = pricePerHour;
        }



    }
}
