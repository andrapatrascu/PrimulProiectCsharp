using AnimalRescue;

/*
Girl girl = new Girl(10,"green");
//girl.IsAnimalLover(); same output as line 6
var isAnimalLover = girl.IsAnimalLover();
girl.SetAnimalLoverValue(true);
Console.WriteLine(isAnimalLover);
Console.WriteLine(girl.IsAnimalLover());
*/

Girl girl = new Girl(8, "blue");
Console.WriteLine(girl.IsAnimalLover());
girl.SetAnimalLoverValue(true);
Console.WriteLine(girl.IsAnimalLover());
girl.Name = "Blue";

Father father = new Father();
father.SetHeight(1.93f);
Console.WriteLine(father.GetHeight());
Console.WriteLine("Father's height is {0}", father.GetHeight());


Veterinarian veterinarian = new Veterinarian();
veterinarian.Age = 34;
veterinarian.Gender = Gender.Male;
Console.WriteLine("Veterinarian's gender is {0} and age is {1}", veterinarian.Gender, veterinarian.Age);

AnimalShelter animalShelter = new AnimalShelter(8);
//animalShelter.AddAnimal(AnimalType.Dog);
animalShelter.AddAnimal(AnimalType.Cat);
animalShelter.AddAnimal(AnimalType.Dog);
animalShelter.AddAnimal(AnimalType.Mouse);
animalShelter.AddAnimal(AnimalType.Dog);
animalShelter.AddAnimal(AnimalType.Cat);
animalShelter.AddAnimal(AnimalType.Bear);

AnimalType animalType = AnimalType.Bear;
Console.WriteLine("The type {0} {1}", animalType, animalShelter.AdoptAnimal(animalType) ? "exists" : "does not exist");

animalType = AnimalType.Crocodile;
Console.WriteLine("The type {0} {1}", animalType, animalShelter.AdoptAnimal(animalType) ? "exists" : "does not exist");

animalType = AnimalType.Mouse;
Console.WriteLine("The type {0} {1}", animalType, animalShelter.AdoptAnimal(animalType) ? "exists" : "does not exist");


Animal[] Animals = new Animal[5];
Animals[0] = new Animal(AnimalType.Bear, true);
Animals[2] = new Animal(AnimalType.Bear, false);
Animals[3] = new Animal(AnimalType.Dog, true);
Animals[4] = new Animal(AnimalType.Cat, false);

animalShelter.AddAnimals(Animals);
animalType = AnimalType.Mouse;
Console.WriteLine("The type {0} {1}", animalType, animalShelter.AdoptAnimal(animalType) ? "exists" : "does not exist");

animalType = AnimalType.Dog;
Console.WriteLine("The type {0} {1}", animalType, animalShelter.AdoptAnimal(animalType) ? "exists" : "does not exist");

string AdoptedAnimal = animalShelter.AdoptSomeAnimal(AnimalType.Dog);
Console.WriteLine("[{0}] was adopted", AdoptedAnimal);

AdoptedAnimal = animalShelter.AdoptSomeAnimal(AnimalType.Crocodile);
Console.WriteLine("[{0}] was adopted", AdoptedAnimal);

Console.WriteLine("The type {0} {1}", AnimalType.Crocodile, animalShelter.AdoptSomeAnimal(AnimalType.Crocodile) != "" ? "exists" : "does not exist");

Animal[] AnimalsFromShelter = animalShelter.GetAnimals();

for (int i = 0; i < AnimalsFromShelter.Length; ++i)
{
    if (AnimalsFromShelter[i] == null)
    {
        continue;
    }
    bool isOK = veterinarian.CheckAnimal(AnimalsFromShelter[i]);
    Console.WriteLine("The {0} {1}", AnimalsFromShelter[i].GetAnimalType(), isOK ? "is Ok" : "is NOT Ok");

}


Nurse nurse = new Nurse();
nurse.SetNurseAge(25);
nurse.SetFullName("Anna", "Ball");
nurse.SetPositiveLevel(true);
nurse.SetTestResults(2.44F, 5.66F, 7.74F);
nurse.SetDrivingLicenceType('B');
nurse.CallDoctor(15000000000L);
nurse.SetDogMeasurements(1.02D, 5);
nurse.DisplayFinishJob();
int size = nurse.GetNurseShoesSize();
nurse.ReadFullName("Anne","Boleyn");
nurse.IsDrivingLicenceExpired();
nurse.CalculateSum(2.5, 56.5);
string work = nurse.GetOcupation();
nurse.GetFirstLetterName();
nurse.GetSecondLetter('n');
nurse.GetMobilePhone();
long phone = nurse.GetSecondPhone(15);

