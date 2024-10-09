namespace Personal_Financial_Dashboard.Model.Domain
{
    public class Accounts
    {
        public Guid AccountId { get; set; }
        public Guid UderId { get; set; }
        public string AccountName { get; set; }
        public string AccountType { get; set; }
        public int Balance { get; set; }

        public DateTime datetime { get; set; }

    }
}
