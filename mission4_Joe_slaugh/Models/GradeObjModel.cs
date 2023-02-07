using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mission4_Joe_slaugh.Models
{
    public class GradeObjModel
    {
        [Required(ErrorMessage = "The field Assignments must be greater than 1 and less than 100.")]
        [Display(Name = "Assignments")]
        [Range(0, 101, ErrorMessage = "The field Assignments must be greater than {1} and less than {100}.")]
        public float? assignments { get; set; }

        [Required(ErrorMessage = "The field Group Project must be greater than 1 and less than 100.")]
        [Display(Name = "Group Project")]
        [Range(0, 101, ErrorMessage = "The field Group Project must be greater than {1} and less than {100}.")]
        public float? groupproject { get; set; }

        [Required(ErrorMessage = "The field Quizes must be greater than 1 and less than 100.")]
        [Display(Name = "Quizes")]
        [Range(0, 101, ErrorMessage = "The field Quizes must be greater than {1} and less than {100}.")]
        public float? quizzes { get; set; }

        [Required(ErrorMessage = "The field Midterm must be greater than 1 and less than 100.")]
        [Display(Name = "Midterm")]
        [Range(0, 101, ErrorMessage = "The field Midterm must be greater than {1} and less than {100}.")]
        public float? midterm { get; set; }


        [Required(ErrorMessage = "The field Final must be greater than 1 and less than 100.")]
        [Display(Name = "Final")]
        [Range(0, 101, ErrorMessage = "The field Final must be greater than {1} and less than {100}.")]
        public float? final { get; set; }



        [Required(ErrorMessage = "The field Intex must be greater than 1 and less than 100.")]
        [Display(Name = "Intex")]
        [Range(0, 101, ErrorMessage = "The field Intex must be greater than {1} and less than {100}.")]
        public float? intex { get; set; }


    }
}
