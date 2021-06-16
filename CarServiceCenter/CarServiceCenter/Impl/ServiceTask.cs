using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.Impl {

    public class ServiceTask : Entity {

        public string Code  { get; set; }
        public string Description { get; set; }
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
