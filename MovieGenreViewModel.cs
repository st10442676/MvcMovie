﻿using Microsoft.AspNetCore.Mvc.Rendering;
using MVCMovies.Models;
using System.Collections.Generic;

namespace MVCMovies.Models;

public class MovieGenreViewModel
{
    public List<Movie>? Movies { get; set; }
    public SelectList? Genres { get; set; }
    public string? MovieGenre { get; set; }
    public string? SearchString { get; set; }
}