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
                Request request = CreateObject(reader);
                requests.Add(request);
            }

            reader.Close();
            DB.CloseConnection();

            return requests;

        }

        public static List<Request> FilterRequests(List<Request> requests, string filter) {
            List<Request> filtered = new List<Request>();
            foreach (var item in requests) {
                if (item.Status.Contains(filter)) filtered.Add(item);
            }
            return filtered;
        }

        public static List<Request> FilterRequestsByFinancing(List<Request> requests, string filter) {
            List<Request> filtered = new List<Request>();
            foreach (var item in requests) {
                if (item.Financing.Contains(filter)) filtered.Add(item);
            }
            return filtered;
        }

        public static List<Request> GetRequestsByEmployee(Employee employee) {
            return GetRequestsByPermissions(employee);
        }

        public static List<Request> GetRequestsByPermissions(Employee employee) {
            switch(employee.Permissions) {
                case 1:
                    return GetRequestsHigher(employee, "Na putu.");
                case 2:
                    return GetRequestsHigher(employee, "Ceka na odobrenje od voditelja/ice projekta.");
                case 3:
                    return GetRequestsHigher(employee, "Ceka na odobrenje od voditelja/ice racunovodstva.");
                case 4:
                    return GetRequestsHigher(employee, "Ceka na odobrenje od prodekan/ice za poslovanje.");
                default:
                    return GetRequestsEmployee(employee);

            }
        }

        private static List<Request> GetRequestsEmployee(Employee employee) {

            List<Request> requests = new List<Request>();
            string sql = $"SELECT * FROM Requests WHERE applicant={employee.Id}";

            DB.SetConfiguration("jfletcher20_DB", "jfletcher20", "0%{m^oqc");

            DB.OpenConnection();

            var reader = DB.GetDataReader(sql);

            while (reader.Read()) {
                Request request = CreateObject(reader);
                requests.Add(request);
            }

            reader.Close();
            DB.CloseConnection();

            return requests;

        }

        private static List<Request> GetRequestsHigher(Employee employee, string status) {

            List<Request> requests = new List<Request>();
            string sql = $"SELECT * FROM Requests WHERE applicant={employee.Id} OR status='{status}'";

            DB.SetConfiguration("jfletcher20_DB", "jfletcher20", "0%{m^oqc");

            DB.OpenConnection();

            var reader = DB.GetDataReader(sql);

            while (reader.Read()) {
                Request request = CreateObject(reader);
                requests.Add(request);
            }

            reader.Close();
            DB.CloseConnection();

            return requests;

        }

        private static Request CreateObject(SqlDataReader reader) {

            int id = int.Parse(reader["ID"].ToString());
            string status = reader["status"].ToString();
            int applicant = int.Parse(reader["applicant"].ToString());
            string rqst_description = reader["rqst_description"].ToString();
            string financing = reader["financing"].ToString();
            string financing_description = reader["financing_description"].ToString();
            float ponuda1_bez_pdv = float.Parse(reader["ponuda1_bez_pdv"].ToString());
            float ponuda1_s_pdv = float.Parse(reader["ponuda1_s_pdv"].ToString());
            string ponuda1_odabrana = reader["ponuda1_odabrana"].ToString();
            float ponuda2_bez_pdv = float.Parse(reader["ponuda2_bez_pdv"].ToString());
            float ponuda2_s_pdv = float.Parse(reader["ponuda2_s_pdv"].ToString());
            string ponuda2_odabrana = reader["ponuda2_odabrana"].ToString();
            int project = int.Parse(reader["project_ID"].ToString());
            string project_name = reader["project_name"].ToString();
            string project_leader = reader["project_leader"].ToString();
            string bookkeeping = reader["bookkeeping"].ToString();
            string vice_dean = reader["vice_dean"].ToString();

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
                Ponuda1_bez_pdv = ponuda1_bez_pdv,
                Ponuda1_odabrana = ponuda1_odabrana,
                Ponuda1_s_pdv = ponuda1_s_pdv,
                Ponuda2_bez_pdv = ponuda2_bez_pdv,
                Ponuda2_odabrana = ponuda2_odabrana,
                Ponuda2_s_pdv = ponuda2_s_pdv,
                Project = project,
                Project_name = project_name,
                Project_leader = project_leader,
                Bookkeeping = bookkeeping,
                Vice_dean = vice_dean
            };

            return request;

        }

        public static void InsertRequest(string employeeID, string financing, string status, string bookkeeping,
            string vice_dean, string project_leader, string projectID, string project_name, string financing_description,
            string ponuda1_s_pdv, string ponuda2_s_pdv, string ponuda1_bez_pdv, string ponuda2_bez_pdv, string ponuda1_odabrana,
            string ponuda2_odabrana, string rqst_description, string requestID) {
            string sql = $"INSERT INTO Requests(ID, applicant, financing, status, bookkeeping, vice_dean, project_leader, project_ID, project_name, financing_description, ponuda1_s_pdv, ponuda1_bez_pdv, ponuda1_odabrana, ponuda2_s_pdv, ponuda2_bez_pdv, ponuda2_odabrana, rqst_description) " +
                $"VALUES ('{new Random().Next(10, 1000000000)}', '{employeeID}', '{financing}'," +
                $"'{status}', '{bookkeeping}', '{vice_dean}'," +
                $"'{project_leader}', '{projectID}', '{project_name}'," +
                $"'{financing_description}', '{ponuda1_s_pdv}'," +
                $"'{ponuda1_bez_pdv}', '{ponuda1_odabrana}'," +
                $"'{ponuda2_s_pdv}', '{ponuda2_bez_pdv}'," +
                $"'{ponuda2_odabrana}', '{rqst_description}')";
            DB.SetConfiguration("jfletcher20_DB", "jfletcher20", "0%{m^oqc");
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void UpdateRequest(string employeeID, string financing, string status, string bookkeeping,
            string vice_dean, string project_leader, string projectID, string project_name, string financing_description,
            string ponuda1_s_pdv, string ponuda2_s_pdv, string ponuda1_bez_pdv, string ponuda2_bez_pdv, string ponuda1_odabrana,
            string ponuda2_odabrana, string rqst_description, string requestID) {
            string sql = $"UPDATE Requests SET applicant='{employeeID}', financing='{financing}'," +
                $"status='{status}', bookkeeping='{bookkeeping}', vice_dean='{vice_dean}'," +
                $"project_leader='{project_leader}', project_ID='{projectID}', project_name='{project_name}'," +
                $"financing_description='{financing_description}', ponuda1_s_pdv='{ponuda1_s_pdv}'," +
                $"ponuda2_s_pdv='{ponuda2_s_pdv}', ponuda1_bez_pdv='{ponuda1_bez_pdv}'," +
                $"ponuda2_bez_pdv='{ponuda2_bez_pdv}', ponuda1_odabrana='{ponuda1_odabrana}'," +
                $"ponuda2_odabrana='{ponuda2_odabrana}', rqst_description='{rqst_description}'" +
                $"WHERE ID = {requestID}";
            DB.SetConfiguration("jfletcher20_DB", "jfletcher20", "0%{m^oqc");
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void DeleteRequest(Request request) {
            string sql = $"DELETE FROM Requests WHERE ID={request.ID}";
            DB.SetConfiguration("jfletcher20_DB", "jfletcher20", "0%{m^oqc");
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

    }
}
