﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using MovieApp.Models;

namespace MovieApp.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        
        [Required]
        public byte GenreId { get; set; }
        
        public GenreDto Genre { get; set; }
        
        public DateTime DateAdded { get; set; }
        
        public DateTime ReleaseDate { get; set; }
        
        public byte NumberInStock { get; set; }
    }
}