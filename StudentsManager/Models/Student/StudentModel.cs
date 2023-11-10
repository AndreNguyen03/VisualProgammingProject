using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace StudentsManager.Model
{
    public class StudentModel 
    {
        //Fields
        private string id;
        private string name;
        private string className;
        private float mathScore;
        private float literatureScore;
        private float englishScore;

        //Properties - Validations
        [DisplayName("ID")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Student id is required")]
        [StringLength(8, ErrorMessage = "Student name must be 8 characters")]
        public string Id { get => id; set => id = value; }

        [DisplayName("Student Name")]
        [Required(AllowEmptyStrings = false,ErrorMessage = "Student name is required")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Student name must be between 10 and 100 characters")]
        public string Name { get => name; set => name = value; }

        [DisplayName("Class Name")]
        [Required(AllowEmptyStrings = false,ErrorMessage = "Student class name is required")]
        [StringLength(10, MinimumLength = 8, ErrorMessage = "Student name must be between 8 and 10 characters")]
        public string ClassName { get => className; set => className = value; }

        [DisplayName("Math")]
        [Required(AllowEmptyStrings = false,ErrorMessage = "Student math Score is required")]
        public float MathScore { get => mathScore; set => mathScore = value; }

        [DisplayName("Literature")]
        [Required(AllowEmptyStrings = false,ErrorMessage = "Student literature Score is required")]
        public float LiteratureScore { get => literatureScore; set => literatureScore = value; }

        [DisplayName("English")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Student english Score is required")]
        public float EnglishScore { get => englishScore; set => englishScore = value; }
    }
}
