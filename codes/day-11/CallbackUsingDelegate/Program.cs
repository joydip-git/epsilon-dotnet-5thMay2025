using CallbackUsingDelegate;

Printer printer = new Printer();
//printer.Print("Welcome to callback mechanism");
//Printer.Show("Welcome to callback mechanism via delegate");

//reference to an instance method
PrintDel pdPrint = new PrintDel(printer.Print);
//reference to a static method
PrintDel pdShow = new PrintDel(Printer.Show);

//ShowData(printer, "Welcome to callback mechanism");
ShowData(pdPrint, "Welcome to callback mechanism");
ShowData(pdShow, "Welcome to callback mechanism via delegate");

//static void ShowData(Printer printer, string dataToPrint)
static void ShowData(PrintDel printDel, string dataToPrint)
{
    //printer.Print(dataToPrint);
    printDel(dataToPrint);
    printDel.Invoke(dataToPrint);
}

//using this delegate you can invoke any method (static or instance) which accepts one argumen of type string and returns nothing (void)
delegate void PrintDel(string data);
