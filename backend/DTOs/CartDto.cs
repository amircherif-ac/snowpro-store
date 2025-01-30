using System;

namespace backend.DTOs;

public class CartDto
{
    public required string CartId { get; set; } // used for cookies
    public List<CartItemDto> Items { get; set; } = [];
}
