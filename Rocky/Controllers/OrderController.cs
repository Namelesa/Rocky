using Microsoft.AspNetCore.Mvc;
using Rocky_DataAccess.Repository.IRepository;
using Rocky_Models.ViewModels;
using Rocky_Utility;
using Rockz_Utility.BrainTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderDetailRepository _orderDRepo;
        private readonly IOrderHeaderRepository _orderHRepo;
        private readonly IBrainTreeGate _brain;

       

        public OrderController(IOrderDetailRepository orderDRepo, IOrderHeaderRepository orderHRepo, IBrainTreeGate brain)
        {
            _orderHRepo = orderHRepo;
            _orderDRepo = orderDRepo;
            _brain = brain;
        }

        public IActionResult Index()
        {
            OrderListVM orderListVM = new OrderListVM()
            {
                OrderHList = _orderHRepo.GetAll(),
                StatusList = WC.listStatus.ToList().Select(i => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem 
                {
                    Text = i,
                    Value = i
                })
            };
            return View(orderListVM);
        }
    }
}
