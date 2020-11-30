using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test01.Controllers
{
    public class PenggunaController : Controller
    {
        // GET: PenggunaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PenggunaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PenggunaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PenggunaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PenggunaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PenggunaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PenggunaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PenggunaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
