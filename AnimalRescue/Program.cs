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

Father father = new Father();
father.SetHeight(1.93f);
Console.WriteLine(father.GetHeight());
Console.WriteLine("Father's height is {0}", father.GetHeight());

int x = 40;

Veterinarian veterinarian = new Veterinarian();
veterinarian.SetAge(x);
veterinarian.SetAge(34);
Gender gender = Gender.Male;
veterinarian.SetGender(gender);
veterinarian.SetGender(Gender.Female);
Console.WriteLine("Veterinarian's gender is {0} and age is {1}", veterinarian.GetGender(), veterinarian.GetAge());





