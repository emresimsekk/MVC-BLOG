using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Blog.WCF
{
    using Dto;
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "Itbl_articleService" in both code and config file together.
    [ServiceContract]
    public interface Itbl_articleService:IService<tbl_articleDTO>
    {
        
       
    }
}
