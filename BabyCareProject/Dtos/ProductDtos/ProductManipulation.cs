﻿namespace BabyCareProject.Dtos.ProductDtos;

public class ProductManipulation
{
    public string Title { get; set; }
    public string Description { get; set; }
    public IFormFile ImageFile { get; set; }
    public string? ImageUrl { get; set; }
    public string Price { get; set; }
    public string InstructorName { get; set; }
}
