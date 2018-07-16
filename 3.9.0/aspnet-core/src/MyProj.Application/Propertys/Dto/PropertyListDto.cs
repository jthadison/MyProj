using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;

namespace MyProj.Propertys.Dto
{
    [AutoMapFrom(typeof(Property))]
    public class PropertyListDto : EntityDto, IHasCreationTime
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public int NumberOfBedRooms { get; set; }
        public int NumberOfBathRooms { get; set; }
        public bool HasGarage { get; set; }
        public int GarageSize { get; set; }
        public decimal Cost { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
