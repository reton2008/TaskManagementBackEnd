using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Models
{
    [Table("TEAMS")]
    public class TEAMS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string? TEAM_NAME { get; set; }

        [Required]
        public int? TEAM_MANAGER { get; set; }

        //[ForeignKey("TEAMMANAGERId")]
        //public EMPLOYEE TEAM_MANAGER_Id { get; set; }

        [Required]
        public int? TEAM_LEAD { get; set; }

        //[ForeignKey("TEAMLEADID")]
        //public EMPLOYEE TEAM_LEAD_ID { get; set; }

        public int? MAKE_BY { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? CREATED_AT { get; set; }

        [System.ComponentModel.DefaultValue("A")]
        public string? STATUS { get; set; }

    }
}
