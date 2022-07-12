using DoctorManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorManagement.Domain.Aggregates.DoctorAggregate
{
    public class Consultant : EntityBase, IAggregateRoot
    {
        public virtual int PatientId { get; private set; }
        public virtual int DoctorId { get; private set; }
        public virtual string Diagnosis { get; private set; }
        public virtual string Treatment { get; private set; }
        public virtual string Prescription { get; private set; }
        public virtual string Problem { get; private set; }

        public Consultant(int patientId, int doctorId, string diagnosis, string treatment, string prescription, string problem)
        {
            this.PatientId = patientId;
            this.DoctorId = doctorId;
            this.Diagnosis = diagnosis;
            this.Treatment = treatment;
            this.Prescription = prescription;
            this.Problem = problem;
        }

        protected Consultant() { }
    }
}
