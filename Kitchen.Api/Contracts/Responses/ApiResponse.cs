﻿namespace Kitchen.Api.Contracts.Responses;

public class ApiResponse<T>
{
    public T? Data { get; set; }
    public string? Message { get; set; }
    public bool Success { get; set; } = true;
}
