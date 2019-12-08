using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RSTVideoInc.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        [Required]

        public string Name { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
        
    }
}