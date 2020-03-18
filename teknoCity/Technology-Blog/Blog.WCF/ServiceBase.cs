using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;


namespace Blog.WCF
{
    using Dto;
    using Entity.Table;
    using Business;
    using Extensions;
    public class ServiceBase<BL, Entity, DTO> : IService<DTO> 
        where DTO : class
        where Entity:class
        where BL:ManagementBase<Entity>
    {

        private ManagementBase<Entity> Repo = new ManagementBase<Entity>();

        private BL business;

        public BL Business
        {
            get 
            {
                business =business ?? Activator.CreateInstance<BL>();

                return business; 
            }
            set { business = value; }
        }

        public int Delete(DTO obj)
        {
            throw new NotImplementedException();
        }

        public int Insert(DTO obj)
        {
            throw new NotImplementedException();
        }

        public List<DTO> List()
        {
            return Repo.List().Select(x => x.Changer<DTO>()).ToList();
        }


        public int Update(DTO obj)
        {
            throw new NotImplementedException();
        }
    }
}