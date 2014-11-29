using System.Linq;
using Newtonsoft.Json;

namespace Reto7 {
    public class JsonSplitter {
        public static Result SplitShowsByGenre(string trendingShowsJson, string comedy) {
            var lista = JsonConvert.DeserializeObject<Movie[]>(trendingShowsJson);
            var res = new Result {
                Item1 = JsonConvert.SerializeObject(lista.Where(p => p.genres.Contains("Comedy")).ToArray()),
                Item2 = JsonConvert.SerializeObject(lista.Where(p => !p.genres.Contains("Comedy")).ToArray())
            };
            return res;
        }
    }
}