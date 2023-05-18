namespace EasyCashIdentiy.Application.Abstract;

public interface IGenericService<T> where T : class
{
    void SInsert(T t);
    void Sdelete(T t);
    void SUpdate(T t);
    T SGetById(int id);
    List<T> SGetAll();
}