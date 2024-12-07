namespace MedicinePrescription;

internal class MedicalBot
{
    private const string BotName = "Bob";

    public static string GetBotName() => BotName;

    internal void PrescribeMedication(Patient patient)
    {
        string symptom = patient.GetSymptoms();

        switch (symptom)
        {
            case "Headache":
                patient.SetPrescription("Ibuprofen"); break;
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
        Console.WriteLine($"\nYour prescription based on your age, symptoms, and medical history:");
        Console.WriteLine($"{patient.GetPrescription()} {dosage}.");

        string GetDosage(string medicineName)
        {
            int age = patient.GetAge();

            return medicineName.ToLower() switch
            {
                "ibuprofen" => age < 18 ? "400 mg" : "800 mg",
                "diphenhydramine" => age < 18 ? "50 mg" : "300 mg",
                "dimenhydrinate" => age < 18 ? "50 mg" : "400 mg",
                "metformin" => "500 mg",
                _ => "Unknown dosage"
            };
        }
    }
}

