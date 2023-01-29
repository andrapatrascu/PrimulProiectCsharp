namespace AnimalRescue
{
    internal class Animal
    {
        private AnimalType _type;

        public Animal(AnimalType type)
        {
            _type = type;
        }

        public AnimalType GetAnimalType() 
        {
            return _type;
        }
    }
}
