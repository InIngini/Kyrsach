﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Курсач.Data.DTO;
using Курсач.Data.Entities;

namespace Курсач.Core.Interfaces
{
    public interface ISchemeService
    {
        Task<Scheme> CreateScheme(SchemeData schemeData);
        Task<Scheme> GetScheme(int id);
        Task UpdateScheme(int id, int connectionId);
        Task DeleteScheme(int id);
    }
}
