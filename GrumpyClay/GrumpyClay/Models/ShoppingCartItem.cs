using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrumpyClay.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Sculpture Sculpture { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }

    }
}
