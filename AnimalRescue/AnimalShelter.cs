namespace AnimalRescue
{
    public enum AnimalType
    {
        Dog,
        Cat,
        Bear,
        Mouse,
        Crocodile
    }

    internal class AnimalShelter
    {
        public int NumberOfAnimals { get; set; }
        public int NumberOfEmployees { get; set; }
        public string? ShelterName { get; set; }

        private Animal[]? _animals;
        private int _animalsCount;

        public AnimalShelter(int NumAnimals)
        {
            NumberOfAnimals = NumAnimals;
            _animals = new Animal[NumberOfAnimals];
            _animalsCount = 0;
        }

        public void AddAnimal(AnimalType type)
        {
            if (_animalsCount < NumberOfAnimals)
            {
                _animals[_animalsCount] = new Animal(type);
                _animalsCount++;
            }
        }

        public void AddAnimals(Animal[] Animals)
        {
            _animals = Animals;
            _animalsCount = Animals.Length;
        }

        public Animal[] GetAnimals()
        {
            return _animals;
        }

        public bool AdoptAnimal(AnimalType animalType)
        {
            for (int i = 0; i < _animalsCount; ++i)
            {
                if (_animals[i] == null)
                {
                    continue;
                }
                if (_animals[i].GetAnimalType() == animalType)
                {
                    return true;
                }
            }
            return false;
        }

        public string AdoptSomeAnimal(AnimalType animalType)
        {
            for (int i = 0; i < _animalsCount; ++i)
            {
                if (_animals[i] == null)
                {
                    continue;
                }
                if (_animals[i].GetAnimalType() == animalType)
                {
                    return animalType.ToString();
                }
            }
            return "";
        }

    }
}
