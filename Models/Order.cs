﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTracker.Models {
    public class Order {
        public Request Activity { get; set; }
        public Student Student { get; set; }
        public Employee Evaluator { get; set; }
        public DateTime EvaluationDate { get; set; }
        public int Points { get; set; }

        /*public bool IsSufficientForGrade() {
            return Points >= Activity.MinPointsForGrade;
        }

        public bool IsSufficientForSignature() {
            return Points >= Activity.MinPointsForSignature;
        }*/

    }

}
