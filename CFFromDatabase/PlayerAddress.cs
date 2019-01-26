namespace CFFromDatabase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PlayerAddress
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PlayerAddressId { get; set; }

        public string City { get; set; }

        public int Street { get; set; }

        public int PostCode { get; set; }

        public virtual Player Player { get; set; }
    }
}
