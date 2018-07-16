using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using MyProj.Authorization.Users;

namespace MyProj.Propertys
{
    public class PropertyInvestment : CreationAuditedEntity
    {
        public User User { get; set; }
        public Property Property { get; set; }
        public decimal Amount { get; set; }
    }
}
