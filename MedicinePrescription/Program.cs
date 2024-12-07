using MedicinePrescription;

Console.WriteLine($"Hi, I'm { MedicalBot.GetBotName() }. I'm here to help you in your medication. \n");

string errorMessage;
Patient patient1 = new();
MedicalBot medicalBot = new();

while (true)
{
    Console.Write("Enter your name: \n");
    string name = Console.ReadLine()!;
    if (patient1.SetName(name, out errorMessage)) break;
    Console.WriteLine(errorMessage);
}

while (true)
{
    Console.Write("Enter your age: \n");
    int age = Convert.ToInt32(Console.ReadLine());
    if (patient1.SetAge(age, out errorMessage)) break;
    Console.WriteLine(errorMessage);
}

while (true)
{
    Console.Write("Enter your gender: \n");
    string gender = Console.ReadLine()!;
    if (patient1.SetGender(gender, out errorMessage)) break;
    Console.WriteLine(errorMessage);
}

Console.Write("Enter your medical history. Eg: Diabetes. Press 'Enter' for none: \n");
string medicalHistory = Console.ReadLine()!;
patient1.SetMedicalHistory(string.IsNullOrWhiteSpace(medicalHistory) ? "None" : medicalHistory);
Console.WriteLine($"\nWelcome { patient1.GetName() }, { patient1.GetAge() }.\n");
Console.WriteLine("Which of the following symptoms do you have: S1. Headache S2. Skin rashes S3. Dizziness?");

while (true)
{
    Console.Write("Enter your symptom: \n");
    string symptomCode = Console.ReadLine()!;
    Console.WriteLine();
    if (patient1.SetSymptomCode(symptomCode, out errorMessage)) break; 
    Console.WriteLine(errorMessage);
}

medicalBot.PrescribeMedication(patient1);
Console.WriteLine("\nThank you for coming!");