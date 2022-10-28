﻿using System.ComponentModel.DataAnnotations;

namespace CorePlugin.Plugin.Dtos;

public class VoteReplayDto
{
    [Required]
    public int OptionId { get; set; }
    
    [Required]
    public Guid SubmittedBy { get; set; }
}