using eShopSolution.Data.EF;
using eShopSolution.Data.Entities;
using eShopSolution.Utilities.Constants;
using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.Sales;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Sales.Orders
{
    public class OrderService : IOrderService
    {
        private readonly EShopDbContext _context;

        public OrderService(EShopDbContext context)
        {
            _context = context;
        }

        public async Task<ApiResult<bool>> Order(CheckoutRequest request)
        {
            var carts = await _context.Carts.FindAsync(request);
            var orderDetails = new List<CheckoutVm>();
            if (orderDetails == null && carts != null)
            {
                orderDetails.Add(new CheckoutVm()
                {
                    Id = carts.Id,
                    Name = request.Name,
                    Email = request.Email,
                    Address = request.Address,
                    PhoneNumber = request.PhoneNumber,
                    ProductId = carts.ProductId,
                    Quantity = carts.Quantity
                });
            }
            else
            {
                orderDetails.Add(new CheckoutVm()
                {
                    Id = carts.Id,
                    Name = SystemConstants.ProductConstants.NA,
                    Email = SystemConstants.ProductConstants.NA,
                    Address = SystemConstants.ProductConstants.NA,
                    PhoneNumber = SystemConstants.ProductConstants.NA,
                    ProductId = carts.ProductId,
                    Quantity = carts.Quantity
                });
            }

            var orderDetail = new OrderDetail()
            {
                OrderId = carts.Id,
                ProductId = carts.ProductId,
                Quantity = carts.Quantity
            };

            _context.OrderDetails.Add(orderDetail);
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<bool>();
        }

        public async Task<List<CheckoutVm>> GetOrder(int orderId, int quantity)
        {
            return await _context.OrderDetails.Where(x => x.Quantity != 0)
                        .Select(i => new CheckoutVm()
                        {
                            Id = orderId,
                            ProductId = i.ProductId,
                            Quantity = quantity
                        }).ToListAsync();
        }
    }
}