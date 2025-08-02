using HospitalSystem.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.Infrastructure.Factory
{
    public class FileAccessFactory : IDataAccessFactory
    {
        public IDataReaderFactory GetDataReaderFactory(string type)
        {
            return type switch
            {
                "CSV" => new CsvFileReaderFactory(),
                _ => throw new ArgumentException("Invalid file type")
            };
        }
    }
}
