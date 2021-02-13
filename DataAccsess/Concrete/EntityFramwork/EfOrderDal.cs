using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramwork
{
    public class EfOrderDal : EfEntityRepositoryBase<Order,NorthwindContext>,IOrderDal
    {
    }
}
