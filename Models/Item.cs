using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InNOut.Models
{
    public class Item
    {
        /// <summary>
        /// Database id
        /// </summary>
        [Key]
        public int? Id { get; set; }

        /// <summary>
        /// The Borrower name
        /// </summary>
        [StringLength(10, MinimumLength = 5)]
        [Required]
        public string Borrower { get; set; }

        /// <summary>
        /// Lender name
        /// </summary>
        [Required]
        public string Lender { get; set; }

        /// <summary>
        /// Borrowed item name
        /// </summary>
        [DisplayName("Item Name")]
        [Required]
        public string ItemName { get; set; }

    }
}
