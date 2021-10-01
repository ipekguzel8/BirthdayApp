﻿using BirthdayApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BirthdayApp.Controllers
{
    public class DavetiyeController : ApiController
    {
        [HttpGet]
        public IEnumerable<DavetiyeModel> Katilanlar()
        {
            return Veritabani.Liste().Where(i => i.KatilmaDurumu == true);
        }
        [HttpPost]
        public void Ekle(DavetiyeModel model)
        {
            if (ModelState.IsValid)
            {
                Veritabani.Add(model);
            }
        }
    }
}
