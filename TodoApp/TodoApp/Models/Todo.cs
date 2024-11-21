using System;
using System.Collections.Generic;

namespace TodoApp.Models;

public partial class Todo
{
    public int Id { get; set; }

    public DateTime Deadline { get; set; }

    public string? Description { get; set; }

    public string Title { get; set; } = null!;

    public bool IdDone { get; set; }
}
