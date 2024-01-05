using DemoStore.DataAccess.Models;
using DemoStore.Repository.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStore.ViewModels
{
    public class CartViewModel
    {
        private readonly CartRepo _context;

        public CartViewModel()
        {
            _context = new CartRepo();
        }
        public long GetCartId(long userId)
        {
           return _context.GetCartId(userId);
        }
        public Cart GetCartDetailsById(long id)
        {
            return _context.GetCartDetailsById(id);
        }


        public long CreateCart(long userId)
        {
            return _context.CreateCart(userId);
        }

        public void UpdateCart(Cart cart)
        {
            _context.UpdateCart(cart);
        }
        public List<CartItem> GetCartItems(long cartId)
        {
            return _context.GetCartItems(cartId);
        }
        public void AddCartItem(CartItem cartItems)
        {
           _context.AddCartItem(cartItems);
        }
        public void UpdateCartItem(CartItem cartItems)
        {
            _context.UpdateCartItem(cartItems);
        }

        public void DeleteCartItem(CartItem cartItem)
        {
            _context.DeleteCartItem(cartItem);
        }
        public void ClearCart(long cartId)
        {
            _context.ClearCart(cartId);
        }
    }
}
