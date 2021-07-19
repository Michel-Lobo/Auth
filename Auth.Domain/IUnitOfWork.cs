using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Auth.Domain
{
    public interface IUnitOfWork
    {
        bool Commit(bool logicalDelete = false);
    }
}
