using crudPVmodels;

namespace crudPVdataService
{
    public class PVdataService
    {
        public List<VendorModel> vendor { get; set; } = new List<VendorModel>();
        public List<PurchaseModel> purchase { get; set; } = new List<PurchaseModel>();
    }

}