namespace EasyCashIdentity.Domain.Entites;

public class CustomerAccountProcess
{
    public int CustomerAccountProcessId { get; set; }
    public int ProcessType { get; set; }
    public decimal Amount { get; set; }
    public DateTime ProcessDate { get; set; }
    
}