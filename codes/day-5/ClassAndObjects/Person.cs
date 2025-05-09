class Person
{
    //data members of the class
    string name;
    string address;
    DateTime dob;
    long phoneNumber;
    string email;

    //default constructor (parameterless constructor)
    public Person() { }

    //parameterized constructor
    public Person(string name, string address, DateTime dob, long phoneNumber, string email)
    {
        this.name = name;
        this.address = address;
        this.dob = dob;
        this.phoneNumber = phoneNumber;
        this.email = email;
    }

    //properties: set the value to the data member and get the value of the data member
    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    //instance method
    public string GetInformation() => $"Name: {name}, Address: {address}, DOB: {dob.ToString("dd-MM-yyyy")}, Phone Number: {phoneNumber}, Email: {email}";
}