using System;
using System.Collections.Generic;

namespace _1stchallenge.Data;

public partial class Employee
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string JobTitle { get; set; } = null!;

    public double Price { get; set; }

    public string Bio { get; set; } = null!;

    public double? Rating { get; set; }

    public string Availability { get; set; } = null!;
}
