namespace Task3B
{
    class Program
    {
        static void Main()
        {
            NepaliTeacher nepali = new NepaliTeacher();
            EnglishTeacher english = new EnglishTeacher();

            nepali.Name = "Ram";
            Console.WriteLine("Nepali Teacher:" + nepali.Name);
            nepali.Teaching();
            nepali.SalaryInfo();

            Console.WriteLine();

            english.Name = "Rohan";
            Console.WriteLine("English Teacher:" + english.Name);
            english.Teaching();
            english.SalaryInfo();
        }
    }
}
