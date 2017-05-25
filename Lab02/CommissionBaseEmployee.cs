namespace Lab02
{
    public class CommissionBaseEmployee : CommissionEmployee
    {
        #region Properties
        public decimal SalaryBase { get; set; }
        #endregion

        #region Constructor
        public CommissionBaseEmployee(string id, string firstName, string lastName,
            double commissionPercentaje, decimal sales, decimal salaryBase) :
            base(id, firstName, lastName, commissionPercentaje, sales)
        {
            SalaryBase = salaryBase;
        }
        #endregion

        #region Methods
        public override decimal GetSalary()
        {
            return base.GetSalary() + SalaryBase;
        }

        public override string ToString()
        {
            return string.Format(@"{0}
                % Commision...:  {1,18:P2}
                Base..........: {2,18:C2}
                Sales.........: {3,18:C2}
                Salary........: {4,18:C2}",
                string.Format("{0} {1}", FirstName, LastName), CommissionPercentaje, SalaryBase, Sales, GetSalary());
        }
        #endregion
    }
}
