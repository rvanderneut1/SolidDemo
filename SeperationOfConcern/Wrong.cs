public class HomeController{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }

  public IActionResult ProductIndex()
    {
        return View("Product/Index");
    }

    public IActionResult GetProducts()
    {
        return View();
    }

      public IActionResult ReservationIndex()
    {
        return View("Reservation/Index");
    }

    public IActionResult Reserve()
    {
        return View();
    }
}

ROute.add("/Product/index", new HomeController().ProductIndex);
