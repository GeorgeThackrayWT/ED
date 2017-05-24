using System;

namespace DataObjects.DTOS
{
    public class PropertyDto
    {

        public int ID { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public string LPM { get; set; }

        public string GridReference { get; set; }

        public double AreaHa { get; set; }

        public DateTime Acquired { get; set; }

        public string Tenure { get; set; }

        public string LeaseTermYrs { get; set; }

        public string ManagedBy { get; set; }

        public string SFPS { get; set; }


        public string CostCentre { get; set; }

        public string Region { get; set; }

        public string Manager { get; set; }

        
    }
}