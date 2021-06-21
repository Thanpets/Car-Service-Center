using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace CarServiceCenter.Impl {
    public class JsonHandler {

        private const string _JsonFile = "CarServiceCenterData.json";

        public JavaScriptSerializer serializer { get; set; }
        public string path { get; set; }
        public string data { get; set; }
        public ServiceCenter MyServiceCenter = null;

        public JsonHandler() {
            serializer = new JavaScriptSerializer();
        }


        public void SerializeToJson(ServiceCenter objectToBeSerialized) {

            data = serializer.Serialize(objectToBeSerialized);

            path = Path.Combine(Environment.CurrentDirectory, _JsonFile);

            File.WriteAllText(path, data);
        }


        public ServiceCenter DeserializeFromJson() {

            

            path = Path.Combine(Environment.CurrentDirectory, _JsonFile);

            data = string.Empty;

            if (File.Exists(path)) {

                data = File.ReadAllText(path); 
                MyServiceCenter = serializer.Deserialize<ServiceCenter>(data);
                
            }
            else {


                File.Create(path).Dispose();

                MyServiceCenter = new ServiceCenter() {


                    Name = "CarServiceCenterName",
                    Customers = new List<Customer>(),
                    Cars = new List<Car>(),
                    Engineers = new List<Engineer>(),
                    Transactions = new List<Transaction>(),
                    ServiceTasks = new List<ServiceTask>(),
                    MonthlyLedgers = new List<MonthlyLedger>()


                };

                SerializeToJson(MyServiceCenter);

            }

            return MyServiceCenter;



        }

    }
}
