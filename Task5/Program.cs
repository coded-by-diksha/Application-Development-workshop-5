namespace Task5
{
    class Program
    {
        static void Main()
        {
            ElectronicsStore store = new ElectronicsStore();

            Laptop laptop = new Laptop("Dell", 1200m);
            Smartphone phone = new Smartphone("Samsung", 900m);

            store.AddDevice(laptop);
            store.AddDevice(phone);

            store.ShowAllDeviceDetails();
        }
    }
}
