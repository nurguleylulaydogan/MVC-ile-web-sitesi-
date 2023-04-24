namespace Nurgül_Eylül_Aydoğan_201103046.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Anasayfa")]
    public partial class Anasayfa
    {
        public int id { get; set; }

        public string sliderbolumu { get; set; }

        public string baslik { get; set; }

        public string tanitim { get; set; }
    }
}
