using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EcommerceProject.ViewModels;
using Models;

namespace EcommerceProject.Automapper_Config
{
    public class AutomapperPrfoile:Profile
    {
        public AutomapperPrfoile()
        {
            CreateMap<ViewModel_Product, Product>();
            CreateMap<Product, ViewModel_Product>();
            CreateMap<ViewModel_Customer, Customer>();
            CreateMap<Customer, ViewModel_Customer>();
            
        }
    }
}
