using System;
using System.Collections.Generic;

namespace NETAssessment.Models;

public partial class Claim
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public string? Status { get; set; }

    public string Date { get; set; } = null!;
}
