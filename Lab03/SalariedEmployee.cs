namespace Lab03
{
    public class SalariedEmployee : Employee
    {
        #region Properties
        public decimal Salary { get; set; }
        #endregion


        #region Methods
        public override decimal GetValueToPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            return string.Format(@"{0}
                Salary........: {1,18:C2}",
                base.ToString(), GetValueToPay());
        }
        #endregion
    }
}
