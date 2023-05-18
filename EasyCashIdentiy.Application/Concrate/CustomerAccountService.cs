using EasyCashIdentity.Domain.Entites;
using EasyCashIdentiy.Application.Abstract;
using EasyCashIdentiy.Persistance.Abstract;

namespace EasyCashIdentiy.Application.Concrate;

public class CustomerAccountService : ICustomerAccountService
{
    private readonly ICustomerAccountRepo _customerAccountRepo;

    public CustomerAccountService(ICustomerAccountRepo customerAccountRepo)
    {
        _customerAccountRepo = customerAccountRepo;
    }

    public void SInsert(CustomerAccount t)
    {
        _customerAccountRepo.Insert(t);
    }

    public void Sdelete(CustomerAccount t)
    {
        _customerAccountRepo.delete(t);
    }

    public void SUpdate(CustomerAccount t)
    {
        _customerAccountRepo.Update(t);
    }

    public CustomerAccount SGetById(int id)
    {
        return _customerAccountRepo.GetById(id);
    }

    public List<CustomerAccount> SGetAll()
    {
        List<CustomerAccount> response = _customerAccountRepo.GetAll();
        return response;
    }
}