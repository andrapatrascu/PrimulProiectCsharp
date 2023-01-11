namespace AnimalRescue
{
    internal class AnimalShelter
    {
        public int NumberOfAnimals { get; set; }
        public int NumberOfEmployees { get; set; }
        public string? ShelterName { get; set; }
        string? _animaltype;

        public string AdoptAnimal( string animalType, Girl girl)
        {
            string str1 = $"Animal adopted is {animalType} and girl name is {girl.Name}";
            return str1;
        }


       

    }
}
