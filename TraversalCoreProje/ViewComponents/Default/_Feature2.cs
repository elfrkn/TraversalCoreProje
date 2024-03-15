﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _Feature2 : ViewComponent
    {
        Feature2Manager feature2Manager = new Feature2Manager(new EfFeature2Dal());
        public IViewComponentResult Invoke()
        {
            var values = feature2Manager.TGetList();
            return View(values);
        }
    }
}
