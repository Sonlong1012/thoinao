﻿//using Microsoft.AspNetCore.Mvc;
//using Newtonsoft.Json;
//using WebApp.Data;

//namespace WebApp.Service
//{
//    public class CartService /*: Controller*/
//    {
//        public const string CARTKEY = "cart";
        

//        private readonly IHttpContextAccessor _context;

//        private readonly HttpContext HttpContext;
//        public CartService(HttpContextAccessor context )
//        {
//            _context = context;
//            HttpContext = context.HttpContext;

//        }
       

//        public List<CartItem> GetCartItems()
//        {

//            var session = HttpContext.Session;
//            string jsoncart = session.GetString(CARTKEY);
//            if (jsoncart != null)
//            {
//                return JsonConvert.DeserializeObject<List<CartItem>>(jsoncart);
//            }
//            return new List<CartItem>();
//        }

//        // Xóa cart khỏi session
//        public void ClearCart()
//        {
//            var session = HttpContext.Session;
//            session.Remove(CARTKEY);
//        }

//        // Lưu Cart (Danh sách CartItem) vào session
//        public void SaveCartSession(List<CartItem> ls)
//        {
//            var session = HttpContext.Session;
//            string jsoncart = JsonConvert.SerializeObject(ls);
//            session.SetString(CARTKEY, jsoncart);
//        }
//    }
//}
