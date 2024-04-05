using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi;

namespace PostMan.Controllers
{
	public class PostmanController : Controller
	{
		List<Person> people = new List<Person>();

		// GET: PostmanController
		public IActionResult Index()
		{
			Person person = new Person
			{
				Id = 1,
				Name = "John",
				LastName = "Doe",
				Address = "Texas"
			};

			people.Add(person);
			people.Add(person);
			people.Add(person);

			return Json(people);
		}

		// POST: PostmanController/Create
		[HttpPost]		
		public IActionResult Save([FromBody] Person person)
		{
			people.Add(person);

			return Json(people);
		}

		// GET: PostmanController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: PostmanController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: PostmanController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(IFormCollection collection)
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

		// GET: PostmanController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: PostmanController/Edit/5
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

		// GET: PostmanController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: PostmanController/Delete/5
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
