using System.Text.Json;
using crudPVmodels;
using crudPVdataService;

namespace crudPVdataService
{
  
    public class PVDataStorage
    {
        public List<VendorModel> Vendors { get; set; } = new();
        public List<PurchaseModel> Purchases { get; set; } = new();
    }

    public class PVJsonData : IPVdataService
    {
        private string file = "data.json";
        private List<VendorModel> vendor = new();
        private List<PurchaseModel> purchase = new();

        public PVJsonData()
        {
            Load();
        }

        private void Load()
        {
            if (!File.Exists(file) || new FileInfo(file).Length == 0) return;

            try
            {
                var json = File.ReadAllText(file);
                
                var importedData = JsonSerializer.Deserialize<PVDataStorage>(json);

                if (importedData != null)
                {
                    vendor = importedData.Vendors ?? new();
                    purchase = importedData.Purchases ?? new();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading data: " + ex.Message);
            }
        }

        private void Save()
        {
            var dataToSave = new PVDataStorage { Vendors = vendor, Purchases = purchase };
            var options = new JsonSerializerOptions { WriteIndented = true };
            var json = JsonSerializer.Serialize(dataToSave, options);
            File.WriteAllText(file, json);
        }

        public List<VendorModel> GetVendors() => vendor;
        public List<PurchaseModel> GetPurchases() => purchase;
        public void AddVendor(VendorModel v) { vendor.Add(v); Save(); }
        public void AddPurchase(PurchaseModel p) { purchase.Add(p); Save(); }

        public bool UpdateVendor(string f, string n, string a, string c)
        {
            foreach (var v in vendor)
            {
                if (v.Name.Equals(f, StringComparison.OrdinalIgnoreCase))
                {
                    v.Name = n; v.Address = a; v.Contact = c;
                    Save(); return true;
                }
            }
            return false;
        }

        public bool DeleteVendor(int index)
        {
            if (index < 0 || index >= vendor.Count) return false;
            vendor.RemoveAt(index);
            Save(); return true;
        }
    }
}