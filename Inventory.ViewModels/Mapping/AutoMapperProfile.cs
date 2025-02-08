using AutoMapper;
using Inventory.ViewModels.SalesTypeVM;



namespace Inventory.ViewModels.Mapping
{
    public class AutoMapperProfile :Profile 
    {
       
        public AutoMapperProfile()
        {
            CreateMap<CreateBillViewModel, Bill>();
            CreateMap<Bill, BillListViewModel>();
            CreateMap<Bill, BillViewModel>();
            CreateMap<CreateBillTypeViewModel, BillType>();
            CreateMap<BillType, BillTypeListViewModel>();
            CreateMap<BillType, BillTypeViewModel>();
            CreateMap<CreateVendorTypeViewModel, VendorType>();
            CreateMap<VendorType, VendorTypeViewModel>();
            CreateMap<VendorType, VendorTypeListViewModel>();
            CreateMap<SalesType, SalesTypeListViewModel>();
            CreateMap<SalesType, SalesTypeViewModel>();
            CreateMap<CreateSalesTypeViewModel, SalesType>();
        }

    }
}
