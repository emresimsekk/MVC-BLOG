using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Blog.WCF
{
    using Business;
    using Dto;
    using Entity.Table;
    public class tbl_articleService : ServiceBase<ManagementArticle,tbl_article,tbl_articleDTO>
    {
      
    }
}
