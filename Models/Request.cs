using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTracker.Models {
    public class Request {

        /*public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int MaxPoints { get; set; }
        public int MinPointsForGrade { get; set; }
        public int MinPointsForSignature { get; set; }*/

        public int ID { get; set; } // rqst order
        public string Status { get; set; } // rqst status
        public int Applicant { get; set; } // rqst employee id
        public string Rqst_description { get; set; } // rqst info
        public string Financing { get; set; } // financing methode
        public string Financing_description { get; set; } // extra financing info
        public float Ponuda1_bez_pdv { get; set; }
        public float Ponuda1_s_pdv { get; set; }
        public string Ponuda1_odabrana { get; set; }
        public float Ponuda2_bez_pdv { get; set; }
        public float Ponuda2_s_pdv { get; set; }
        public string Ponuda2_odabrana { get; set; }
        public int Project { get; set; } // proj id
        public string Project_name { get; set; } // proj name
        public string Project_leader { get; set; } // proj leader id
        public string Bookkeeping { get; set; } // bookkeeper id
        public string Vice_dean { get; set; } // vicedean id

        public override string ToString() {
            return Financing;
            //return Applicant + " zahtjeva " + ID + ": " + Rqst_description + ", status: " + Status;
        }

    }
}
