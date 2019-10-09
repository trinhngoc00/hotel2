namespace PhanMemQuanLyKhachSan.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Phong")]
    public partial class Phong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phong()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }

        public int PhongID { get; set; }

        public int? LoaiPhongID { get; set; }

        public int? GiaPhong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }

        public virtual LoaiPhong LoaiPhong { get; set; }
    }
    public partial class Phong
    {
        public static List<Phong> GetAll()
        {
            QLKSModel context = new QLKSModel();
            return context.Phongs.ToList();
        }
        public static Phong GetPhong(int vatTuId)
        {
            QLKSModel context = new QLKSModel();
            return context.Phongs.Where(p => p.PhongID == vatTuId).FirstOrDefault();

        }
    }
}
