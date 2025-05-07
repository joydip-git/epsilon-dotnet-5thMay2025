using MessengerLibrary;

Console.WriteLine("this is the client who is using MessengerLibrary");

//int -> data type
//value -> variable name
//10 -> value assigned to the variable (10 is stored in the memory location named "value")
int value = 10;
Console.WriteLine("Value is: " + value);


//creating an instance or object of Messanger class
//new -> keyword used to create an instance of a class
//Messenger -> class name (data type)
//messanger -> reference variable name, which is used to store the reference to the object of Messanger class, present in the heap and through that reference variable you can access the members of the class, such as GetMessage method.
// the messenger variable's memory location is  in the stack and the object is stored in the heap.
Messenger messanger = new Messenger();

//calling the instance method of the class using the reference variable and also storing the returned value in a string variable
string message = messanger.GetMessage("Joydip");

//printing the returned message
Console.WriteLine(message);
