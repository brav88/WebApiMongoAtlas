using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PostMan.Models;
using PostMan.MongoAtlas;

namespace PostMan.Controllers
{
	public class MovieController : Controller
	{
		// GET: MovieController
		public IActionResult Index()
		{
			MongoAtlasDB mongoAtlasDB = new MongoAtlasDB();

			return Json(mongoAtlasDB.GetMovies());
		}

		// POST: MovieController/Create
		[HttpPost]
		public ActionResult Create([FromBody] Movie movie)
		{
			MongoAtlasDB mongoAtlasDB = new MongoAtlasDB();

			mongoAtlasDB.SaveMovie(movie);

			return Ok();
		}

		// GET: MovieController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: MovieController/Create
		public ActionResult Create()
		{
			return View();
		}

		// GET: MovieController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: MovieController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: MovieController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: MovieController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}
