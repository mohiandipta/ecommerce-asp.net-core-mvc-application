﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Movie
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public string ImageURL { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public MovieCategory MovieCategory { get; set; }


        // Relationships
        public List<Actor_Movie> Actor_Movies { get; set; }


        // design has defined as [ Cinemas ---> Movies <--- Producers ]

        // Cinema // ForeignKey
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }


        // Producer // ForeignKey
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
    }
}
