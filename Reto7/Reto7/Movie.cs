namespace Reto7 {
    public class Movie {
        public string title { get; set; }
        public int year { get; set; }
        public string url { get; set; }
        public int first_aired { get; set; }
        public string country { get; set; }
        public string overview { get; set; }
        public int runtime { get; set; }
        public string status { get; set; }
        public string network { get; set; }
        public string air_day { get; set; }
        public string air_time { get; set; }
        public string certification { get; set; }
        public string imdb_id { get; set; }
        public string tvdb_id { get; set; }
        public string tvrage_id { get; set; }
        public string poster { get; set; }
        public Imagen images { get; set; }
        public int watchers { get; set; }
        public Rating ratings { get; set; }
        public string[] genres { get; set; }
    }
}