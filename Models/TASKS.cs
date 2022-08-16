using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Models
{
    [Table("TASKS")]
    public class TASKS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int PROJECT_ID { get; set; }

        [ForeignKey("TASKSPROJECTID")]
        public PROJECTS TASK_PROJECT_ID { get; set; }

        [Required]
        [System.ComponentModel.DefaultValue("N")]

        public string TASK_STATUS { get; set; }

        public int? MAKE_BY { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? CREATED_AT { get; set; }

        [System.ComponentModel.DefaultValue("A")]
        public string? STATUS { get; set; }

    }
}
