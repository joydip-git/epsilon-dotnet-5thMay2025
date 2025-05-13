namespace PayrollApp.Entities
{
    public class Developer : Employee
    {
        #region Data Members
        decimal incentivePay;
        #endregion

        #region Constructors
        public Developer()
        {

        }

        //optional argument with default value
        public Developer(int id, string name = null, decimal basicPay = 0, decimal daPay = 0, decimal hraPay = 0, decimal incentivePay = 0) : base(id, name, basicPay, daPay, hraPay)
        {
            this.incentivePay = incentivePay;
        }
        #endregion

        #region Properties
        public decimal IncentivePay
        {
            get => incentivePay;
            set => incentivePay = value;
        }
        #endregion

        #region Methods
        public override void CalculateSalary()
        {
            base.CalculateSalary();
            TotalPay += incentivePay;
        }
        #endregion
    }
}
