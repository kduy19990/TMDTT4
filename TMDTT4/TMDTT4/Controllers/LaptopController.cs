using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TMDTT4.Models;

namespace TMDTT4.Controllers
{
    public class LaptopController : Controller
    {
        TMDT5Entities1 db = new TMDT5Entities1();
        // GET: Laptop
        public ActionResult Index()
        {
            return View();
        }
        /////////////////////////////////////////////////////////////////////2
        public ActionResult getCompany()
        {
            var ListCompany = db.laptops.GroupBy(l => l.Company).Select(l => l.Key);
            return PartialView(ListCompany);
        }
        /////////////////////////////////////////////////////////////////////3
        public ActionResult getScreenResolution()
        {
            var ListScreenResolution = db.laptops.GroupBy(l => l.ScreenResolution).Select(l => l.Key);
            return PartialView(ListScreenResolution);
        }
        /////////////////////////////////////////////////////////////////////4
        public ActionResult getTypeName()
        {
            var ListScreenTypeName = db.laptops.GroupBy(l => l.TypeName).Select(l => l.Key);
            return PartialView(ListScreenTypeName);
        }
        /////////////////////////////////////////////////////////////////////5
        public ActionResult getInches()
        {
            var ListInches = db.laptops.GroupBy(l => l.Inches).Select(l => l.Key);
            return PartialView(ListInches);
        }
        /////////////////////////////////////////////////////////////////////6
        public ActionResult getCPU()
        {
            var ListCPU = db.laptops.GroupBy(l => l.Cpu).Select(l => l.Key);
            return PartialView(ListCPU);
        }
        /////////////////////////////////////////////////////////////////////6
        public ActionResult getSpeed()
        {
            var ListSpeed = db.laptops.GroupBy(l => l.Speed).Select(l => l.Key);
            return PartialView(ListSpeed);
        }
        /////////////////////////////////////////////////////////////////////8
        public ActionResult getMemory()
        {
            var ListMemory = db.laptops.GroupBy(l => l.Memory).Select(l => l.Key);
            return PartialView(ListMemory);
        }
        /////////////////////////////////////////////////////////////////////10
        public ActionResult getGPU()
        {
            var ListGPU = db.laptops.GroupBy(l => l.Gpu).Select(l => l.Key);
            return PartialView(ListGPU);
        }
        /////////////////////////////////////////////////////////////////////11
        public ActionResult getOS()
        {
            var ListOS = db.laptops.GroupBy(l => l.OpSys).Select(l => l.Key);
            return PartialView(ListOS);
        }
        /////////////////////////////////////////////////////////////////////14
        public ActionResult getWeight()
        {
            var ListWeight = db.laptops.GroupBy(l => l.Weight).Select(l => l.Key);
            return PartialView(ListWeight);
        }
    }
}