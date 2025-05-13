namespace PayrollApp.Entities
{
    public class Employee
    {
        #region Data Members
        readonly int id;
        string name;
        decimal basicPay;
        decimal daPay;
        decimal hraPay;
        decimal totalPay;
        public const string COMPANY_NAME = "Epsilon";
        static string departmentName = "ABCD";
        #endregion

        #region Constructors
        public Employee()
        {
            //departmentName = "XYZ";
        }

        //public Developer(int id) => this.id = id;

        //optional argument with default value
        public Employee(int id, string name = null, decimal basicPay = 0, decimal daPay = 0, decimal hraPay = 0)
        {
            this.id = id;
            this.name = name;
            this.basicPay = basicPay;
            this.daPay = daPay;
            this.hraPay = hraPay;
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

        //do not set the value of totalPay data member through constructor or property as it will be calculated in the CalculateSalary method
        public decimal TotalPay 
        { 
            get => totalPay; 
            protected set => totalPay = value; 
        }
        #endregion

        #region Methods
        public virtual void CalculateSalary() => totalPay = basicPay + daPay + hraPay;
        #endregion
    }
}
