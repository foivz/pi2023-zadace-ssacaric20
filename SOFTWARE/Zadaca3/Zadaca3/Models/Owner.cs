using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadaca3.Repositories;

namespace Zadaca3.Models
{
    public class Owner : Person
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public void CheckWorker(Worker worker, string name, string surname, string email, string cnumber, string iban, int hourly)
        {
            if (worker == null)
            {
                WorkerRepository.InsertWorker(name, surname, email, cnumber, iban, hourly);
            } else
            {
                WorkerRepository.UpdateWorker(worker, name, surname, email, cnumber, iban, hourly);
            }
        }
        public void DeleteWorker(int selectedWorker)
        {
            WorkerRepository.DeleteWorker(selectedWorker);
        }
    }
}
