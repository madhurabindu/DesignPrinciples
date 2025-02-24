namespace HMS{
    public class Billing
    {
        public void CalculateBill(Billing bill)
        {
            // Simplified billing logic
            if (bill.Diagnosis == "Healthy")
            {
                bill.BillAmount = 100;
            }
            else if (bill.Diagnosis == "Cardiac")
            {
                bill.BillAmount = 500;
            }
            else
            {
                bill.BillAmount = 200;
            }
        }

    }
}