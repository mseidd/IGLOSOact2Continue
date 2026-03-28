using crudPVmodels;

namespace crudPVdataService
{
    public interface IPVdataService
    {
        void AddVendor(VendorModel vendor);
        void AddPurchase(PurchaseModel purchase);

        List<VendorModel> GetVendors();
        List<PurchaseModel> GetPurchases();


        bool UpdateVendor(string findVendor, string newName, string newAddress, string newContact);
        bool DeleteVendor(int index);
    }
}