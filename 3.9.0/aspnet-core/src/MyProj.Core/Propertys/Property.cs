using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities.Auditing;

namespace MyProj.Propertys
{
    public class Property : FullAuditedEntity
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public int NumberOfBedRooms { get; set; }
        public int NumberOfBathRooms { get; set; }
        public bool HasGarage { get; set; }
        public int GarageSize { get; set; }
        public decimal Cost { get; set; }
    }
}
