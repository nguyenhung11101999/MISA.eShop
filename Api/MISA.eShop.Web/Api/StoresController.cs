using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.ApplicationCore.Entities;
using MISA.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.eShop.Web.Api
{
    /// <summary>
    /// Lớp kế thừa BaseController
    /// </summary>
    /// CreatedBy: nmhung(23/3/2021)
    public class StoresController : BaseController<Store>
    {
        IStoreService _storeService;
        public StoresController(IStoreService storeService):base(storeService)
        {
            _storeService = storeService;
        }
    }
}
