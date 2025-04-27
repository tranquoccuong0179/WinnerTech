using System;
using System.Collections.Generic;

namespace WinnerTech.Model.Entity;

public partial class Account
{
    public Guid Id { get; set; }

    public string Phone { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Role { get; set; } = null!;

    public bool? Active { get; set; }

    public DateTime? CreateAt { get; set; }

    public DateTime? UpdateAt { get; set; }
}
