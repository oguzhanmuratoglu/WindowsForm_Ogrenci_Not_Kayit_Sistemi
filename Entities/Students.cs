using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenci_Not_Kayit_Sistemi.Entities
{
    public class Students
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(4)]
        public int? Numara { get; set; }
        [StringLength(15)]
        public string? Ad { get; set; }
        [StringLength(20)]
        public string? Soyad { get; set; }

        public int? Sinav1 { get; set; }
        public int? Sinav2 { get; set; }
        public int? Sinav3 { get; set; }

        [Range(0, 9999999999999999.99)]
        public decimal? Ortalama { get; set; }
        public bool? Durum { get; set; }
    }
}
