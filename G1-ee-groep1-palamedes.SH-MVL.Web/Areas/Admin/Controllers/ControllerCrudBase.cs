﻿using G1_ee_groep1_palamedes.SH_MVL.API.Models;
using G1_ee_groep1_palamedes.SH_MVL.Web.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace G1_ee_groep1_palamedes.SH_MVL.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public abstract partial class ControllerCrudBase<T, R> : Controller 
        where T : EntityBase
        where R : IConfiguration
    {
        private readonly R configuration;
        private readonly T entity;

        private readonly string baseUri;
        private string Uri { get; set; }

        private IEnumerable<T> entities;
        private readonly string entityName;


        public ControllerCrudBase(T t, R r)
        {
            configuration = r;
            entity = t;
            baseUri = configuration.GetSection("Data").GetSection("ApiBaseUri").Value;
            entityName = entity.GetType().Name;
            Uri = entityName.EndsWith("y") ? $"{baseUri}{entityName.Replace("y", "ies")}" : $"{baseUri}{entity.GetType().Name}s";
        }


        // GET: Admin/T
        public virtual async Task<IActionResult> Index()
        {
            entities = await WebApiHelper.GetApiResultAsync<List<T>>(Uri);
            return View(entities);
        }

    }
}
