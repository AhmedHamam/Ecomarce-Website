namespace Ecomarce_MVC_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Orders = new HashSet<Order>();
            User_Card = new HashSet<User_Card>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int U_id { get; set; }

        [Required]
        [StringLength(500)]
        public string U_Name { get; set; }

        [Required]
        [StringLength(500)]
        public string U_Username { get; set; }

        [Required]
        [StringLength(500)]
        public string U_Email { get; set; }

        [Required]
        [StringLength(500)]
        public string U_Password { get; set; }

        [Required]
        [StringLength(500)]
        public string U_Image { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_Card> User_Card { get; set; }
    }
}
