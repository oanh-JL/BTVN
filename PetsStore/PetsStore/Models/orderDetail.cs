namespace PetsStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("orderDetail")]
    public partial class orderDetail
    {
        [StringLength(5)]
        public string id { get; set; }

        [Required]
        [StringLength(5)]
        public string orderId { get; set; }

        [Required]
        [StringLength(5)]
        public string petId { get; set; }

        public double price { get; set; }

        public virtual OrderStore OrderStore { get; set; }

        public virtual Pet Pet { get; set; }
    }
}
