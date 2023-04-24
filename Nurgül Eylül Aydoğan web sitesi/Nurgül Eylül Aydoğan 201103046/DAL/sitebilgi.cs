namespace Nurgül_Eylül_Aydoğan_201103046.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sitebilgi")]
    public partial class sitebilgi
    {
        public int id { get; set; }

        [StringLength(500)]
        public string firmaadi { get; set; }

        [StringLength(50)]
        public string logoyolu { get; set; }

        [StringLength(50)]
        public string kucuklogoyolu { get; set; }

        [StringLength(50)]
        public string telefon { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(500)]
        public string adres { get; set; }

        public string harita { get; set; }
    }
}
