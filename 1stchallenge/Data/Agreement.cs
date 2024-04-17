using System;
using System.Collections.Generic;

namespace _1stchallenge.Data;

public partial class Agreement
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public int EmployerId { get; set; }

    public string Status { get; set; } = null!;
}
