namespace PetsStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            OrderStores = new HashSet<OrderStore>();
        }

        [StringLength(5)]
        public string id { get; set; }

        [Required]
        [StringLength(20)]
        public string fullName { get; set; }

        [Required]
        [StringLength(20)]
        public string addressCustomer { get; set; }

        [Required]
        [StringLength(20)]
        public string phoneNumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderStore> OrderStores { get; set; }
    }
}
