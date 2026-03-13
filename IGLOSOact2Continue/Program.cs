using crudPVappService;


namespace IGLOSOact2Continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
           PVappService service = new PVappService();

            while (true)
            {
                Console.WriteLine("--------Vendor/Purchase Management System------");
                Console.WriteLine("1. Add Vendor");
                Console.WriteLine("2. Add Purchase");
                Console.WriteLine("3. View Vendors / Purchases");
                Console.WriteLine("4. Update Vendors");
                Console.WriteLine("5. Delete Vendors");
                Console.WriteLine("6. Exit");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        service.AddVendor();
                        break;

                    case "2":
                        service.AddPurchase();
                        break;

                    case "3":
                        service.ViewVendorPurchase();
                        break;

                    case "4":
                        service.UpdateVendor();
                        break;

                    case "5":
                        service.DeleteVendor();
                        break;

                    case "6":
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}