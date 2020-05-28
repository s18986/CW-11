using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zestaw11.DTO.Responses;

namespace Zestaw11.Models
{
    public class Doctor
    {
        public Doctor()
        {

        }
        public Doctor(AddNewDoctorResponse response)
        {
            this.Email = response.Email;
            this.FirstName = response.FirstName;
            this.LastName = response.LastName;
            this.Id = response.Id;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email {get; set;}
        public ICollection<Prescription> Prescriptions { get; set; }

    }
}
