using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zestaw11.Models;

namespace Zestaw11.Services
{
   
    public class entityFrameworkDBService : IDBService       
    {
        private readonly MyDbContext _dbContext;
        public entityFrameworkDBService(MyDbContext myDb)
        {
            _dbContext = myDb;
        }
        public IEnumerable<Doctor> GetDoctors()
        {
            return _dbContext.Doctors.ToList();
        }
        public void AddDoctor(DTO.Responses.AddNewDoctorResponse response)
        {
            Doctor doc = new Doctor();
            doc.FirstName = response.FirstName;
            doc.LastName = response.LastName;
            doc.Email = response.Email;
            _dbContext.Add(doc);
            _dbContext.SaveChanges();
          
        }

        public void DeleteDoctor(Doctor doc)
        {
            var doctor = _dbContext.Doctors.FirstOrDefault(doctor => doctor.Id == doc.Id);
            _dbContext.Remove(doctor);
            _dbContext.SaveChanges();
        }

        public void UpdateDoctor(Doctor doc)
        {
            var doctor = _dbContext.Doctors.FirstOrDefault(doctor => doctor.Id == doc.Id);
            doctor.Email = doc.Email;
            doctor.FirstName = doc.FirstName;
            doctor.LastName = doc.LastName;
            _dbContext.SaveChanges();
        }
    }
}
