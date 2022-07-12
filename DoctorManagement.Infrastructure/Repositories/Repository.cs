using DoctorManagement.Domain.Aggregates;
using DoctorManagement.Domain.Entities;
using DoctorManagement.Domain.Interfaces;
using DoctorManagement.Domain.Specifications;
using DoctorManagement.Infrastructure.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoctorManagement.Domain.Interfaces;

namespace DoctorManagement.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : EntityBase, IAggregateRoot
    {
        private readonly DoctorManagementContext context;

        public Repository(DoctorManagementContext context)
        {
            this.context = context;
        }

        public DoctorManagementContext Context => context;

        public T Add(T item)
        {
            return Context.Add(item).Entity;
        }

        public IReadOnlyCollection<T> Get()
        {
            var Data = Context.Set<T>().ToList();
            return Data.AsReadOnly();
        }

        public T GetById(long id)
        {
            return Context.Set<T>().Find(id);
        }

        public IReadOnlyCollection<T> GetBySpec(SpecificationBase<T> spec)
        {
            throw new NotImplementedException();
        }

        public T Remove(T item)
        {
            return Context.Remove(item).Entity;
        }

        public async Task<int> SaveAsync()
        {
            return await Context.SaveChangesAsync();
        }

        public T Update(T item)
        {
            return Context.Update(item).Entity;
        }
    }
}
