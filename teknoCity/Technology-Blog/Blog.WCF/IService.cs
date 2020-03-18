using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Blog.WCF
{
    [ServiceContract]
    public interface IService<DTO> where DTO: class
    {
        [OperationContract]
        List<DTO> List();
        
        
        [OperationContract]
        int Insert(DTO obj);

        [OperationContract]
        int Update(DTO obj);

        [OperationContract]
        int Delete(DTO obj);
        

    }
}
