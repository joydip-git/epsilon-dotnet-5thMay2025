namespace PayrollApp.Entities
{
    public class Hr : Employee
    {
        #region Data Members       
        decimal gratuityPay;
        #endregion

        #region Constructors
        public Hr()
        {

        }

        //optional argument with default value
        public Hr(int id, string name = null, decimal basicPay = 0, decimal daPay = 0, decimal hraPay = 0, decimal gratuityPay = 0) : base(id, name, basicPay, daPay, hraPay)
        {

            this.gratuityPay = gratuityPay;
        }
        #endregion

        #region Properties
        public decimal GratuityPay
        {
            get => gratuityPay;
            set => gratuityPay = value;
        }
        #endregion

        #region Methods
        public void CalculateSalary() => TotalPay = BasicPay + DaPay + HraPay + gratuityPay;
        #endregion
    }
}
