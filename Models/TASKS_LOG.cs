using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Models
{
    [Table("TASKS_LOG")]

    public class TASKS_LOG
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }


        [Required]
        public int TASK_ID { get; set; }
        [ForeignKey("TASKSLOGTASKID")]
        public TASKS TASKS_LOG_TASK_ID { get; set; }

        public string CURRENT_STATUS { get; set; }
        public string PREVIOUS_STATUS { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime STATUS_CHANGE_AT { get; set; }
        public int? MAKE_BY { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? CREATED_AT { get; set; }

        [System.ComponentModel.DefaultValue("A")]
        public string? STATUS { get; set; }

    }
}
