using Entities.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Offer : CoreEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }
        public string CompanyName { get; set; }
        public string SiteUrl { get; set; }
        public string Message { get; set; }
        public int CategoryId { get; set; }
        public virtual ProjectCategory ProjectCategory { get; set; }
    }
}
