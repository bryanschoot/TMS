namespace TMS.Model
{
    public class AccountModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public AddressModel Address { get; set; }
        public AccountModel(int id, string email, string password, string firstName, string lastName, int age, AddressModel address)
        {
            this.Id = id;
            this.Email = email;
            this.Password = password;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Address = address;
        }
        public override string ToString()
        {
            return $"{Id}\n{Email} : {Password}\n{FirstName} : {LastName} : {Age}\n{Address}";
        }
    }
}