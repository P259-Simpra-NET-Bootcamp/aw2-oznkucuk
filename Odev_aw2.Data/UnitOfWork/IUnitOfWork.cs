using Odev_aw2.Data.EntityLayer;
using Odev_aw2.Data.Repository;

namespace Odev_aw2.Data.UnitOfWork;

public interface IUnitOfWork : IDisposable
{
    IGenericRepository<Staff> StaffRepository { get; }

    void Complate();
}
