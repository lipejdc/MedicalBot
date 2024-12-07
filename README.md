# MedicalBot

## Assignment: Create a medical bot application
The application can prescribe medication based on the patient's symptoms and age.

Your task is to create a C# console application that simulates a medical bot named Bob. Bob should be able to prescribe medication based on the symptoms of a patient passed as an argument.

You should create two classes - MedicalBot and Patient - to implement this functionality.



## Part 1: MedicalBot class
The MedicalBot class should have a constant string variable named BotName with the value "Bob" that represents the name of the medical bot.
It should have a static method called GetBotName() that returns value of "BotName" constant.
The MedicalBot class should also have a method named PrescribeMedication() that takes a Patient object as an argument. The PrescribeMedication() method should determine the medication to prescribe based on the symptoms of the patient.

```C#
void PrescribeMedication(Patient patient)
```

If the patient's symptoms are a headache, prescribe ibuprofen.
If the patient's symptoms are skin rashes, prescribe diphenhydramine.
If the patient's symptoms are dizziness, check if the patient has a medical history of diabetes. If they do, prescribe metformin. Otherwise, prescribe dimenhydrinate.

The PrescribeMedication() method should invoke another local function called GetDosage() to specify dosage of the specified medicine.

```C#
string GetDosage(string medicineName)
```

The GetDosage() method receives he medicine name prescribed by the PrescribeMedication() method and returns corresponding dosage as follows:

If the medicine name is ibuprofen:
If the patient's age is less than 18, then the dosage is 400 mg. Otherwise, the dosage is 800 mg.

If the medicine name is diphenhydramine:
If the patient's age is less than 18, then the dosage is 50 mg. Otherwise, the dosage is 300 mg.

If the medicine name is dimenhydrinate:
If the patient's age is less than 18, then the dosage is 50 mg. Otherwise, the dosage is 400 mg.

If the medicine name is metformin, then the dosage is 500 mg for all patients.

## Part 2: Patient class
The Patient class should have the following fields:

**name:** A string representing the name of the patient.
**age:** An integer representing the age of the patient.
**gender:** A string representing the gender of the patient.
**medicalHistory:** A string representing the medical history of the patient.
**symptomCode:** A string representing the code for the symptoms of the patient.
**prescription:** A string representing the medication prescribed to the patient.

The Patient class should also have essential set / get methods for all the above fields. The Get methods returns the value of corresponding field. The Set methods should perform appropriate validation and assign the value into the field only if a valid value is supplied as argument. The Set methods should return a boolean value indicating whether the value is valid or not. If the value is valid, it should return true; otherwise false. In case of invalid value, an error message should be returned as "out" parameter. In case of valid value, an empty string should be returned as error message as "out" parameter.

**GetName():** Returns the name of the patient.

**SetName(string name, out string errorMessage):** Sets the name of the patient and validates it. Returns a bool indicating whether the name is valid or not, and an error message if it's invalid. The name should not be null or empty. Patient name should contain at least two or more characters.

**GetAge():** Returns the age of the patient.

**SetAge(int age, out string errorMessage):** Sets the age of the patient and validates it. Returns a bool indicating whether the age is valid or not, and an error message if it's invalid. Patient age can't be negative. Patient age can't be greater than 100.

**GetGender():** Returns the gender of the patient.

**SetGender(string gender, out string errorMessage):** Sets the gender of the patient and validates it. Returns a bool indicating whether the gender is valid or not, and an error message if it's invalid. Patient gender should be either Male, Female or Other

**GetMedicalHistory():** Returns the medical history of the patient.

**SetMedicalHistory(string medicalHistory):** Sets the medical history of the patient. No specific validations need to be checked for this value.

**SetSymptomCode(string symptomCode, out string errorMessage):** Sets the symptom code of the patient. Symptom Code should either be S1, S2, or S3.

**GetSymptoms():** Returns the symptom description based on the current value of 'symptomCode' field.

S1 / s1: Headache
S2 / s2: Skin rashes
S3 / s3: Dizziness
Any other value: Unknown

**GetPrescription():** Returns the medication prescribed to the patient.

**SetPrescription(string prescription):** Sets the medication prescribed to the patient. No specific validations need to be checked for this value.


## Part 3: Main() method
This application will be used by patient users. The Main() method (entry point) should read all inputs (patient name, age, gender, medical history, symptoms etc.) from the patient and call "PrescribeMedication()" method of MedicalBot class and display the result prescription that was returned by the PrescribeMedication() method.

**Sample Output 1:**

Hi, I'm Bob. I'm here to help you in your medication.

Enter your (patient) details:
Enter Patient Name: William
Enter Patient Age: 30
Enter Patient Gender: Male
Enter Medical History. Eg: Diabetes. Press Enter for None: Diabetes

Welcome, William, 30.

Which of the following symptoms do you have:
S1. Headache
S2. Skin rashes
S3. Dizziness

Enter the symptom code from above list (S1, S2 or S3): S3

Your prescription based on your age, symptoms and medical history:
metformin 500 mg

Thank you for coming.


**Sample Output 2:**

Hi, I'm Bob. I'm here to help you in your medication.

Enter your (patient) details:
Enter Patient Name: Alice
Enter Patient Age: 15
Enter Patient Gender: Female
Enter Medical History. Eg: Diabetes. Press Enter for None:

Welcome, Alice, 15.

Which of the following symptoms do you have:
S1. Headache
S2. Skin rashes
S3. Dizziness

Enter the symptom code from above list (S1, S2 or S3): S2

Your prescription based on your age, symptoms and medical history:
diphenhydramine 50 mg

Thank you for coming.
