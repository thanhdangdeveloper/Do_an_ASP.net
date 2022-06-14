namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Account_login
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string UseName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string MatKhau { get; set; }
    }
}
