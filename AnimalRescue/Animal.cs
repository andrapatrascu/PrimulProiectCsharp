namespace AnimalRescue
{
    internal class Animal
    {
        private AnimalType _type;
        private bool _isHappy;

        public Animal(AnimalType type)
        {
            _type = type;
            _isHappy = false;
        }
        public Animal(AnimalType type, bool IsHappy)
        {
            _type = type;
            _isHappy = IsHappy;
        }

        public AnimalType GetAnimalType() 
        {
            return _type;
        }

        public bool IsHappy()
        {
            return _isHappy;
        }
    }
}
