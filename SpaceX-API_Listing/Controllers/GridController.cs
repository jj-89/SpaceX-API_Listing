using System;
﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using SpaceX_API_Listing.Models;

namespace SpaceX_API_Listing.Controllers
{
	public partial class GridController : Controller
    {
		public ActionResult Orders_Read()
		{
			var result = Enumerable.Range(0, 50).Select(i => new OrderViewModel
			{
				OrderID = i,
				Freight = i * 10,
				OrderDate = DateTime.Now.AddDays(i),
				ShipName = "ShipName " + i,
				ShipCity = "ShipCity " + i
			});

			return Json(result);
		}
	}
}