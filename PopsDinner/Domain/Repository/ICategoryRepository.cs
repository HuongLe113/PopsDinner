using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using popsDiner.Domain.Entities;
namespace popsDiner.Domain.Repository
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
