using Nop.Admin.Models.Common;
using Nop.Web.Framework.Mvc;

namespace Nop.Admin.Models.Customers
{
    public partial class CustomerAddressModel : BaseNopModel
    {
        public int CustomerId { get; set; }

        public int CustomerAge { get; set; }
        public AddressModel Address { get; set; }
    }
}