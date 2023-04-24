namespace Nurgül_Eylül_Aydoğan_201103046.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Projedetay")]
    public partial class Projedetay
    {
        public int id { get; set; }

        public string resimyolu { get; set; }

        public string kisabilgi { get; set; }

        public string moduller { get; set; }

        public string genelozellikler { get; set; }

        public string teknikozellikler { get; set; }

        public string baslik { get; set; }

        public string sira { get; set; }
    }
}
