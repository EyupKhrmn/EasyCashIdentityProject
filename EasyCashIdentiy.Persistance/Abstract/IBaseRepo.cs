using System.ComponentModel.Design;

namespace EasyCashIdentiy.Persistance.Abstract;

public interface IBaseRepo<T> where T : class
{
    void Insert(T t);
    void delete(T t);
    void Update(T t);
    T GetById(int id);
    List<T> GetAll();
}