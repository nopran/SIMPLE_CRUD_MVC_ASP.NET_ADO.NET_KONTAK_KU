namespace ContactPersonV1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web;

    [Table("TableCP")]
    public partial class TableCP
    {
        public int ID { get; set; }

        [Required]
        public string NAME { get; set; }
        [Required]
        public string PHONE { get; set; }
        [Required]
        public string EMAIL { get; set; }
        [Required]
        public string COMPANY { get; set; }
        [Required]
        public string COUNTRY { get; set; }
        [Required]
        public string ZIPCODE { get; set; }
        [Required]
        public string STATE { get; set; }
        [Required]
        public string CITY { get; set; }

       

        [DisplayName("Upload Foto")]
        [Required]
        public string FOTO { get; set; }
        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }
    }
}
