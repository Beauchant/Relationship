using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Models
{
    internal class AnneeAcademique
    {
        public int Id { get; set; }
        public string _AnneeAcademique { get; set; }
        public string DateDebut { get; set; }
        public string DateFin { get; set; }
        public string Active { get; set; }

        public AnneeAcademique() { }
        public AnneeAcademique(string anneeAcademique, string dateDebut, string dateFin, string active)
        {
            _AnneeAcademique = anneeAcademique;
            DateDebut = dateDebut;
            DateFin = dateFin;
            Active = active;
        }
    }
}
