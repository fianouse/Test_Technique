using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace last_test_tech.ViewModel
{
    public class candidaturecreateView
    {
        [Required]
       
        [DisplayName("Nom")]
        public string nom { get; set; }
        [Required]
        
        [DisplayName("Prenom")]
        public string prenom { get; set; }
        [Required]
        
        [DisplayName("Mail")]
        [EmailAddress]
        public string mail { get; set; }
        [Required]
      
        [DisplayName("Tele")]
        public int tele { get; set; }
        [Required]
  
        [DisplayName("Niveau d’étude")]
        public string niveau_detude { get; set; }
        [Required]
       
        [DisplayName("Nombre d’années d’expérience")]
        public int nbr_anne_exp { get; set; }
        [Required]
        
        [DisplayName("Dernier employeur")]
        public string dn_employeur { get; set; }

        [Required]
        [DisplayName("CV Upload")]
        public IFormFile Cv { get; set; }
    }
}
