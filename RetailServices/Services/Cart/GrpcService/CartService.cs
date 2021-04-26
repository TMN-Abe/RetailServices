using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetailServices.Services.Cart.GrpcService
{
    public class CartService
    {
        private readonly ILogger<CartService> _logger;

        public  CartService(ILogger<CartService> logger)
        {
            _logger = logger;
        }


    }
}
