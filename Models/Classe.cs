using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class Classe
    {
        public int Id { get; set; }
        [Display(Name = "Classe")]
        public string ClasseName { get; set; }
        public string AnneeAcademiqueId { get; set; }

        public Classe() { }
        public Classe(string classe, string anneeAcademiqueId )
        {
            ClasseName = classe;
            AnneeAcademiqueId = anneeAcademiqueId;
        }
    }
}

