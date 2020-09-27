﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.ViewModels
{
    public class CartSummaryViewModel
    {
        public int CartCount { get; set; }
        public decimal CartTotal { get; set; }

        public CartSummaryViewModel()
        {

        }

        public CartSummaryViewModel(int cartCount, decimal cartTotal)
        {
            this.CartCount = cartCount;
            this.CartTotal = cartTotal;
        }
    }
}
