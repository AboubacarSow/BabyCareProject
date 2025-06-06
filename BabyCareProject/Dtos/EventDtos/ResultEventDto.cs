﻿namespace BabyCareProject.Dtos.EventDtos;

public class ResultEventDto
{
    public string Id { get; set; }
    public string ImageUrl { get; set; }
    public string Location { get; set; }
    public string Date { get; set; }
    public string StartAt { get; set; }
    public string EndAt { get; set; } = string.Empty;
    public string Name { get; set; }
    public string Description { get; set; }
}
