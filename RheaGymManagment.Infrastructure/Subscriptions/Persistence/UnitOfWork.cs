using RheaGymManagment.Application.Commons.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RheaGymManagment.Infrastructure.Subscriptions.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        public Task CommitChangesAsync()
        {
            throw new Exception();
        }
    }
}
