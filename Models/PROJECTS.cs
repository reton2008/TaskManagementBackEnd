using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Models
{
    [Table("PROJECTS")]
    public class PROJECTS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; } 

        [Required]
        public int PROJECT_NAME { get; set; }

        [Required]
        public int PROJECT_MANAGER { get; set; }

        //[ForeignKey("TEAMMANAGERID")]
        //public EMPLOYEE TEAM_MANAGER_Id { get; set; }

        [Required]
        public int PROJECT_TEAM { get; set; }

        //[ForeignKey("PROJECTTEAMID")]
        //public TEAMS PROJECT_TEAM_ID { get; set; }

        [Required]
        public DateTime? START_DATE { get; set; }

        [Required]
        public DateTime? END_DATE { get; set; }

        public int? MAKE_BY { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? CREATED_AT { get; set; }

        [System.ComponentModel.DefaultValue("A")]
        public string? STATUS { get; set; }
    }
}
