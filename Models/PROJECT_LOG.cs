using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("PROJECT_LOG")]
    public class PROJECT_LOG
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int PROJECTS_ID { get; set; }

        //[ForeignKey("PROJECTSLOGPROJECTID")]
        //public PROJECTS PROJECTS_LOG_PROJECT_ID { get; set; }

        public int PROJECTS_DETAILS_ID { get; set; }

        //[ForeignKey("PROJECTSLOGPROJECTDETAILS_ID")]
        //public PROJECT_DETAILS PROJECTS_LOG_PROJECT_DETAILS_ID { get; set; }

        public int? MAKE_BY { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? CREATED_AT { get; set; }

        [System.ComponentModel.DefaultValue("A")]
        public string? STATUS { get; set; }
    }
}
