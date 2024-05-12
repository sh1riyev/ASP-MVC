using System;
using AspNet_MVC.Models;
using AspNet_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspNet_MVC.Controllers
{
	public class HomeController:Controller
	{
		public IActionResult Index()
		{
			string text = "salam";
            List<string> students = new () { "Ilgar", "Orxan", "kamran" };
			HomeVM home = new()
			{
				Text = text,
				Students = students,
				Stus = GetAllStudents(),
				Products=GetAllProducts()
			};
			return View(home);
		}

		private List<User> GetAllUser()
		{
			return new List<User>
			{
				new User
				{
					Id=1,
					Age=23
				},
				new User
				{
					Id=2,
					Age=27
				},
				new User
				{
					Id=3,
					Age=66
				}
			};
		}

		private List<Student> GetAllStudents()
		{
			return new List<Student>()
			{
				new Student
				{
					FullName="Ilgar Shiriyev",
					Email="shiriyev@gmail.com",
					Age=26,
					Phone="+994508802323"
				},
				new Student
				{
					FullName="Nigar Mammadova",
					Email="shiriyev@gmail.com",
					Age=33,
					Phone="+994508802325"
				},
								new Student
				{
					FullName="Kamran Agayev",
					Email="kamran@gmail.com",
					Age=21,
					Phone="+994508802659"
				}
			};
		}

		private List<Product> GetAllProducts()
		{
			return new List<Product>
			 {
				 new Product
				 {
					 Name="Nike",
					 Price=40,
					 Color="black"
				 },
								  new Product
				 {
					 Name="HM",
					 Price=13,
					 Color="orange"
				 },
												   new Product
				 {
					 Name="Adidas",
					 Price=22,
					 Color="white"
				 }
			 };
		}
	}
}

