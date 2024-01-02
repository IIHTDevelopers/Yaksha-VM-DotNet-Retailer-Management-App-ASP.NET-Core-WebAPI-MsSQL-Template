using RetailerManagementApp.BusinessLayer.Interfaces;
using RetailerManagementApp.BusinessLayer.Services.Repository;
using RetailerManagementApp.BusinessLayer.ViewModels;
using RetailerManagementApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RetailerManagementApp.BusinessLayer.Services
{
    public class RetailerManagementService : IRetailerManagementService
    {
        private readonly IRetailerManagementRepository _repo;

        public RetailerManagementService(IRetailerManagementRepository repo)
        {
            _repo = repo;
        }

        public async Task<Retailer> CreateRetailer(Retailer employeeRetailer)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteRetailerById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Retailer> GetAllRetailers()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<Retailer> GetRetailerById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<Retailer> UpdateRetailer(RetailerViewModel model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
