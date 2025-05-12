namespace PayrollApp.Entities
{
    public class Developer
    {
        #region Data Members
        //every data member (As well as any other member too) is by default private to the class
        readonly int id;
        string name;
        decimal basicPay;
        decimal daPay;
        decimal hraPay;
        decimal incentivePay;
        decimal totalPay;
        public const string COMPANY_NAME = "Epsilon";
        static string departmentName = "ABCD";
        #endregion

        #region Constructors
        public Developer()
        {
            //departmentName = "XYZ";
        }

        //public Developer(int id) => this.id = id;

        //optional argument with default value
        public Developer(int id, string name = null, decimal basicPay = 0, decimal daPay = 0, decimal hraPay = 0, decimal incentivePay = 0)
        {
            this.id = id;
            this.name = name;
            this.basicPay = basicPay;
            this.daPay = daPay;
            this.hraPay = hraPay;
            this.incentivePay = incentivePay;
        }
        #endregion

        #region Properties
        public static string DepartmentName { set => departmentName = value; get => departmentName; }

        //since value of "id" data member, once assigned, should NOT be changed again, hence there is no set accessor and the id data member is marked with readonly
        public int Id => id;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public decimal BasicPay
        {
            get => basicPay;
            set => basicPay = value;
        }

        public decimal DaPay
        {
            get => daPay;
            set => daPay = value;
        }

        public decimal HraPay
        {
            get => hraPay;
            set => hraPay = value;
        }

        public decimal IncentivePay
        {
            get => incentivePay;
            set => incentivePay = value;
        }
        //do not set the value of totalPay data member through constructor or property as it will be calculated in the CalculateSalary method
        public decimal TotalPay => totalPay;
        #endregion

        #region Methods
        public void CalculateSalary() => totalPay = basicPay + daPay + hraPay + incentivePay;
        #endregion
    }
}
