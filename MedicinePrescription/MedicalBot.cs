namespace MedicinePrescription;

internal class MedicalBot
{
    private const string BotName = "Bob";

    public static string GetBotName()
    {
        return BotName;
    }

    internal void PrescribeMedication(Patient patient)
    {
        string symptom = patient.GetSymptoms();

        switch (symptom)
        {
            case "Headache":
                patient.SetPrescription($"Ibuprofen"); break;
            case "Skin rashes":
                patient.SetPrescription("Diphenhydramine"); break;
            case "Dizziness":
                if (patient.GetMedicalHistory() == "Diabetes")
                {
                    patient.SetPrescription("Metformin");
                }
                else
                {
                    patient.SetPrescription("Dimenhydrinate");
                }
                break;

        }

        string medicineName = patient.GetPrescription();
        string dosage = GetDosage(medicineName);
        Console.WriteLine($"Your prescription based on your age, symptoms, and medical history:");
        Console.WriteLine($"{patient.GetPrescription()} {dosage}.");

        string GetDosage(string medicineName)
        {
            string dosage;

            switch (medicineName)
            {
                case "Ibuprofen":
                    dosage = patient.GetAge() < 18 ? "400 mg" : "800 mg"; break;

                case "Diphenhydramine":
                    dosage = patient.GetAge() < 18 ? "50 mg" : "300 mg"; break;

                case "Dimenhydrinate":
                    dosage = patient.GetAge() < 18 ? "50 mg" : "400 mg"; break;

                case "Metformin":
                    dosage = "500 mg"; break;

                default:
                    dosage = "Unknown dosage"; break;
            }

            return dosage;
        }
    }
}

