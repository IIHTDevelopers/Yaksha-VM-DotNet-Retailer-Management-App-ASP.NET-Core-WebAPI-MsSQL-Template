using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RetailerManagementApp.BusinessLayer.Interfaces;
using RetailerManagementApp.BusinessLayer.ViewModels;
using RetailerManagementApp.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using ManagementApp.Entities;

namespace RetailerManagementApp.Controllers
{
    [ApiController]
    public class RetailerManagementController : ControllerBase
    {
        private readonly IRetailerManagementService  _retailerService;
        public RetailerManagementController(IRetailerManagementService retailerservice)
        {
             _retailerService = retailerservice;
        }

        [HttpPost]
        [Route("create-retailer")]
        [AllowAnonymous]
        public async Task<IActionResult> CreateRetailer([FromBody] Retailer model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpPut]
        [Route("update-retailer")]
        public async Task<IActionResult> UpdateRetailer([FromBody] RetailerViewModel model)
        {
            //write your code here
            throw new NotImplementedException();
        }

      
        [HttpDelete]
        [Route("delete-retailer")]
        public async Task<IActionResult> DeleteRetailer(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("get-retailer-by-id")]
        public async Task<IActionResult> GetRetailerById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("get-all-retailers")]
        public async Task<IEnumerable<Retailer>> GetAllRetailers()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
