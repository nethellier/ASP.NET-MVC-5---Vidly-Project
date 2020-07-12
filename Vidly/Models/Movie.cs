using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models {
    public class Movie {
        //POCO
        public int ID { get; set; }
        public string Name { get; set; }
    }

    // /movies/random => moviesController action=random
}