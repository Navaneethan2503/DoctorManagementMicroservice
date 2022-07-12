using DoctorManagement.API.Controllers;
using DoctorManagement.API.DTOs;
using DoctorManagement.Domain.Aggregates.DoctorAggregate;
using DoctorManagement.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
//using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DoctorManagement.API.Tests
{
    [TestFixture]
    public class ConsultantControllerShould
    {
       /*
        [Test]
        public async Task SubmitDiagnosisTreatment_ReturnStatusCode200()
        {
            var report = new ConsultantDTO()
            {
                PatientId = 101,
                DoctorID = 1001,
                Diagnosis = "This is Diagnosis",
                Treatment = "This is Treatment",
                Prescription = "This is Prescription",
                Problem = "This is Problem"
            };
            var repo = new Mock<IRepository<Consultant>>();
            repo.Setup(m => m.SaveAsync());
            var repoObj = repo.Object;

            var controller = new ConsultantController(repoObj);

            StatusCodeResult result = (StatusCodeResult)await controller.SubmitDiagnosisTreatment(report).ConfigureAwait(false);
            Assert.That(result.StatusCode, Is.EqualTo(201));
        }

        [Test]
        public void GetConsultantReport_ReturnStatusCode200()
        {
            int PatientId = 101;
            int DoctorID = 1001;
            string Diagnosis = "This is Diagnosis";
            string Treatment = "This is Treatment";
            string Prescription = "This is Prescription";
            string Problem = "This is Problem";
            var repo = new Mock<IRepository<Consultant>>();
            repo.Setup(m => m.Get()).Returns(() =>
            {
                Consultant report = new Consultant(PatientId, DoctorID, Diagnosis, Treatment, Prescription, Problem);
                return new List<Consultant>() { report };
            });
            var repoObj = repo.Object;
            var controller = new ConsultantController(repoObj);
            var result = (IStatusCodeActionResult)controller.GetConsultantReports();
            Assert.That(result.StatusCode, Is.EqualTo(200));
            Assert.IsNotNull(result);
        }
       */
    
    }
}
