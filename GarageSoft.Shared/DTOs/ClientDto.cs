using System;
using System.Collections.Generic;
using System.Text;

namespace GarageSoft.Shared.DTOs;

public class ClientDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string? Email { get; set; }
    public DateTime? RegistrationDate { get; set; }
}
