namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHoaDon { get; set; }

        public DateTime? NgayLap { get; set; }

        [Column(TypeName = "money")]
        public decimal? GiaTien { get; set; }

        [StringLength(30)]
        public string TenKhachHang { get; set; }

        public int? SoLuong { get; set; }

        public int? MaKhachHang { get; set; }

        public bool? MaPhanQuyen { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual PhanQuen PhanQuen { get; set; }
    }
}
