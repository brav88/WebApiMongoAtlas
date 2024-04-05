using MongoDB.Bson;

namespace PostMan.Models
{
	public class Movie
	{
		public ObjectId? _id { get; set; }
		public string? title { get; set; }
        public string? description { get; set; }
        public DateTime dateRelease { get; set; }
    }
}
