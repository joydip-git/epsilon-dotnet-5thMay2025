using MessengerLibrary;

Console.WriteLine("this is the client who is using MessengerLibrary");

//creating an instance or object of Messanger class
Messanger messanger = new Messanger();

//calling the instance method of the class using the reference variable and also storing the returned value in a string variable
string message = messanger.GetMessage("Joydip");

//printing the returned message
Console.WriteLine(message);
