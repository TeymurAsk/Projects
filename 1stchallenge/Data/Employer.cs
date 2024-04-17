using System;
using System.Collections.Generic;

namespace _1stchallenge.Data;

public partial class Employer
{
    public int Id { get; set; }

    public string CompanyName { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string City { get; set; } = null!;

    public string? Saved { get; set; }
}
