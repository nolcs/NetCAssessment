using System;
using System.Collections.Generic;

namespace NETAssessment.Models;

public partial class Vehicle
{
    public int Id { get; set; }

    public string Brand { get; set; } = null!;

    public string? Vin { get; set; }

    public string Color { get; set; } = null!;

    public string Year { get; set; } = null!;

    public string OwnerId { get; set; } = null!;
}
