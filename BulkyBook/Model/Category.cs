using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Book.Model
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; }

        [Display(Name = "Category Name")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }


    }
}
