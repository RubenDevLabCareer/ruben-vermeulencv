using System;
namespace CvBlazor.Repositories
{
    public interface IJsonRepository<T>
    {
        public Task<IEnumerable<T>> Get(); 
    }
}