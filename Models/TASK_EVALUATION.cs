using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Models
{
    [Table("TASK_EVALUATION")]
    public class TASK_EVALUATION
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public int TASK_ID { get; set; }
        [ForeignKey("TASK_EVALUATIONTASKID")]
        public TASKS TASK_EVALUATION_TASK_ID { get; set; }

        [Required]
        public int EVALUATION_BY { get; set; }

        //[ForeignKey("EVALUATIONEMPLOYEEID")]
        //public EMPLOYEE EVALUATION_EMPLOYEE_ID { get; set; }

        public int MARKS { get; set; }

        public string REMARKS { get; set; }

        public int REF_BEST_USER { get; set; }

        //[ForeignKey("BESTEMPLOYEEID")]
        //public EMPLOYEE BEST_EMPLOYEE_ID { get; set; }

        public int? MAKE_BY { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? CREATED_AT { get; set; }

        [System.ComponentModel.DefaultValue("A")]
        public string? STATUS { get; set; }

    }
}
