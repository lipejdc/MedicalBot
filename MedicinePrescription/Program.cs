using MedicinePrescription;

Console.WriteLine($"Hi, I'm { MedicalBot.GetBotName() }. I'm here to help you in your medication. \n");

string errorMessage;
Patient patient1 = new();

Console.Write("Enter your name: \n");
string name = Console.ReadLine()!;

while (!patient1.SetName(name, out errorMessage))
{
    Console.WriteLine(errorMessage);
    Console.Write("Enter your name: \n");
    name = Console.ReadLine()!;
}

Console.Write("Enter your age: \n");
int age = int.Parse(Console.ReadLine()!);

while (!patient1.SetAge(age, out errorMessage))
{
    Console.WriteLine(errorMessage);
    Console.Write("Enter your age: \n");
    age = int.Parse(Console.ReadLine()!);
}

Console.Write("Enter your gender: \n");
string gender = Console.ReadLine()!;

while (!patient1.SetGender(gender, out errorMessage))
{
    Console.WriteLine(errorMessage);
    Console.Write("Enter your gender: \n");
    gender = Console.ReadLine()!;
}

Console.Write("Enter your medical history. Eg: Diabetes. Press 'Enter' for none: \n");
string medicalHistory = Console.ReadLine()!;
patient1.SetMedicalHistory(String.IsNullOrWhiteSpace(medicalHistory) ? "None" : medicalHistory);

Console.WriteLine($"\nWelcome { patient1.GetName() }, { patient1.GetAge() }.\n");

Console.WriteLine("Which of the following symptoms do you have?");
Console.WriteLine("S1. Headache");
Console.WriteLine("S2. Skin rashes");
Console.WriteLine("S3. Dizziness");

Console.Write("Enter your symptom code: \n");
string symptomCode = Console.ReadLine()!;

while (!patient1.SetSymptomCode(symptomCode, out errorMessage))
{
    Console.WriteLine(errorMessage);
    Console.Write("Enter your symptom code from the above list (S1, S2 or S3): ");
    symptomCode = Console.ReadLine()!;
}

MedicalBot medicalBot = new();

medicalBot.PrescribeMedication(patient1);

Console.WriteLine("\nThank you for coming!");