using DBLayer;
using OrderTracker.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTracker.Repositories {

    public class RequestRepository {

        public static Request GetRequest(int id) {

            Request request = null;
            string sql = $"SELECT * FROM Requests WHERE Id = {id}";

            DB.SetConfiguration("jfletcher20_DB", "jfletcher20", "0%{m^oqc");

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            if (reader.HasRows) {
                reader.Read();
                request = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();

            return request;

        }

        public static List<Request> GetRequests() {

            List<Request> requests = new List<Request>();
            string sql = "SELECT * FROM Requests";

            DB.SetConfiguration("jfletcher20_DB", "jfletcher20", "0%{m^oqc");

            DB.OpenConnection();

            var reader = DB.GetDataReader(sql);

            while (reader.Read()) {
                Request activity = CreateObject(reader);
                requests.Add(activity);
            }

            reader.Close();
            DB.CloseConnection();

            return requests;

        }

        private static Request CreateObject(SqlDataReader reader) {

            /*int id = int.Parse(reader["Id"].ToString());
            string name = reader["Name"].ToString();
            string description = reader["Description"].ToString();
            int maxPoints = int.Parse(reader["MaxPoints"].ToString());
            int minPointsForGrade = int.Parse(reader["MinPointsForGrade"].ToString());
            int minPointsForSignature = int.Parse(reader["MinPointsForSignature"].ToString());*/
            int id = int.Parse(reader["ID"].ToString());
            string status = reader["status"].ToString();
            int applicant = int.Parse(reader["applicant"].ToString());
            string rqst_description = reader["rqst_description"].ToString();
            string financing = reader["financing"].ToString();
            string financing_description = reader["financing_description"].ToString();
            int offer1 = int.Parse(reader["offer1"].ToString());
            string offer1_description = reader["offer1_description"].ToString();
            int offer2 = int.Parse(reader["offer2"].ToString());
            string offer2_description = reader["offer2_description"].ToString();
            int project = int.Parse(reader["project_ID"].ToString());
            string project_name = reader["project_name"].ToString();
            int project_leader = int.Parse(reader["project_leader"].ToString());
            int bookkeeping = int.Parse(reader["bookkeeping"].ToString());
            int vice_dean = int.Parse(reader["vice_dean"].ToString());

            var request = new Request {
                /*Id = id,
                Name = name,
                Description = description,
                MaxPoints = maxPoints,
                MinPointsForGrade = minPointsForGrade,
                MinPointsForSignature = minPointsForSignature*/
                ID = id,
                Applicant = applicant,
                Status = status,
                Rqst_description = rqst_description,
                Financing = financing,
                Financing_description = financing_description,
                Offer1 = offer1,
                Offer1_description = offer1_description,
                Offer2 = offer2,
                Offer2_description = offer2_description,
                Project = project,
                Project_name = project_name,
                Project_leader = project_leader,
                Bookkeeping = bookkeeping,
                Vice_dean = vice_dean
            };

            return request;

        }
    }
}
