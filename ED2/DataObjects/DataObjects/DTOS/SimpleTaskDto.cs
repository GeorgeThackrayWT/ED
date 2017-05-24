using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmHelpers;

namespace DataObjects
{
    public class SimpleTaskDTO : ObservableObject
    {


        public int TaskId { get; set; }

        public string SiteName { get; set; }

        public DateTime Deadline { get; set; }

        public string Region { get; set; }

        public string Notes { get; set; }

        public string Manager { get; set; }

        public double Amount { get; set; }

        public string Category { get; set; }

    }
}
