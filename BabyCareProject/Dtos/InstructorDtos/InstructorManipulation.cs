﻿namespace BabyCareProject.Dtos.InstructorDtos;

public class InstructorManipulation
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public IFormFile ImageFile { get; set; }
    public string? ImageUrl { get; set; }
    public string Title { get; set; }
}
