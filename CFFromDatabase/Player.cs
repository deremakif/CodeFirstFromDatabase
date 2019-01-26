namespace CFFromDatabase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Player
    {
        public int Id { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        public DateTime DogumTarihi { get; set; }

        public int? Team_Id { get; set; }

        public virtual PlayerAddress PlayerAddress { get; set; }

        public virtual Team Team { get; set; }
    }
}
