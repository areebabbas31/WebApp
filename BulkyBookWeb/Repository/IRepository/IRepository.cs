﻿using System;
using Bulky.Models;
using System.Linq.Expressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BulkyBookWeb.Repository.IRepository
{
	public interface IRepository<T> where T : class
	{
		IEnumerable<T> GetAll();
		T Get (Expression<Func<T,bool>>filter);
		void Add(T entity);

		void Remove(T entity);
		void RemoveRange(IEnumerable<T> entity);
	}
}

 