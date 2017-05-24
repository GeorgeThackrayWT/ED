using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.DTOS
{
    public class MenuDTO
    {
        public int Id { get; set; }

        public int? ParentMenuId { get; set; }

        public string Caption { get; set; }

        public string Destination { get; set; }
    }
}
