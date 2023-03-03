namespace AnimalRescue
{
    internal class Nurse
    {

        public void SetNurseAge(int age)
        {
            int Age = age;

        }
        public void SetFullName(string firstName, string lastName)
        {
            string Firstname = firstName;
            string LastName = lastName;
        }

        public void DisplayFinishJob()
        {
            Console.WriteLine("Nurse finished the job for today");
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

        public void SetDrivingLicenceType(char B)
        {
            Console.WriteLine("Nurse is driving because she has a driving licence for cathegory {0}", B);
        }

        public void CallDoctor(long phone)
        {
            Console.WriteLine("Nurse is calling the doctor dialing {0}", phone);
        }

        public void SetDogMeasurements(double height, int kg)
        {
            Console.WriteLine("Nurse measures the dog.Height and kg are {0}, {1}", height, kg);
        }

        public int GetNurseShoesSize ()
        {
            return 36;
        }

        public string ReadFullName(string firstName, string lastName)
        {
            return firstName + "" + lastName;
        }

        public string GetOcupation()
        {
            return "Nurse";
        }

        public bool IsDrivingLicenceExpired()
        {
            return false;
        }

        public double CalculateSum( double x, double y)
        {
            double sum = x + y;
            return sum;
        }
        
        public char GetFirstLetterName()
        {
            return 'A';
        }

        public char GetSecondLetter(char a)
        {
            return a;
        }

        public long GetMobilePhone()
        {
            return 156478974124L;
        }

        public long GetSecondPhone(long phone)
        {
            return phone;
        }

    }
}
