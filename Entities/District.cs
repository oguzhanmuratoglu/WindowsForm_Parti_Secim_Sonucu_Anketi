using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parti_Secim_Anketi.Entities
{
    public class District
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(20)]
        public string? Ilce { get; set; }
        [Range(0, 9999999999999999.99)]
        public decimal? AParti { get; set; }
        [Range(0, 9999999999999999.99)]
        public decimal? BParti { get; set; }
        [Range(0, 9999999999999999.99)]
        public decimal? CParti { get; set; }
        [Range(0, 9999999999999999.99)]
        public decimal? DParti { get; set; }
        [Range(0, 9999999999999999.99)]
        public decimal? EParti { get; set; }

    }
}
