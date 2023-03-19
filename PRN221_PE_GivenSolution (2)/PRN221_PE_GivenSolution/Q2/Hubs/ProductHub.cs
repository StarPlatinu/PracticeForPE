using Microsoft.EntityFrameworkCore;
using Q2.DataAccess;
using Microsoft.AspNetCore.SignalR;

namespace Q2.Hubs
{
	public class ProductHub : Hub
	{
		private readonly PRN_Spr23_B1Context _Context;
		public ProductHub(PRN_Spr23_B1Context context)
		{
			_Context = context;
		}
		public async Task DeleteProduct(int? DeletedId)
		{
			if (DeletedId != null)
			{
				var product = _Context.Products
					.Include(X => X.OrderDetails)
					.FirstOrDefault(x => x.ProductId == DeletedId);
				foreach (var item in product.OrderDetails.ToList())
				{
					product.OrderDetails.Remove(item);
				}
			
				
				_Context.Products.Remove(product);
				_Context.SaveChanges();
			}

			await Clients.All.SendAsync("LoadProduct");



		}
	}
}

