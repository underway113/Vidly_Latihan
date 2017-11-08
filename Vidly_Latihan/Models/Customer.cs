﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly_Latihan.Models
{
    public class Customer
    {
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        //public bool IsSubscribedToNewsletter { get; set; }
        //public MembershipType MembershipType { get; set; }
        //public byte MembershipTypeId { get; set; }
    }
}