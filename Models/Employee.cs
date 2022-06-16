using OrderTracker.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTracker.Models {
    public class Employee : User {
        public string Password { get; set; }

        public bool CheckPassword(string password) {
            return Password == password;
        }
        public bool IsOrdinary() {
            return Permissions == 0;
        }
        public bool IsCIP() {
            return Permissions == 1;
        }
        public bool IsProjectLeader() {
            return Permissions == 2;
        }
        public bool IsBookKeeper() {
            return Permissions == 3;
        }
        public bool IsViceDean() {
            return Permissions == 4;
        }

        public void PerformEvaluation(Request student, Request request, int points) {
            var evaluation = OrderRepository.GetOrder(student/*, request*/);
            if (evaluation == null) {
                OrderRepository.InsertOrder(student, request, this, points);
            } else {
                OrderRepository.UpdateOrder(evaluation, this, points);
            }
        }


    }
}
