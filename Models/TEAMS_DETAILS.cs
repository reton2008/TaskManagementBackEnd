using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Models
{
    [Table("TEAMS_DETAILS")]
    public class TEAMS_DETAILS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public int TEAM_ID{ get; set; }

        //[ForeignKey("TEAMDETAILSID")]
        //public TEAMS TEAM_DETAILS_ID { get; set; }


        [Required]
        public int? TEAMS_EMPLOYEE { get; set; }

        //[ForeignKey("TEAMSEMPLOYEEID")]
        //public EMPLOYEE TEAMS_EMPLOYEE_ID { get; set; }

        public int? MAKE_BY { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? CREATED_AT { get; set; }

        [System.ComponentModel.DefaultValue("A")]
        public string? STATUS { get; set; }


    }
}
