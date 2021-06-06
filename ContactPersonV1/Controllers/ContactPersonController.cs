using ContactPersonV1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactPersonV1.Controllers
{
    public class ContactPersonController : Controller
    {
        // GET: ContactPerson
        public ActionResult Index()
        {
            using (DBmodel dBmodel = new DBmodel())
            {
                return View(dBmodel.TableCPs.ToList());

            }
        }

        // GET: ContactPerson/Details/5
        public ActionResult Details(int id)
        {
            using (DBmodel dBmodel = new DBmodel())
            {

                return View(dBmodel.TableCPs.Where(x => x.ID == id).FirstOrDefault());

            }
        }

        // GET: ContactPerson/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContactPerson/Create
        [HttpPost]
        public ActionResult Create(TableCP tableCP)
        {
            try
            {
                using (DBmodel dBmodel = new DBmodel())
                {

                    string fileName = Path.GetFileNameWithoutExtension(tableCP.ImageFile.FileName);
                    string extension = Path.GetExtension(tableCP.ImageFile.FileName);
                    fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    tableCP.FOTO = "../Image/" + fileName;
                    fileName = Path.Combine(Server.MapPath("../Image/"), fileName);
                    tableCP.ImageFile.SaveAs(fileName);


                    dBmodel.TableCPs.Add(tableCP);
                    dBmodel.SaveChanges();

                }

                ModelState.Clear();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ContactPerson/Edit/5
        public ActionResult Edit(int id)
        {
            using (DBmodel dBmodel = new DBmodel())
            {

                return View(dBmodel.TableCPs.Where(x => x.ID == id).FirstOrDefault());

            }
        }

        // POST: ContactPerson/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, TableCP tableCP)
        {
            try
            {
                // TODO: Add update logic here
                using (DBmodel dBmodel = new DBmodel())
                {
                    dBmodel.Entry(tableCP).State = EntityState.Modified;
                    dBmodel.SaveChanges();
                }
                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ContactPerson/Delete/5
        public ActionResult Delete(int id)
        {
            using (DBmodel dBmodel = new DBmodel())
            {

                return View(dBmodel.TableCPs.Where(x => x.ID == id).FirstOrDefault());

            }
        }

        // POST: ContactPerson/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using (DBmodel dBmodel = new DBmodel())
                {
                    TableCP tableCP1 = dBmodel.TableCPs.Where(x => x.ID == id).FirstOrDefault();
                    dBmodel.TableCPs.Remove(tableCP1);
                    dBmodel.SaveChanges();
                }
                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
