using System;

using FrontierCode.Enums;

namespace FrontierCode.Models
{
    public class AccountModel
    {
        private int accountStatusId = default(int);

        public int           Id              { get; set; }
        public string        FirstName       { get; set; }
        public string        LastName        { get; set; }
        public string        Email           { get; set; }
        public string        PhoneNumber     { get; set; }
        public double        AmountDue       { get; set; }
        public DateTime?     PaymentDueDate  { get; set; }
        public int           AccountStatusId { get { return accountStatusId; } set { AccountStatus = Enum.Parse<AccountStatus>((accountStatusId = value).ToString()); } }
        public AccountStatus AccountStatus   { get; private set; }
    }
}
