﻿using System.ComponentModel.DataAnnotations;

namespace AcademiaNet.Shared.Entites;

public class Institution
{
    [Key]
    public int InstitutionID { get; set; }

    [MaxLength(100)]
    [Required]
    public string Name { get; set; } = null!;

    [MaxLength(100)]
    public string? Location { get; set; } // Permitir null

    [MaxLength(100)]
    public string? Description { get; set; } // Permitir null

    public ICollection<Administrator>? Administrators { get; set; }

    public int administratorCount => Administrators == null ? 0 : Administrators.Count;
}