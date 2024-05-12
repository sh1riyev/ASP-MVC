using System;
using AspNet_MVC.Models;

namespace AspNet_MVC.ViewModels
{
	public class HomeVM
	{
		public string Text { get; set; }
		public List<string> Students{ get; set; }
		public List<User> users{ get; set; }
		public List<Student> Stus{ get; set; }
    public List<Product> Products{ get; set; }

	}
}

