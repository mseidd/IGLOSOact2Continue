using crudPVdataService;
using crudPVmodels;

namespace crudPVappService
{
    public class PVappService
    {
        private PVdataService data = new PVdataService();



        public void AddVendor()
        {
            Console.WriteLine("----------ADD VENDOR-------------");
            Console.WriteLine("Enter Name: ");
            string vendorName = Console.ReadLine();

            Console.WriteLine("Enter Address: ");
            string vendorAdd = Console.ReadLine();

            Console.WriteLine("Enter Contact Info: ");
            string vendorContact = Console.ReadLine();

            VendorModel vendor = new VendorModel
            {
                Name = vendorName,
                Address = vendorAdd,
                Contact = vendorContact
            };

            data.vendor.Add(vendor);

            Console.WriteLine("Vendor Added!!");
        }

        public void ViewVendor()
        {
            Console.WriteLine("-------VENDOR LIST-------");

            if (data.vendor.Count == 0)
            {
                Console.WriteLine(" No Vendors available.");
                return;
            }

            int number = 1;

            foreach (var v in data.vendor)
            {
                Console.WriteLine("[" + number + "] " + v);
                number++;
            }
        }

        public void AddPurchase()
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

            PurchaseModel purchase = new PurchaseModel
            {
                VendorName = vendorName,
                Item = purchaseItem,
                Quantity = purchaseQuantity,
                Total = total
            };

            data.purchase.Add(purchase);

            Console.WriteLine("Purchase Added!!");
        }

        public void ViewVendorPurchase()
        {
            ViewVendor();

            Console.WriteLine("--------PURCHASE LIST--------");

            if (data.purchase.Count == 0)
            {
                Console.WriteLine(" No Purchase available.");
                return;
            }

            int num = 1;

            foreach (var p in data.purchase)
            {
                Console.WriteLine("[" + num + "] " + p);
                num++;
            }
        }

        public void UpdateVendor()
        {
            Console.WriteLine("UPDATE VENDOR: ");
            Console.Write("Enter the Name of the vendor you want to update: ");
            string findVendor = Console.ReadLine();
            bool isFound = false;

            for (int i = 0; i < data.vendor.Count; i++)
            {
                if (data.vendor[i].Name.Equals(findVendor, StringComparison.OrdinalIgnoreCase))
                {
                    isFound = true;
                    Console.WriteLine("Vendor Found!");
                    Console.Write("Enter new Name: ");
                    string newName = Console.ReadLine();

                    // Check if the new name is already taken by someone else
                    bool exists = false;
                    foreach (var v in data.vendor)
                    {
                        if (v.Name.Equals(newName, StringComparison.OrdinalIgnoreCase) && v.Name != findVendor)
                        {
                            exists = true;
                            break;
                        }
                    }

                    if (!exists)
                    {
                        Console.Write("Enter new Address: ");
                        string newAddress = Console.ReadLine();
                        Console.Write("Enter new Contact: ");
                        string newContact = Console.ReadLine();

                        data.vendor[i].Name = newName;
                        data.vendor[i].Address = newAddress;
                        data.vendor[i].Contact = newContact;

                        Console.WriteLine("Vendor details updated successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Error: Vendor name already exists.");
                    }
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("Vendor not found.");
            }
        }

        public void DeleteVendor()
        {
            ViewVendor();

            if (data.vendor.Count == 0) return;

            Console.WriteLine("Enter the number of vendor you want to delete: ");

            if (!int.TryParse(Console.ReadLine(), out int index) || index < 1 || index > data.vendor.Count)
            {
                Console.WriteLine("Invalid Vendor.");
                return;
            }

            data.vendor.RemoveAt(index - 1);

            Console.WriteLine("Vendor Deleted!!");
        }
    }
}