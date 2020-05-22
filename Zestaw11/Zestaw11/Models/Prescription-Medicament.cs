using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Zestaw11.Models
{
    public class Prescription_Medicament
    {
        
        [Key]
        [ForeignKey("Prescription")]
        public int? IdPrescription { get; set; }
        public int? Dose { get; set; }
        public string Details { get; set; }
    }
}
