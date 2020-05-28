using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zestaw11.DTO.Requests;
using Zestaw11.DTO.Responses;
using Zestaw11.Models;
using Zestaw11.Services;

namespace Zestaw11.Controllers
{
    [Route("api/Doctors")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IDBService _DbService;
        private readonly  MyDbContext Context;

        // public DoctorsController(IDBService service)
        //{
        //    _DbService = service;
        // }
        public DoctorsController(MyDbContext context)
        {
            Context = context;
            _DbService = new entityFrameworkDBService(context);
        }

        [HttpGet]
        public IActionResult getDoctors()
        {
            return Ok(_DbService.GetDoctors().ToList());
        }
        [HttpPost]
        public IActionResult addDoctor(AddNewDoctorRequest request)
        {
            DTO.Responses.AddNewDoctorResponse response = new AddNewDoctorResponse();
            response.Id = _DbService.GetDoctors().Count();
            response.LastName = request.LastName;
            response.FirstName = request.FirstName;
            response.Email = request.Email;
            _DbService.AddDoctor(response);

            return Ok("Dodano lekarza jakim jest: "+response.FirstName+" "+response.LastName);
        }
        [HttpDelete]
        public IActionResult deleteDoctor(DeleteDoctorRequest request)
        {
            Doctor doc = new Doctor();
            doc.Id = request.Id;
            doc.FirstName = request.FirstName;
            doc.LastName = request.LastName;

            _DbService.DeleteDoctor(doc);
            return Ok("Usunieto lekarza jakim jest: " + doc.FirstName + " " + doc.LastName);
        }
        [HttpPost]
        public IActionResult updateDoctor(Doctor doc)
        {
            _DbService.UpdateDoctor(doc);
            return Ok();
        }
    }
}
