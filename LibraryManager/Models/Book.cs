﻿
/* SAHAR NAHLE */


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryManager.Models
{
    /*
        Model the Books that exist in the library.
        Provide validation attributes.
        Many to one relationship with the Genre table.
    */
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Author Last Name")]
        public string AuthorLastName { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Author First Name")]
        public string AuthorFirstName { get; set; }

        public string AuthorName => AuthorFirstName + " " + AuthorLastName;

        [Display(Name = "Date of Publication")]
        public DateTime PublishDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "Number in Stock")]
        public byte NumberInStock { get; set; }

        public byte NumberAvailable { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte GenreId { get; set; }

        public Genre Genre { get; set; }

    }
}