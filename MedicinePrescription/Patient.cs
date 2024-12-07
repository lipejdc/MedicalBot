namespace MedicinePrescription;

internal class Patient
{
    private string? _name;
    private int _age;
    private string? _gender;
    private string? _medicalHistory;
    private string? _symptomCode;
    private string? _prescription;

    internal string GetName() => _name!;

    internal bool SetName(string name, out string errorMessage)
    {
        if (!String.IsNullOrEmpty(name) && name.Length >= 2)
        {
            _name = name;
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

    internal int GetAge() => _age;

    internal bool SetAge(int age, out string errorMessage)
    {
        if (age >= 0 && age <= 100)
        {
            _age = age;
            errorMessage = String.Empty;
            return true;
        }

        errorMessage = "Invalid age! " +
    "The patient's age can't be negative and greater than 100!";
        return false;
    }

    internal string GetGender() => _gender!;

    internal bool SetGender(string gender, out string errorMessage)
    {
        if (gender.ToLower() == "male" || gender.ToLower() == "female" || gender.ToLower() == "other")
        {
            _gender = gender;
            errorMessage = String.Empty;
            return true;
        }

        errorMessage = $"Invalid gender!" +
                    $"Patient gender must be either \"Male\", \"Female\" or \"Other!\"";
        return false;
    }

    internal string GetMedicalHistory() => _medicalHistory!;

    internal void SetMedicalHistory(string medicalHistory) => _medicalHistory = medicalHistory;

    internal bool SetSymptomCode(string symptomCode, out string errorMessage)
    {
        if (symptomCode.ToUpper() == "S1" || symptomCode.ToUpper() == "S2" || symptomCode.ToUpper() == "S3")
        {
            _symptomCode = symptomCode;
            errorMessage = String.Empty;
            return true;
        }

        errorMessage = "Invalid code! Symptom code should be either 'S1', 'S2', or 'S3'.";
        return false;
    }

    internal string GetSymptoms()
    {
        return _symptomCode!.ToUpper() 
        switch
        {
            "S1" => "Headache",
            "S2" => "Skin rashes",
            "S3" => "Dizziness",
            _ => "Unknown"
        };
    }

    internal string GetPrescription() => _prescription!;

    internal void SetPrescription(string prescription) => _prescription = prescription;
}

