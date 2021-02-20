using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YuShop.Models
{
    public class Customer
    {

        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public String Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType membershipType { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}