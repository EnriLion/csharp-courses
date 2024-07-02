using System;

namespace Create_Web_Api_With_Asp_Net_Core_Controllers.Models;

public class Pizza 
{
		public int Id {  get; set; }
		public string? Name { get; set; }
		public bool IsGlutenFree { get; set; }
}
