﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataTransferObjects;
using DataTransferObjects.Requests;
using Microsoft.AspNetCore.Authorization;
using WebAPI.Services.Interfaces;

namespace WebAPI.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdministratorController : CrudController<DataTransferObjects.Administrator, object, DataTransferObjects.Requests.AdministratorKorisnickiNalogInsertRequest, DataTransferObjects.Requests.AdministratorKorisnickiNalogUpdateRequest>
    {
        public AdministratorController(ICrudService<Administrator, object, AdministratorKorisnickiNalogInsertRequest, AdministratorKorisnickiNalogUpdateRequest> service) : base(service)
        {
        }
    }
}
