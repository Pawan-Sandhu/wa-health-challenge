using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.Domain.Interfaces
{
    public interface IDataReaderFactory
    {
        IDataReader GetReader(string entityType);
    }
}
