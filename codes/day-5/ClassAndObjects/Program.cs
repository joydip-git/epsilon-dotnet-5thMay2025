Person[] people = new Person[1];
for (int i = 0; i < 1; i++)
{
    Console.WriteLine($"enter name: ");
    string personName = Console.ReadLine();

    Console.WriteLine($"enter address");
    string personAddress = Console.ReadLine();

    Console.WriteLine($"enter dob[dd-MM-yyyy]: ");
    DateTime personDob = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);

    Console.WriteLine($"enter phone number: ");
    long personPhoneNumber = long.Parse(Console.ReadLine());

    Console.WriteLine($"enter email: ");
    string personEmail = Console.ReadLine();

    //Person person = new Person(); 
    //Person person =new Person(name, address, dob, phoneNumber, email);

    //named arguments
    //person -> reference variable of type Person class which holds reference to the object
    //Person person = null;
    Person person = new Person(address: personAddress, dob: personDob, email: personEmail, name: personName, phoneNumber: personPhoneNumber);
    person.Name = personName;//set accessor will be called
    Console.WriteLine($"person name: {person.Name}");// get accessor will be called
    people[i] = person;
}

foreach (Person person in people)
{
    Console.WriteLine(person.GetInformation());
}

Console.WriteLine("enter any key to exit");
Console.ReadKey();



