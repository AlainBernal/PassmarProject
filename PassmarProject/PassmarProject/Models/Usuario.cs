namespace PassmarProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USUARIO")]
    public partial class USUARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USUARIO()
        {
            VENTA = new HashSet<VENTA>();
        }

        [Key]
        public int USU_ID { get; set; }

        [StringLength(25)]
        public string USU_NOM { get; set; }

        [StringLength(25)]
        public string USU_MAIL { get; set; }

        [StringLength(13)]
        public string USU_TEL { get; set; }

        public int? USU_ID_ROL { get; set; }

        [StringLength(12)]
        public string USU_PASS { get; set; }

        public virtual ROLES ROLES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENTA> VENTA { get; set; }
    }
}
