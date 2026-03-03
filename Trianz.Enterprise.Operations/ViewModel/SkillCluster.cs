using System;
using System.ComponentModel.DataAnnotations;

namespace Trianz.Enterprise.Operations.ViewModel
{
    public class SkillCluster
    {
        public int SKILLCLSTRID { get; set; }

        [Required(ErrorMessage = "Skill Code is Requirde")]
        [Display(Name = "Skill Code")]
        public string SKILLCODE { get; set; }
        public string CLSTRDESC { get; set; }
        [Display(Name = "Cluster JD")]
        [Required]
        public string CLSTRJD { get; set; }
        public Nullable<int> CLSTRJDVER { get; set; }
        public int PRTCSKILLID { get; set; }
        [Required(ErrorMessage = "Practice is Requirde")]
        [Display(Name = "Practice")]
        public string PRACTICE { get; set; }
        [Display(Name = "Skill Cluster")]
        public string SKILLCLUSTER { get; set; }
        [Display(Name = "Cluster Skill")]
        public string CSKILLS { get; set; }
       
    }
}