namespace AnimalRescue
{
    internal class Veterinarian
    {
        public Gender Gender { get; set; }
        public int Age { get; set; }

        public void SetGender(Gender gender)
        {
            Gender = gender;
        }



       
    }

    public enum Gender
    {
        Male,
        Female
    }

}
