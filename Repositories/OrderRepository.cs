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

            Request request = null;
            string sql = $"SELECT * FROM Requests WHERE ID = { request.ID }";
            
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

        public static List<Order> GetEvaluations(Student student) {
            List<Order> orders = new List<Order>();

            string sql = $"SELECT * FROM Evaluations WHERE IdStudents = {student.Id}";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read()) {
                Order order = CreateObject(reader);
                orders.Add(order);
            }

            reader.Close();
            DB.CloseConnection();

            return orders;

        }

        private static Request CreateObject(SqlDataReader reader) {

            int requestID = int.Parse(reader["ID"].ToString());
            var request = RequestRepository.GetRequest(requestID);
/*
            int idStudents = int.Parse(reader["IdStudents"].ToString());
            var student = StudentRepository.GetStudent(idStudents);

            int idTeachers = int.Parse(reader["IdTeachers"].ToString());
            var teacher = EmployeeRepository.GetEmployee(idTeachers);*/

            DateTime evaluationDate = DateTime.Parse(reader["EvaluationDate"].ToString());
            int points = int.Parse(reader["Points"].ToString());

            var requeest = new Request {
                /*Activity = activity,
                Student = student,
                Evaluator = teacher,
                EvaluationDate = evaluationDate,
                Points = points*/
                ID = id,
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

            return request;
        }

        public static void InsertOrder(Request student, Request activity, Employee teacher, int points) {
            string sql = $"INSERT INTO Evaluations (IdActivities, IdStudents, IdTeachers, EvaluationDate, Points) VALUES ({activity.ID}, {student.ID}, {teacher.Id}, GETDATE(), {points})";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void UpdateOrder(Order evaluation, Employee teacher, int points) {
            string sql = $"UPDATE Evaluations SET IdTeachers = {teacher.Id},  Points = { points}, EvaluationDate = GETDATE() WHERE IdActivities = {evaluation.Activity.ID} AND IdStudents = { evaluation.Student.Id }";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

    }
}
