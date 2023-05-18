using EasyCashIdentity.Domain.Entites;
using EasyCashIdentiy.Application.Abstract;
using EasyCashIdentiy.Persistance.Abstract;

namespace EasyCashIdentiy.Application.Concrate;

public class CustomerAccountProcessService : ICustomerAccountProcessService
{
    private readonly ICustomerAccountProcessRepo _customerAccountProcessRepo;

    public CustomerAccountProcessService(ICustomerAccountProcessRepo customerAccountProcessRepo)
    {
        _customerAccountProcessRepo = customerAccountProcessRepo;
    }

    public void SInsert(CustomerAccountProcess t)
    {
        _customerAccountProcessRepo.Insert(t);
    }

    public void Sdelete(CustomerAccountProcess t)
    {
        _customerAccountProcessRepo.delete(t);
    }

    public void SUpdate(CustomerAccountProcess t)
    {
        _customerAccountProcessRepo.Update(t);
    }

    public CustomerAccountProcess SGetById(int id)
    {
       return _customerAccountProcessRepo.GetById(id);
    }

    public List<CustomerAccountProcess> SGetAll()
    {
        List<CustomerAccountProcess> response = _customerAccountProcessRepo.GetAll();
        return response;
    }
}