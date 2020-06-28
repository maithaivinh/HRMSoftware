using System;
using System.Collections.Generic;
using System.Text;

namespace HRMSoftware.Infrastructure.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
