using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfDemo.Web.ContactService;
using WcfDemo.Web.Models;

namespace WcfDemo.Web.Lib
{
    public static class AutoMapperConfiguration
    {
        public static void Configure()
        {
            ConfigureContactMapping();
        }

        private static void ConfigureContactMapping()
        {
            Mapper.CreateMap<Contact, ContactViewModel>();
            Mapper.CreateMap<ContactViewModel, Contact>();
        }
    }
}