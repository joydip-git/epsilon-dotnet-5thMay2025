//List<int> numbers = new List<int>();
using CollectionsDemo;

List<int> numbers = [];
numbers.Add(10);//0
numbers.Add(11);//1
numbers.Add(21);//2
numbers.Add(31);//3
numbers.Add(41);//4
numbers.Add(51);//5
numbers.Add(51);//6

//index <= the size
numbers.Insert(2, 61);
//numbers.Remove(31);
numbers.RemoveAt(4);

//for (int i = 0; i < numbers.Count; i++)
//{
//    Console.WriteLine(numbers[i]);
//}

foreach (int item in numbers)
{
    Console.WriteLine(item);
}
Console.WriteLine("set data");
HashSet<int> set = new HashSet<int>();
set.Add(10);
set.Add(11);
set.Add(10);
set.Add(21);

foreach (int item in set)
{
    Console.WriteLine(item);
}

HashSet<Person> people = new HashSet<Person>();
Person anilPerson = new Person() { Id = 1, Name = "Anil" };
Person sunilPerson = new Person() { Id = 1, Name = "Anil" };

bool anilAdded = people.Add(anilPerson);//calculates an unique hash code by calling the GetHashCode() method of Person class
bool sunilAdded = people.Add(sunilPerson);//calculates an unique hash code by calling the GetHashCode() method of Person class and then compare the hash code with the previouslu calculated hash code
//if the hash code is same as that of the previous hash code then HashSet calls Equals() method of the object
//anilPerson.Equals(sunilPerson) => false

foreach (Person item in people)
{
    //Console.WriteLine(item.Id + "\t" + item.Name);
    //Console.WriteLine(item.ToString());
    //implicitly ToString() method (either the inherited base class method or the overriden method in the child class) will be called
    Console.WriteLine(item);
}
Console.WriteLine("\ndictionary\n");
Dictionary<int, string> dictionary = new Dictionary<int, string>();
dictionary.Add(1, "epsilon");
dictionary.Add(0, "bangalore");
dictionary.Add(2, "hebbal");

//KeyValuePair item = new (1, "epsilon");
//KeyValuePair item = new (0, "bangalore");
//KeyValuePair item = new (2, "hebbal");

foreach (KeyValuePair<int, string> item in dictionary)
{
    Console.WriteLine(item.Key + "\t" + item.Value);
}
Console.WriteLine("\nsorted list\n");
SortedList<int, string> sortedList = new SortedList<int, string>();
sortedList.Add(1, "epsilon");
sortedList.Add(0, "bangalore");
sortedList.Add(2, "hebbal");

//KeyValuePair item = new (1, "epsilon");
//KeyValuePair item = new (0, "bangalore");
//KeyValuePair item = new (2, "hebbal");

foreach (KeyValuePair<int, string> item in sortedList)
{
    Console.WriteLine(item.Key + "\t" + item.Value);
}


