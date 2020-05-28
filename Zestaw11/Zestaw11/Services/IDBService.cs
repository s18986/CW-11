using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zestaw11.Models;

namespace Zestaw11.Services
{
    public interface IDBService
    {
        public IEnumerable<Doctor> GetDoctors();
        public void AddDoctor(DTO.Responses.AddNewDoctorResponse response);
        public void UpdateDoctor(Doctor doc);
        public void DeleteDoctor(Doctor doc);
    }
}
