using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.Sales;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Sales.Orders
{
    public interface IOrderService
    {
        public Task<ApiResult<bool>> Order(CheckoutRequest request);

        public Task<List<CheckoutVm>> GetOrder(int orderId, int quantity);
    }
}