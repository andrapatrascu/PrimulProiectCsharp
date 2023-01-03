namespace AnimalRescue
{
    internal class Veterinarian
    {
        Gender _gender;
        int _age;

        public void SetGender(Gender gender)
        {
            _gender = gender;
        }

        public Gender GetGender()
        {
            return _gender;
        }

        public void SetAge(int age)
        {
            this._age = age;
        }

        public int GetAge()
        {
            return _age;
        }
    }

    public enum Gender
    {
        Male,
        Female        
    }

}
