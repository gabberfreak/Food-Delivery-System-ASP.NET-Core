using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDeliverySystem.Services.Interfaces
{
    public interface IRepository<T>
    {
        T GetById(int id);
        T GetSingleBySpec(ISpecification<T> spec);
        IEnumerable<T> ListAll();
        IEnumerable<T> List(ISpecification<T> spec);
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
