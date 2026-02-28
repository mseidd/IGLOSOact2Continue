using System.Numerics;

namespace IGLOSOact2Continue
{
    internal class Program
    {
        static List<string> vendor = new List<string>();
        static List<string> purchase = new List<string>();

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("--------Vendor/Purchase Management System------");
                Console.WriteLine("1. Add Vendor");
                Console.WriteLine("2. Add Purchase");
                Console.WriteLine("3. View Vendors / Purchases");
                Console.WriteLine("4. Delete Vendors");
                Console.WriteLine("5. Exit");
                Console.WriteLine("------------------------------------------------");
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
                        viewVendorPurchase();
                        break;
                    case "4":
                        deleteVendor();
                        break;
                    case "5":
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }



            }
            static void AddVendor()

            {
                Console.WriteLine("----------ADD VENDOR-------------");
                Console.WriteLine("Enter Name: ");
                string vendorName = Console.ReadLine();
                Console.WriteLine("Enter Address: ");
                string vendorAdd = Console.ReadLine();
                Console.WriteLine("Enter Contact Info: ");
                string vendorContact = Console.ReadLine();



                string fullVendor = " Name : " + vendorName +
                                    " | Address: " + vendorAdd +
                                    " | Contact: " + vendorContact;
                vendor.Add(fullVendor);
                Console.WriteLine("Vendor Added!!");




            }
            static void viewVendor()
            {
                Console.WriteLine("-------VENDOR LIST-------");

                if (vendor.Count == 0)
                {
                    Console.WriteLine(" No Vendors available.");
                    return;
                }

                int number = 1;
                foreach (string v in vendor)
                {

                    Console.WriteLine("[" + number + "] " + v);
                    number++;

                }
            }


            static void AddPurchase()
            {
                Console.WriteLine("----------ADD PURCHASE------------");
                Console.WriteLine("Enter Vendor Name: ");
                string vendorName = Console.ReadLine();

                Console.WriteLine("----------SUPPLEMENTS-------------");
                Console.WriteLine("1. Creatine == Php 700 ");
                Console.WriteLine("2. Protein Powder == Php 1,500 ");
                Console.WriteLine("3. Pre-workout  == Php 300 ");

                Console.WriteLine("Enter Item Name: ");
                string purchaseItem = Console.ReadLine();
                Console.WriteLine("Enter Quantity: ");
                int purchaseQuantity = Convert.ToInt32(Console.ReadLine());


                int price = 0;

                if (purchaseItem.ToLower() == "creatine")
                    price = 700;
                else if (purchaseItem.ToLower() == "protein powder")
                    price = 1500;
                else if (purchaseItem.ToLower() == "pre-worout")
                    price = 1500;
                else
                {
                    Console.WriteLine("Invalid item.");
                    return;
                }

                int total = price * purchaseQuantity;

                string fullPurchase = "Vendor Name: " + vendorName +
                                    " | Item: " + purchaseItem +
                                    " | Quantity: " + purchaseQuantity +
                                    " | Total: Php " + total;

                purchase.Add(fullPurchase);
                Console.WriteLine("Purchase Added!!");
            }
            static void viewVendorPurchase()
            {


                viewVendor();


                Console.WriteLine("--------PURCHASE LIST--------");

                if (purchase.Count == 0)
                {
                    Console.WriteLine(" No Purchase available.");
                    return;
                }
                int num = 1;
                foreach (string p in purchase)
                {
                    Console.WriteLine("[" + num + "] " + p);
                    num++;

                }
            

            }
            static void deleteVendor()
            {
                viewVendor();

                if (vendor.Count == 0) return;

                Console.WriteLine("Enter the number of vendor you want to delete: ");
                if (!int.TryParse(Console.ReadLine(), out int index) || index < 1 || index > vendor.Count)
                {
                    Console.WriteLine("Invalid Vendor.");
                    return;
                }

                vendor.RemoveAt(index - 1);
                Console.WriteLine("Vendor Deleted!!");
            }
        }
    }
}