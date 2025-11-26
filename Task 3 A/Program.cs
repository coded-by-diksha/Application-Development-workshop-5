namespace Task_3_A
{
    class Program
    {
        static void Main()
        {
            Printer printer = new Printer();

            printer.Print("hello there how are you");
            printer.Print(122333);
            printer.Print("application", 5);
        }
    }
}
