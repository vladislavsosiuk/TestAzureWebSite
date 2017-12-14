namespace DataLayer.DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WorkerInfo")]
    public partial class WorkerInfo
    {
        [Key]
        [Column(Order = 0)]
        public short WorkerId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string Name { get; set; }
    }
}
