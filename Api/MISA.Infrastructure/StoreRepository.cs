﻿using Microsoft.Extensions.Configuration;
using MISA.ApplicationCore.Entities;
using MISA.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Infrastructure
{
    /// <summary>
    /// Lớp tương tác với đối tượng cửa hàng trong cơ sở dữ liệu
    /// </summary>
    /// CreatedBy: nmhung(23/3/2021)
    public class StoreRepository:BaseRepository<Store>, IStoreRepository
    {
        public StoreRepository(IConfiguration configuration) : base(configuration)
        {

        }
    }
}
