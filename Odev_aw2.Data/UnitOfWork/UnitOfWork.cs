using Odev_aw2.Data.Context;
using Odev_aw2.Data.EntityLayer;
using Odev_aw2.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_aw2.Data.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    public IGenericRepository<Staff> StaffRepository { get; private set; }

    private readonly Aw2DbContext dbContext;
    public UnitOfWork(Aw2DbContext dbContext)
    {
        this.dbContext = dbContext;
        StaffRepository = new GenericRepository<Staff>(dbContext);
    }

    public void Complate()
    {
        dbContext.SaveChanges();
    }

    public void Dispose()
    {

        GC.SuppressFinalize(this);
    }
}
