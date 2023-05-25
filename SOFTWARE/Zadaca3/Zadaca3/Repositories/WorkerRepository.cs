using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Zadaca3.Models;

namespace Zadaca3.Repositories
{
    public class WorkerRepository
    {
        public static Worker GetWorker(int id)
        {
            Worker worker = null;

            string sql = $"SELECT * FROM Workers WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                worker = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return worker;
        }

        public static List<Worker> GetWorkers()
        {
            var workers = new List<Worker>();

            string sql = "SELECT * FROM Workers";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Worker worker = CreateObject(reader);
                workers.Add(worker);
            }

            reader.Close();
            DB.CloseConnection();

            return workers;
        }

        private static Worker CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string name = reader["Name"].ToString();
            string surname = reader["Surname"].ToString();
            string email = reader["Email"].ToString();
            string cnumber = reader["Cnumber"].ToString();
            string iban = reader["IBAN"].ToString();
            int hourly = int.Parse(reader["Hourly"].ToString());

            var worker = new Worker
            {
                Id = id,
                Name = name,
                Surname = surname,
                Email = email,
                Cnumber = cnumber,
                IBAN = iban,
                Hourly = hourly
            };

            return worker;
        }
        public static void InsertWorker(string name, string surname, string email, string cnumber, string iban, int hourly)
        {
            string sql = $"INSERT INTO Workers (Name, Surname, Email, Cnumber, IBAN, Hourly) VALUES ('" + name + "','" + surname + "','" + email + "','" + cnumber + "','" + iban + "','" + hourly + "')";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void UpdateWorker(Worker worker, string name, string surname, string email, string cnumber, string iban, int hourly)
        {
            string sql = $"UPDATE Workers SET Name = '{name}', Surname = '{surname}', Email = '{email}', Cnumber = '{cnumber}', IBAN = '{iban}', Hourly = {hourly} WHERE Id = {worker.Id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        public static void DeleteWorker(int selectedWorker)
        {
            string sql = $"DELETE FROM Workers WHERE Id= '" + selectedWorker + "' ";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
