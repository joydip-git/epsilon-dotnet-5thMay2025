using CallbackUsingDelegate;

Printer printer = new Printer();
//printer.Print("Welcome to callback mechanism");
ShowData(printer, "Welcome to callback mechanism");


static void ShowData(Printer printer, string dataToPrint)
{
    printer.Print(dataToPrint);
}
