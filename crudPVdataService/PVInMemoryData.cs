using crudPVmodels;

namespace crudPVdataService
{
    public class PVInMemoryData : IPVdataService
    {
        private List<VendorModel> vendor = new List<VendorModel>();
        private List<PurchaseModel> purchase = new List<PurchaseModel>();

        public List<VendorModel> GetVendors() => vendor;
        public List<PurchaseModel> GetPurchases() => purchase;

        public void AddVendor(VendorModel v) => vendor.Add(v);
        public void AddPurchase(PurchaseModel p) => purchase.Add(p);

        public bool UpdateVendor(string findVendor, string newName, string newAddress, string newContact)
        {
            foreach (var v in vendor)
            {
                if (v.Name.Equals(findVendor, StringComparison.OrdinalIgnoreCase))
                {
                    v.Name = newName;
                    v.Address = newAddress;
                    v.Contact = newContact;
                    return true;
                }
            }
            return false;
        }

        public bool DeleteVendor(int index)
        {
            if (index < 0 || index >= vendor.Count)
                return false;

            vendor.RemoveAt(index);
            return true;
        }
    }
}