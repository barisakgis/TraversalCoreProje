using Newtonsoft.Json;

namespace TraversalCoreProje.Areas.Admin.Models
{
    
    public class ApiMovieViewModel
    {
    //    public int  rank { get; set; }
    //    public string title { get; set; }
    //    public string rating { get; set; }
    //    public int year { get; set; }
    //    public string trailer { get; set; }

        public int rank { get; set; }
        public string title { get; set; }
        public string thumbnail { get; set; }
        public string rating { get; set; }
        public string id { get; set; }
        public int year { get; set; }
        public string image { get; set; }
        public string big_image { get; set; }
        public string description { get; set; }
        public string trailer { get; set; }
        public string trailer_embed_link { get; set; }
        public string trailer_youtube_id { get; set; }
        public List<string> genre { get; set; }
        public List<string> director { get; set; }
        public List<string> writers { get; set; }
        public string imdbid { get; set; }
        public string imdb_link { get; set; }

    }
}
