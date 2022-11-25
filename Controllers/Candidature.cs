using last_test_tech.Data;
using last_test_tech.Models;
using last_test_tech.ViewModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace last_test_tech.Controllers
{
    public class Candidature : Controller
    {
        public IWebHostEnvironment Hosting { get; }
        public Candidature(IWebHostEnvironment hosting)
        {
            Hosting = hosting;
        }
        candidaturedb db = new candidaturedb();

        public IActionResult Index(string SearchByName)
        {
            List<Candidat> candidatures = db.candidatures.ToList();

            if (!string.IsNullOrEmpty(SearchByName))
            {
                candidatures = candidatures.Where(c => c.prenom.ToLower().Contains(SearchByName.ToLower()) || c.nom.ToLower().Contains(SearchByName.ToLower())).ToList();
            }
            //retourner la list des candidatures
            return View(candidatures);
        }

        public IActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Create(candidaturecreateView model)
        {
            if (ModelState.IsValid)
            {
                string filename = string.Empty;
                if (model.Cv != null)
                {
                    //enregistrer les images dans le dossier uploads 
                    string uploads = Path.Combine(Hosting.WebRootPath, "uploads");
                    filename = model.nom + "_" +model.prenom +"_"+ model.Cv.FileName;
                    string fullpath = Path.Combine(uploads, filename);
                    model.Cv.CopyTo(new FileStream(fullpath, FileMode.Create));
                }
                Candidat candidat = new Candidat()
                {
                    nom = model.nom,
                    prenom = model.prenom,
                    mail = model.mail,
                    tele = model.tele,
                    niveau_detude = model.niveau_detude,
                    nbr_anne_exp = model.nbr_anne_exp,
                    dn_employeur = model.dn_employeur,
                    CV_path = filename
                };

                db.Add(candidat);
                //ajouter une candidature à la base de données
                db.SaveChanges();
                return RedirectToAction("Details",candidat);
            }
            else
            {
                return View();
            }
        }
        public IActionResult Details(int id)
        {
            Candidat candidat = db.candidatures.Where(c => c.Id == id).FirstOrDefault();
            //afficher les détails d'une candidature
            return View(candidat);
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
            //supprimer une candidature de la base de données
            return RedirectToAction("Index");
        }
        private void uploadfile(candidaturecreateView Candidature)
        {/*
            string filename = string.Empty;
            if (Candidature.Cv != null)
            {
                string uploads = Path.Combine(Hosting.WebRootPath, "uploads");
                filename = Candidature.nom.ToString() + Candidature.prenom.ToString();
                string fullpath = Path.Combine(uploads, filename);
                Candidature.Cv.CopyTo(new FileStream(fullpath, FileMode.Create));
            }

            return filename;*/
        }
    }
}
