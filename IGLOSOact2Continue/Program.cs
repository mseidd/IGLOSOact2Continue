namespace IGLOSOact2Continue
{
    internal class Program
    {
        static void Main(string[] args)
        {

        public static class VendorPurchaseManagementSystem
        {
            List<Vendors> = vendorList = new List<Vendors>();
            List<Purchase> = purchaseList = new List<purchase>();

            static int vendorCount = 1;
            static int purchaseCount = 1;



            public static void Main()
            {
                while (true)
                {
                    Console.WriteLine("--------Vendor/Purchase Management System------");
                    Console.WriteLine("1. Add Vendor");
                    Console.WriteLine("2. Add Purchase");
                    Console.WriteLine("3. Exit");
                    Console.WriteLine("Enter your choice: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            AddVendor();
                            break;
                        case "2":
                            AddPurchase();
                            break;
                        case "3":
                            Console.WriteLine("Exiting the program. Goodbye!");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }


                }


                static void AddVendor()

                {
                    Console.WriteLine("----------VENDOR-------------");
                    Console.WriteLine("Enter vendor ID: ");
                    string vendorID = Console.ReadLine();
                    Console.WriteLine("Enter Name: ");
                    string vendorName = Console.ReadLine();
                    Console.WriteLine("Enter Address: ");
                    string vendorAdd = Console.ReadLine();
                    Console.WriteLine("Enter Contact Info: ");
                    string vendorContact = Console.ReadLine();
                }


                static void AddPurchase()
                {
                    Console.WriteLine("----------PURCHASE-------------");
                    Console.WriteLine("Enter Purchase ID: ");
                    string purchaseID = Console.ReadLine();
                    Console.WriteLine("Enter Item Name: ");
                    string purchaseItem = Console.ReadLine();
                    Console.WriteLine("Enter Quantity: ");
                    string purchaseQuantity = Console.ReadLine();
                    Console.WriteLine("Enter Price: ");
                    string purchasePrice = Console.ReadLine();
                }


            }
        }
    }
}