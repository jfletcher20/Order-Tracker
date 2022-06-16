using DBLayer;
using OrderTracker.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTracker.Repositories {
    public class StudentRepository {

        /// <summary>
        /// Grabs a particular student via ID.
        /// </summary>
        /// <param name="id">ID of desired student.</param>
        /// <returns>Student student</returns>
        public static Student GetStudent(int id) {
            Student student = null;

            string sql = $"SELECT * FROM Students WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows) {
                reader.Read();
                student = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return student;
        }

        /// <summary>
        /// Grabs list of requests from the database.
        /// </summary>
        /// <returns>List of type "Request".</returns>
        public static List<Student> GetStudents() {
            var students = new List<Student>();

            string sql = "SELECT * FROM Students";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read()) {
                Student student = CreateObject(reader);
                students.Add(student);
            }

            reader.Close();
            DB.CloseConnection();

            return students;
        }

        private static Student CreateObject(SqlDataReader reader) {
            int id = int.Parse(reader["Id"].ToString());
            string firstName = reader["FirstName"].ToString();
            string lastName = reader["LastName"].ToString();
            int grade = int.Parse(reader["Grade"].ToString());

            var student = new Student {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Grade = grade
            };

            return student;
        }
    }
}
