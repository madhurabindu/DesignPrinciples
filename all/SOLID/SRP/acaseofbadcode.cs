using System;

namespace HMS{

    public class PatientBadcode
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Diagnosis { get; set; }
        public double BillAmount { get; set; }

        public void PrintPatientDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Diagnosis: {Diagnosis}");
        }

        public void FindDiagnosis(int temperature, int pulse, int bloodPressure)
        {
            if (temperature > 100)
            {
                Diagnosis = "Flu";
            }
            else if (pulse > 100)
            {
                Diagnosis = "Cardiac";
            }
            else if (bloodPressure > 140)
            {
                Diagnosis = "High BP";
            }
            else
            {
                Diagnosis = "Healthy";
            }
        }
        public void CalculateBill()
        {
            // Simplified billing logic
            if (Diagnosis == "Healthy")
            {
                BillAmount = 100;
            }
            else if (Diagnosis == "Cardiac")
            {
                BillAmount = 500;
            }
            else
            {
                BillAmount = 200;
            }
        }

        public void PrintBill()
        {
            Console.WriteLine($"Patient: {Name}");
            Console.WriteLine($"Bill Amount: {BillAmount}");
        }
    }
}
