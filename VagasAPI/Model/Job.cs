using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VagasAPI.Model
{
    public class Job
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Type { get; set; } = string.Empty;

        [Column(TypeName = "varchar")]
        [StringLength(5000)]
        public string Url { get; set; } = string.Empty;
        public DateOnly? Created_at { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Company { get; set; } = string.Empty;
        [Column(TypeName = "varchar")]
        [StringLength(5000)]
        public string Company_url { get; set; } = string.Empty;

        [Column(TypeName = "varchar")]
        [StringLength(500)]
        public string Location { get; set; } = string.Empty;

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Title { get; set; } = string.Empty;

        [Column(TypeName = "varchar")]
        [StringLength(500)]
        public string Description { get; set; } = string.Empty;

        [Column(TypeName = "boolean")]
        public bool How_to_apply { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(5000)]
        public string Company_logo { get; set; } = string.Empty;
    }
}
