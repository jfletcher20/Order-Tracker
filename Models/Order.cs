using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTracker.Models {
    public class Order {
        public Request request { get; set; }
        public Employee employee { get; set; }
        public DateTime EvaluationDate { get; set; }

    }

}
