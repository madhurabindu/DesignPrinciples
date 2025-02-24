namespace HMS{
    public class Printer
    {
        public void Print(Patient patient)
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Diagnosis: {Diagnosis}");
        }

        public void Print(Bill bill)
        {
            Console.WriteLine($"Patient: {bill.Name}");
            Console.WriteLine($"Diagnosis: {bill.Diagnosis}");
            Console.WriteLine($"Bill Amount: {bill.BillAmount}");
        }
    }
}