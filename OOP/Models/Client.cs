

namespace OOP.Models
{
    internal class Client
    {
        private string? _firstname;
        private string? _lastname;
        private string? _email;
        private string? _address;
        private string? _phonenumber;

        public Client( string FirstName, string  LastName, string Email, string Address, string PhoneNumber)
        {
            _firstname = FirstName;
            _lastname = LastName;
            _email = Email;
            _address = Address;
            _phonenumber = PhoneNumber;
        }

       
        public override string ToString()
        {
            return "FirstName: " + _firstname + "\n" +
                   "LastName: " + _lastname + "\n" +
                   "Email: " + _email + "\n" +
                   "Address: " + _address + "\n" +
                   "PhoneNumber: " + _phonenumber;
        }



    }
}
