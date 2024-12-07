namespace MedicinePrescription;

internal class Patient
{
    private string? Name;
    private int Age;
    private string? Gender;
    private string? MedicalHistory;
    private string? SymptomCode;
    private string? Prescription;

    internal string GetName()
    {
        return Name!;
    }

    internal bool SetName(string name, out string errorMessage)
    {
        if (!String.IsNullOrEmpty(name) && name.Length >= 2)
        {
            Name = name;
            errorMessage = String.Empty;
            return true;
        }

        else
        {
            errorMessage = "Invalid name! The patient's name can't be null or empty! " +
                "It should contain at least two or more characters!";
            return false;
        }

    }

    internal int GetAge()
    {
        return Age;
    }

    internal bool SetAge(int age, out string errorMessage)
    {
        if (age >= 0 && age <= 100)
        {
            Age = age;
            errorMessage = String.Empty;
            return true;
        }

        else
        {
            errorMessage = "Invalid age! " +
                "The patient's age can't be negative and greater than 100!";
            return false;
        }
    }

    internal string GetGender()
    {
        return Gender!;
    }

    internal bool SetGender(string gender, out string errorMessage)
    {
        switch (gender.ToLower())
        {
            case "male":
                Gender = "Male";
                errorMessage = String.Empty;
                return true;

            case "female":
                Gender = "Female";
                errorMessage = String.Empty;
                return true;

            case "other":
                Gender = "Other";
                errorMessage = String.Empty;
                return true;

            default:
                errorMessage = $"Invalid gender!" +
                    $"Patient gender must be either \"Male\", \"Female\" or \"Other!\"";
                return false;
        }
    }

    internal string GetMedicalHistory()
    {
        return MedicalHistory!;
    }

    internal void SetMedicalHistory(string medicalHistory)
    {
        MedicalHistory = medicalHistory;
    }

    internal bool SetSymptomCode(string symptomCode, out string errorMessage)
    {
        switch (symptomCode.ToUpper())
        {
            case "S1":
                SymptomCode = symptomCode;
                errorMessage = String.Empty;
                return true;
            case "S2":
                SymptomCode = symptomCode;
                errorMessage = String.Empty;
                return true;
            case "S3":
                SymptomCode = symptomCode;
                errorMessage = String.Empty;
                return true;
            default:
                errorMessage = "Invalid code! Symptom Code should either be 'S1', 'S2', or 'S3'";
                return false;
        }
    }

    internal string GetSymptoms()
    {
        string symptom;

        switch (SymptomCode!.ToUpper())
        {
            case "S1":
                symptom = "Headache"; break;
            case "S2":
                symptom = "Skin rashes"; break;
            case "S3":
                symptom = "Dizziness"; break;
            default:
                symptom = "unknown"; break;
        }

        return symptom;
    }

    public string GetPrescription()
    {
        return Prescription!;
    }

    public void SetPrescription(string prescription)
    {
        Prescription = prescription;

    }
}

