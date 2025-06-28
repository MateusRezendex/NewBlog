﻿using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels.Categories;

public class EditorCategoryViewModel
{
    [Required (ErrorMessage ="O nome é obrigatório")]
    [StringLength (50, MinimumLength = 3, ErrorMessage = "Esse campo deve conter entre 3 e 50 caracteres.")]
    public string Name { get; set; }

    [Required]
    public string Slug { get; set; }
}
