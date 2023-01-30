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

int x = 40;

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

