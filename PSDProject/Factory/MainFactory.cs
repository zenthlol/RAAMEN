using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Factory
{
    public class MainFactory
    {
        public static User createUser(String username, String email, String gender, String password)
        {
            User newUser = new User();

            newUser.RoleId = 1;
            newUser.UserName = username;
            newUser.Email = email;
            newUser.Gender = gender;
            newUser.Password = password;

            return newUser;
        }

        public static Raman createRamen(String name, int meat, String broth, int price)
        {
            Raman newRamen = new Raman();

            newRamen.Name = name;
            newRamen.MeatId = meat;
            newRamen.Borth = broth;
            newRamen.Price = price;

            return newRamen;
        }

        public static Cart createCart(int RamenId, int UserId, int Quantity)
        {
            Cart newCart = new Cart();

            newCart.RamenId = RamenId;
            newCart.UserId = UserId;
            newCart.Quantity = Quantity;

            return newCart;
        }

        public static Header createHeader(int UserId, int StaffId)
        {

            Header newHeader = new Header();

            newHeader.UserId = UserId;
            newHeader.StaffId = StaffId;
            newHeader.Date = DateTime.Now.Date;

            return newHeader;

        }

        public static Detail createDetail(int HeaderId, int RamenId, int Quantity)
        {
            Detail newDetail = new Detail();

            newDetail.HeaderId = HeaderId;
            newDetail.RamenId = RamenId;
            newDetail.Quantity = Quantity;

            return newDetail;

        }
    }
}