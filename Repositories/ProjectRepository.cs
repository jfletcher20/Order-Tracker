using DBLayer;
using OrderTracker.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTracker.Repositories {

    public class ProjectRepository {
        public static Employee GetLeader(Project project) {
            string sql = $"SELECT * FROM Employees WHERE ID = '{project.Leader}'";
            return FetchEmployee(sql);
        }
        public static Project GetProject(int id) {
            string sql = $"SELECT * FROM Projects WHERE ID = '{id}'";
            return FetchProject(sql);
        }

        private static Employee FetchEmployee(string sql) {

            DB.SetConfiguration("jfletcher20_DB", "jfletcher20", "0%{m^oqc");

            DB.OpenConnection();

            var reader = DB.GetDataReader(sql);
            Employee employee = null;

            if (reader.HasRows == true) {
                reader.Read();
                employee = CreateEmployeeObject(reader);
                reader.Close();
            }

            DB.CloseConnection();

            return employee;
        }

        private static Project FetchProject(string sql) {

            DB.SetConfiguration("jfletcher20_DB", "jfletcher20", "0%{m^oqc");

            DB.OpenConnection();

            var reader = DB.GetDataReader(sql);
            Project project = null;

            if (reader.HasRows == true) {
                reader.Read();
                project = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();

            return project;
        }

        private static Employee CreateEmployeeObject(SqlDataReader reader) {

            int id = int.Parse(reader["ID"].ToString());
            string firstName = reader["name"].ToString();
            string lastName = reader["last_name"].ToString();
            string email = reader["email"].ToString();
            string password = reader["password"].ToString();
            int permissions = int.Parse(reader["permissions"].ToString());

            var employee = new Employee {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Password = password,
                Permissions = permissions
            };

            return employee;

        }

        private static Project CreateObject(SqlDataReader reader) {

            int id = int.Parse(reader["ID"].ToString());
            string name = reader["name"].ToString();
            int leader = int.Parse(reader["leader"].ToString());

            var project = new Project {
                ID = id,
                Name = name,
                Leader = leader
            };

            return project;

        }

    }
}
