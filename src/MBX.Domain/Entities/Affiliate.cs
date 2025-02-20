﻿using System.ComponentModel.DataAnnotations.Schema;

using MBX.Domain.Common;

namespace MBX.Domain.Entities;

public class Affiliate : BaseEntity
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    [Column(TypeName = "decimal(18, 2)")] public decimal CommissionRate { get; set; }
    public string AffiliateUrl { get; set; } = string.Empty;

    // Navigation properties
    public virtual ICollection<OrderAffiliate> OrderAffiliates { get; set; } = new List<OrderAffiliate>();
}