using NETCORE3.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace NETCORE3.ViewModels.Catalog.Products
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
        public List<int> categoryIds { get; set; }
    }
}
