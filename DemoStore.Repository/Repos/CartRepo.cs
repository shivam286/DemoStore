using DemoStore.DataAccess.Data;
using DemoStore.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoStore.Repository.Repos
{
    public class CartRepo
    {
        private readonly DemoStoreContext _context;
        public CartRepo()
        {
            _context = new DemoStoreContext();
        }


        public long GetCartId(long Userid)
        {
           return _context.Carts.Where(x => x.UserId == Userid).Select(i => i.Id).FirstOrDefault();
        }

        public Cart GetCartDetailsById(long id)
        {
            return _context.Carts.FirstOrDefault(x => x.Id == id);
        }
        public long CreateCart(long Userid)
        {
            var cart = new Cart()
            {
                //UserId = Userid,
                CreatedAt = DateTime.Now,
                CartableType = "AdminUser",
                Total = (decimal)0.0,
                TotalTax = (decimal)0.0,
                TotalWithoutDiscount = (decimal)0.0,
                TotalWithTax = (decimal)0.0,
                SubTotal = (decimal)0.0,
                DiscountPercent = (decimal)0.0,
                CartToken = Guid.NewGuid().ToString()
            };
            _context.Carts.Add(cart);
            _context.SaveChanges();

            return cart.Id;
        }

        public void UpdateCart(Cart cart)
        {
            _context.Carts.Update(cart);
            _context.SaveChanges();

        }

        public CartItem GetCartItem(long id)
        {
            return _context.CartItems.FirstOrDefault(x => x.Id == id);

        }

        public void AddCartItem(CartItem cartItem)
        {
            if(cartItem != null)
            {
                cartItem.CreatedAt = DateTime.Now;
                _context.CartItems.Add(cartItem);
                _context.SaveChanges();
            }
        }

        public void UpdateCartItem(CartItem cartItem)
        {
            if(cartItem != null)
            {
                cartItem.UpdatedAt = DateTime.Now;
                _context.CartItems.Update(cartItem);
                _context.SaveChanges();
            }
        }

        public void DeleteCartItem(CartItem cartItem)
        {
            _context.CartItems.Remove(cartItem);
            _context.SaveChanges();
        }


        public List<CartItem> GetCartItems(long cartId)
        {
            return _context.CartItems.Where(x => x.CartId == cartId).ToList();
        }

        public void ClearCart(long cartId)
        {
            var cartItems = GetCartItems(cartId);
            _context.CartItems.RemoveRange(cartItems);
            _context.SaveChanges();
        }
    }
}
