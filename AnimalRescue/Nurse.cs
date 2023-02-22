namespace AnimalRescue
{
    internal class Nurse
    {

        public void SetTheAge(int age)
        {
            int Age = age;

        }
        public void CallFullName(string firstName, string lastName)
        {
            string Firstname = firstName;
            string LastName = lastName;
        }

        public void DisplayTestResults()
        {
            Console.WriteLine("Name {0} {1}");
        }

        //public bool IsAPositivePerson()
        //{
        //    return IsHappy;
        //}

        public void SetPositiveLevel(bool ishappy)
        {
            Console.WriteLine("Nurse is happy {0}", ishappy);
        }

        public void SetTestResults(float blood, float calcium, float glucose)
        {
            Console.WriteLine("The results are {0}, {1}, {2} ", blood, calcium, glucose);

        }

        public void IsDriving(char B)
        {
            Console.WriteLine("Nurse is driving because she has a driving licence for cathegory {0}", B);
        }

        public void IsDialing(long phone)
        {
            Console.WriteLine("Nurse is calling the doctor dialing {0}", phone);
        }
    }
}
