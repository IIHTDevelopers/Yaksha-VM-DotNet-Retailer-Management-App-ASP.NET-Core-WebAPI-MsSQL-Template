using Microsoft.EntityFrameworkCore;
using RetailerManagementApp.BusinessLayer.ViewModels;
using RetailerManagementApp.DataLayer;
using RetailerManagementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RetailerManagementApp.BusinessLayer.Services.Repository
{
    public class RetailerManagementRepository : IRetailerManagementRepository
    {
        private readonly RetailerManagementAppDbContext _dbContext;
        public RetailerManagementRepository(RetailerManagementAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Retailer> CreateRetailer(Retailer RetailerModel)
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