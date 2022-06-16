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

        public static void InsertRequest(Request current, Request activity, Employee teacher) {
            /*string sql = $"INSERT INTO Requests (IdActivities, IdStudents, IdTeachers, EvaluationDate, Points) VALUES ({activity.ID}, {current.ID}, {teacher.Id}, GETDATE(), {points})";
            DB.SetConfiguration("jfletcher20_DB", "jfletcher20", "0%{m^oqc");
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();*/
        }

        public static void UpdateRequest(Request request, Employee employee) {
            string sql = $"UPDATE Requests SET financing_description='Updated by {employee.Id}'";
            DB.SetConfiguration("jfletcher20_DB", "jfletcher20", "0%{m^oqc");
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

    }
}
