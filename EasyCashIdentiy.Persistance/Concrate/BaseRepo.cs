using EasyCashIdentiy.Persistance.Abstract;
using EasyCashIdentiy.Persistance.Context;
using Microsoft.AspNetCore.Identity;

namespace EasyCashIdentiy.Persistance.Concrate;

public class BaseRepo<T> : IBaseRepo<T> where T : class
{
    private readonly ProjectContext _context;

    public BaseRepo(ProjectContext context)
    {
        _context = context;
    }

    public void Insert(T t)
    {
        using (_context)
        {
            _context.Set<T>().Add(t);
            _context.SaveChanges();
        }
    }

    public void delete(T t)
    {
        using (_context)
        {
            _context.Set<T>().Remove(t);
            _context.SaveChanges();
        }
    }

    public void Update(T t)
    {
        using (_context)
        {
            _context.Set<T>().Update(t);
        }
    }

    public T GetById(int id)
    {
        using (_context)
        {
            var response = _context.Set<T>().Find(id);
            return response;
        }
    }

    public List<T> GetAll()
    {
        using (_context)
        {
            List<T> response = _context.Set<T>().ToList();
            return response;
        }
    }
}