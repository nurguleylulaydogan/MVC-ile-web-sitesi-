namespace Nurgül_Eylül_Aydoğan_201103046.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kurumsal")]
    public partial class Kurumsal
    {
        public int id { get; set; }

        [StringLength(50)]
        public string baslik { get; set; }

        public string icerik { get; set; }
    }
}
