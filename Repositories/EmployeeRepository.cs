using DBLayer;
using OrderTracker.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTracker.Repositories {

    public class EmployeeRepository {
        public static Employee GetEmployee(string email) {
            string sql = $"SELECT * FROM Employees WHERE email = '{email}'";
            return FetchEmployee(sql);
        }

        public static Employee GetEmployee(int id) {
            string sql = $"SELECT * FROM Employees WHERE Id = {id}";
            return FetchEmployee(sql);
        }

        private static Employee FetchEmployee(string sql) {

            DB.SetConfiguration("jfletcher20_DB", "jfletcher20", "0%{m^oqc");

            DB.OpenConnection();

            var reader = DB.GetDataReader(sql);
            Employee employee = null;

            if (reader.HasRows == true) {
                reader.Read();
                employee = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();

            return employee;
        }

        private static Employee CreateObject(SqlDataReader reader) {

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

    }
}
