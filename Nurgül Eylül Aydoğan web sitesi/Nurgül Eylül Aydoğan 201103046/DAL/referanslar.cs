namespace Nurgül_Eylül_Aydoğan_201103046.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("referanslar")]
    public partial class referanslar
    {
        public int id { get; set; }

        [StringLength(500)]
        public string resimyolu { get; set; }
    }
}
