using System.Threading.Tasks;

public interface IRepository<T>
{
    public  Task<T> Create(T entity);
}