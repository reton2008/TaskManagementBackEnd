using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Models
{
    [Table("PROJECT_DETAILS")]
    public class PROJECT_DETAILS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public int PROJECT_ID { get; set; }

        //[ForeignKey("PROJECTSDETAILSID")]
        //public PROJECTS PROJECTS_DETAILS_ID { get; set; }

        [Required]
        public int PROJECT_TEAM { get; set; }

        //[ForeignKey("PROJECTTEAMSID")]
        //public TEAMS PROJECT_TEAMS_ID { get; set; }

        public string? REMARKS { get; set; }

        public int? MAKE_BY { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? CREATED_AT { get; set; }

        [System.ComponentModel.DefaultValue("A")]
        public string? STATUS { get; set; }

    }
}
