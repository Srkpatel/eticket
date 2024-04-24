using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int Id { get; set; }

        public Movie Movie { get; set; }

        [Range(0,1)]
        [Required(ErrorMessage = "You can only purchase one movie")]
        public int Amount { get; set; } = 1;


        public string ShoppingCartId { get; set; }
    }
}
