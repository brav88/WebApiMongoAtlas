using MongoDB.Driver;
using MongoDB.Bson;
using PostMan.Models;
using MongoDB.Bson.Serialization;

namespace PostMan.MongoAtlas
{
	public class MongoAtlasDB
	{
		const string connectionUri = "mongodb+srv://<>:<>@cluster0.vfi7une.mongodb.net/retryWrites=true&w=majority&appName=Cluster0";

		public List<Movie> GetMovies()
		{	
			var client = new MongoClient(connectionUri);
			var collection = client.GetDatabase("MyApp").GetCollection<Movie>("movies");

			var movieList = collection.Find(_ => true).ToList();

			return movieList;
		}

		public void SaveMovie(Movie movie)
		{
			var client = new MongoClient(connectionUri);
			var collection = client.GetDatabase("MyApp").GetCollection<Movie>("movies");

			movie._id = ObjectId.GenerateNewId();

			collection.InsertOne(movie);
		}
	}
}
