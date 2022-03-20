using System;
using System.ComponentModel.DataAnnotations;

namespace PartsUnlimited.Models
{
    public class CartItem : ILineItem
    {
<<<<<<< HEAD
        // My Second Change
=======
        // My First change
>>>>>>> 9cf5c46d1d36a7761a7bfc4e6082b392bb2bdc3a
        [Key]
        public int CartItemId { get; set; }

        [Required]
        public string CartId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateCreated { get; set; }

        public virtual Product Product { get; set; }
    }
}