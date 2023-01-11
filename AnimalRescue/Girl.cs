namespace AnimalRescue
{
    internal class Girl
    {
        int _age = 7;
        string _hair = "red";
        bool _animalLover;
        public string Name { get; set; }

        public Girl(int age, string hair)
        {
            _age = age;
            _hair = hair;
            Console.WriteLine("Girl's age is {0} and her hair is {1}", _age, _hair);
        }

        public bool IsAnimalLover()
        {
            return _animalLover;
        }

        public void SetAnimalLoverValue(bool animalLover)
        {
            _animalLover = animalLover;
        }

       
    }
}
