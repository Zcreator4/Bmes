using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bmes.Models.Shared
{
    public class BaseObject
    {
        public long Id { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
