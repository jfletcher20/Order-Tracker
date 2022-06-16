using DBLayer;
using OrderTracker.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTracker.Repositories {
    public class OrderRepository {
        public static Request GetOrder(Request request) {

            Request rqst = null;
            string sql = $"SELECT * FROM Requests WHERE ID = { request.ID }";
            
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            if (reader.HasRows) {
                reader.Read();
                rqst = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return rqst;

        }

        public static List<Request> GetEvaluations(Request request) {

            List<Request> requests = new List<Request>();

            string sql = $"SELECT * FROM Requests WHERE ID = {request.ID}";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read()) {
                Request rqst = CreateObject(reader);
                requests.Add(rqst);
            }

            reader.Close();
            DB.CloseConnection();

            return requests;

        }

        private static Request CreateObject(SqlDataReader reader) {

            int requestID = int.Parse(reader["ID"].ToString());
            var request = RequestRepository.GetRequest(requestID);
/*
            int idStudents = int.Parse(reader["IdStudents"].ToString());
            var student = StudentRepository.GetStudent(idStudents);

            int idTeachers = int.Parse(reader["IdTeachers"].ToString());
            var teacher = EmployeeRepository.GetEmployee(idTeachers);*/

            /*DateTime evaluationDate = DateTime.Parse(reader["EvaluationDate"].ToString());
            int points = int.Parse(reader["Points"].ToString());*/

            var req = new Request {
                /*Activity = activity,
                Student = student,
                Evaluator = teacher,
                EvaluationDate = evaluationDate,
                Points = points*/
                ID = requestID,
                /*Applicant = applicant,
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
                Vice_dean = vice_dean*/
            };

            return req;
        }

        public static void InsertRequest(Request request, Employee employee) {
            string sql = $"INSERT INTO Requests VALUES ('{new Random().Next(10, 1000000000)}', '{employee.Id}', '{request.Financing}'," +
                $"'{request.Status}', '{request.Bookkeeping}', '{request.Vice_dean}'," +
                $"'{request.Project_leader}', '{request.Project}', '{request.Project_name}'," +
                $"'{request.Financing_description}', '{request.Ponuda1_s_pdv}'," +
                $"'{request.Ponuda2_s_pdv}', '{request.Ponuda1_bez_pdv}'," +
                $"'{request.Ponuda2_bez_pdv}', '{request.Ponuda1_odabrana}'," +
                $"'{request.Ponuda2_odabrana}', {request.Rqst_description}";
            DB.SetConfiguration("jfletcher20_DB", "jfletcher20", "0%{m^oqc");
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void UpdateRequest(Request request, Employee employee) {
            string sql = $"UPDATE Requests SET applicant='{employee.Id}', financing='{request.Financing}'," +
                $"status='{request.Status}', bookkeeping='{request.Bookkeeping.ToString()}', vice_dean='{request.Vice_dean}'," +
                $"project_leader='{request.Project_leader}', project_ID='{request.Project}', project_name='{request.Project_name}'," +
                $"financing_description='{request.Financing_description}', ponuda1_s_pdv='{request.Ponuda1_s_pdv}'," +
                $"ponuda2_s_pdv='{request.Ponuda2_s_pdv}', ponuda1_bez_pdv='{request.Ponuda1_bez_pdv}'," +
                $"ponuda2_bez_pdv='{request.Ponuda2_bez_pdv}', ponuda1_odabrana='{request.Ponuda1_odabrana}'," +
                $"ponuda2_odabrana='{request.Ponuda2_odabrana}', rqst_description='{request.Rqst_description.ToString()}'" +
                $"WHERE ID = {request.ID}";
            DB.SetConfiguration("jfletcher20_DB", "jfletcher20", "0%{m^oqc");
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

    }
}
