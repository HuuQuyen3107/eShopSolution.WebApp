using eShopSolution.Application.Sales.Orders;
using eShopSolution.ViewModels.Sales;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Order([FromBody] CheckoutRequest request, OrderDetailVm viewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var orders = await _orderService.Order(request);
            if (!orders.IsSuccessed)
                return BadRequest();
            var orderDetail = await _orderService.GetOrder(viewModel.ProductId, viewModel.Quantity);
            return CreatedAtAction(nameof(GetOrder), new { id = orders }, orderDetail);
        }

        [HttpGet("/languageId/carts/{productId}/{quantity}")]
        public async Task<IActionResult> GetOrder(int productId, int quantity)
        {
            var order = await _orderService.GetOrder(productId, quantity);
            if (order == null)
                return BadRequest("Cannot find Product");
            return Ok();
        }
    }
}