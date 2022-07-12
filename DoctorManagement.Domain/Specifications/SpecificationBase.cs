using DoctorManagement.Domain.Aggregates;
using DoctorManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DoctorManagement.Domain.Specifications
{
    public abstract class SpecificationBase<T> where T : EntityBase, IAggregateRoot
    {
        public abstract Expression<Func<T, bool>> ToExpression();
        public List<string> Includes { get; } = new List<string>();
    }
}
