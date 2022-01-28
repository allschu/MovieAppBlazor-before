﻿namespace MovieAppBlazor.Data
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Popularity { get; set; }
        public double Vote_Average { get; set; }
        public bool Adult { get; set; }
        public bool Video { get; set; }
        public string Orginal_Title { get; set; }
        public string Release_Date { get; set; }
        public string Original_Language { get; set; }
        public string Overview { get; set; }
        public string Poster_Path { get; set; }
    }
}
