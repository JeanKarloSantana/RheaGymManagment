using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RheaGymManagment.Application.Commons.interfaces
{
    public interface IUnitOfWork
    {
      Task CommitChangesAsync();
    }
}
