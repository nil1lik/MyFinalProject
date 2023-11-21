using System;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface ICategoryService
	{
		List<Category> GetAll();
		Category GetById(int id);
	}
}

