using DoctorManagement.API.DTOs;
using DoctorManagement.Domain.Aggregates.DoctorAggregate;
using DoctorManagement.Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultantController : ControllerBase
    {
        private readonly IRepository<Consultant> consultantRepository;

        public ConsultantController(IRepository<Consultant> consultantRepository)
        {
            this.consultantRepository = consultantRepository;
        }

        [HttpPost("SubmitDiagnosisTreatment")]
        [ProducesResponseType(201)]
        [Authorize(Roles = "Doctor")]
        public async Task<IActionResult> SubmitDiagnosisTreatment(ConsultantDTO dto)
        {
            try
            {
                var consultant = new Consultant(dto.PatientId, dto.DoctorID, dto.Diagnosis, dto.Treatment, dto.Prescription, dto.Problem);
                consultantRepository.Add(consultant);
                await consultantRepository.SaveAsync();
                return StatusCode(201);
            }
            catch
            {
                return StatusCode(500);
            }
        }

        [HttpGet("GetConsultantReports")]
        [ProducesResponseType(200, Type = typeof(List<ConsultantDTO>))]
        [AllowAnonymous]
        public async Task<IActionResult> GetConsultantReports()
        {
            try
            {
                var reports = consultantRepository.Get();
                var dtos = from report in reports
                           select new ConsultantDTO
                           {
                               Id = report.Id,
                               PatientId = report.PatientId,
                               DoctorID = report.DoctorId,
                               Diagnosis = report.Diagnosis,
                               Treatment = report.Treatment,
                               Prescription = report.Prescription,
                               Problem = report.Problem
                           };
                return Ok(dtos);
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}
