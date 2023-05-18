﻿namespace EasyCashIdentity.Domain.Entites;

public class CustomerAccount
{
    public int CustomerAccountId { get; set; }
    public string CustomerAccountNumber { get; set; }
    public string CustomerAccountCurrency { get; set; }
    public decimal CustomerAccountBalance { get; set; }
    public string BankBranch { get; set; }
    public int AppUserId { get; set; }
    public AppUser AppUser { get; set; }
}