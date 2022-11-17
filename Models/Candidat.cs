using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace last_test_tech.Models
{
    [Table("Candidatures",Schema ="CD") ]
    public class Candidat
    {
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Required]
        [Display(Name = "nom")]
        [Column(TypeName ="varchar(50)")]
        [DisplayName("Nom")]
        public string nom { get; set; }
        [Required]
        [Display(Name = "prenom")]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Prenom")]
        public string prenom { get; set; }
        [Required]
        [Display(Name = "mail")]
        [Column(TypeName = "varchar(200)")]
        [DisplayName("Mail")]
        [EmailAddress]
        public string mail { get; set; }
        [Required]
        [Display(Name = "tele")]
        [Column(TypeName = "int")]
        [DisplayName("Tele")]
        public int tele { get; set; }
        [Required]
        [Display(Name = "niveau_detude")]
        [Column(TypeName = "varchar(25)")]
        [DisplayName("Niveau d’étude")]
        public string niveau_detude { get; set; }
        [Required]
        [Display(Name = "nbr_anne_exp")]
        [Column(TypeName = "int")]
        [DisplayName("Nombre d’années d’expérience")]
        public int nbr_anne_exp { get; set; }
        [Required]
        [Display(Name = "dn_employeur")]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Dernier employeur")]
        public string dn_employeur { get; set; }

        [Display(Name = "dn_employeur")]
        [Column(TypeName = "varchar(200)")]
        public string CV_path { get; set; }
    }
}
