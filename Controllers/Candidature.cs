using last_test_tech.Data;
using last_test_tech.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace last_test_tech.Controllers
{
    public class Candidature : Controller
    {
        candidaturedb db = new candidaturedb();
        public IActionResult Index()
        {
            List<Candidat> candidatures = db.candidatures.ToList();
            return View(candidatures);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Candidat model)
        {
            if (ModelState.IsValid)
            {
                db.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            Candidat candidat = db.candidatures.Where(c => c.Id == id).FirstOrDefault();
            if(candidat != null)
            {
                db.candidatures.Remove(candidat);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        private void uploadfile(Candidat Candidature)
        {
            /*
            string filename = string.Empty;
            if (Candidature.cv != null)
            {
                string uploads = Path.Combine(Hosting.WebRootPath, "uploads");
                filename = Candidature.nom.ToString() + Candidature.prenom.ToString();
                string fullpath = Path.Combine(uploads, filename);
                Candidature.cv.CopyTo(new FileStream(fullpath, FileMode.Create));
            }
            return filename;
            */
        }
    }
}
