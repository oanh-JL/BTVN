namespace PetsStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pet")]
    public partial class Pet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pet()
        {
            orderDetails = new HashSet<orderDetail>();
        }

        [StringLength(5)]
        public string id { get; set; }

        [Required]
        [StringLength(20)]
        public string petName { get; set; }

        [Required]
        [StringLength(20)]
        public string petSpecies { get; set; }

        [Required]
        [StringLength(20)]
        public string petBreed { get; set; }

        public bool available { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orderDetail> orderDetails { get; set; }
    }

}
