using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace QYQ.DataManagement.EntityFrameworkCore
{
    [ConnectionStringName("Default")]
    public interface IDataManagementDbContext : IEfCoreDbContext
    {

    }
}
