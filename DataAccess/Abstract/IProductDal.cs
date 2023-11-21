using System;
using Core.DataAccess;
using DataAccess.DTOs;
using Entities.Concrete;

namespace DataAccess.Abstract
{
	public interface IProductDal : IEntityRepository<Product>
	{
		List<ProductDetailDto> GetProductDetails();
	}
}


