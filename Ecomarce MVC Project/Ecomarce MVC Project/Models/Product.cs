namespace Ecomarce_MVC_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Order_Details = new HashSet<Order_Details>();
            User_Card = new HashSet<User_Card>();
        }

        [Key]
        public int Pro_Id { get; set; }

        [Required]
        [StringLength(500)]
        public string Pro_Name { get; set; }

        [Required]
        [StringLength(500)]
        public string Pro_Desc { get; set; }

        [Required]
        [StringLength(500)]
        public string Pro_Image { get; set; }

        public double? Pro_Disqount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_Details> Order_Details { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_Card> User_Card { get; set; }
    }
}
