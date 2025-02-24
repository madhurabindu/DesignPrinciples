
namespace HMS {
    
public class Program
{
    public static void Main(string[] args)
    {
        Patient patient = new Patient
        {
            Name = "John Doe",
            Age = 30,
            Address = "123 Main St",
        };

        Printer printer = new Printer();
        printer.Print(patient);
        
        Bill bill = new bill()
        bill.diagnosis = patient.FindDiagnosis(98, 80, 120);
        patient.Diagnosis = bill.diagnosis;
        
        Billing billing = new Billing();
        billing.CalculateBill(bill);
        
        printer.Print(bill);
    }
}
}