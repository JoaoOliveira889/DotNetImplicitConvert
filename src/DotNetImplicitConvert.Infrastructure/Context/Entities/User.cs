﻿namespace DotNetImplicitConvert.Infrastructure.Context.Entities;

public class User
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; }= string.Empty;
    public string Password { get; set; }= string.Empty;
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}