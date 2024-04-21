using System;
using System.Collections.Generic;

namespace _1stchallenge.Data;

public partial class Message
{
    public int Id { get; set; }

    public int EmployerId { get; set; }

    public int EmployeeId { get; set; }

    public string Message1 { get; set; } = null!;

    public DateTime Time { get; set; }
}
