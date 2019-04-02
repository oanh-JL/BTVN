namespace PetsStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderStore")]
    public partial class OrderStore
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderStore()
        {
            orderDetails = new HashSet<orderDetail>();
        }

        [StringLength(5)]
        public string id { get; set; }

        [Required]
        [StringLength(5)]
        public string customerId { get; set; }

        [Column(TypeName = "date")]
        public DateTime OrderDate { get; set; }

        public virtual Customer Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orderDetail> orderDetails { get; set; }
    }
}
