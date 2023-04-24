namespace Nurgül_Eylül_Aydoğan_201103046.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cozumler")]
    public partial class Cozumler
    {
        public int id { get; set; }

        public string resimyolu { get; set; }

        public string bilgi { get; set; }

        public string sira { get; set; }

        public string baslik { get; set; }
    }
}
