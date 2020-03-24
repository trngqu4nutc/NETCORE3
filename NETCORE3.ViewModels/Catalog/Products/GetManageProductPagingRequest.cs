using NETCORE3.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace NETCORE3.ViewModels.Catalog.Products
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<int> categoryIds { get; set; }
    }
}
