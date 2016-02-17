﻿using System;
using SQLite;
using Xamarin.Forms;
using System.Collections.Generic;

namespace UXDivers.Artina.Grial
{
	public class UserItem
	{
		[PrimaryKey, AutoIncrement, Column("id")]
		public int Id { get; set; }

		//		[MaxLength(50), Column("Name")]
		public string Name { get; set; }

		//		[MaxLength(50), Column("FirstName")]
		public string FirstName { get; set; }

		//		[MaxLength(50), Column("NickName")]
		public string NickName {get; set; }

		//		[MaxLength(50), Column("Function")]
		public string Function { get; set; }

		//		[MaxLength(50), Column("Email")]
		public string Email { get; set; }

		//		[MaxLength(50), Column("Email")]
		public string Password { get; set; }

		//		[MaxLength(50), Column("Email")]
		public string Language { get; set; }

	}
}
