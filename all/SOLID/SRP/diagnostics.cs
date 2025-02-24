namespace HMS{
    public class Diagnostics
    {
        public string FindDiagnosis(int temperature, int pulse, int bloodPressure)
        {
            string diagnosis;
            if (temperature > 100)
            {
               diagnosis = "Flu";
            }
            else if (pulse > 100)
            {
                diagnosis = "Cardiac";
            }
            else if (bloodPressure > 140)
            {
                diagnosis = "High BP";
            }
            else
            {
                diagnosis = "Healthy";
            }

            return diagnosis
        }
    }
}