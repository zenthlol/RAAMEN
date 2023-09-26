using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Repository
{
    public class MainRepository
    {
        static MainDatabaseEntities db = new MainDatabaseEntities();

        public static void insertUser(User newUser)
        {
            db.Users.Add(newUser);
            db.SaveChanges();
        }

        public static User getUser(string username, string password)
        {
            return (from data in db.Users where data.UserName.Equals(username) && data.Password.Equals(password) select data).FirstOrDefault();
        }
        public static User getUserBasedOnID(int id)
        {
            return (from data in db.Users where data.UserId == id select data).FirstOrDefault();
        }

        public static void updateUser(int id, string name, string email, string gender, string password)
        {

            User rowData = db.Users.Find(id);
           
            rowData.UserName = name;
            rowData.Gender = gender;
            rowData.Email = email;
            rowData.Password = password;

            db.SaveChanges();


        }
        

       

        public static List<User> getAllUser()
        {
            return db.Users.ToList();
        }

        public static void insertRamen(Raman newRamen)
        {
            db.Ramen.Add(newRamen);
            db.SaveChanges();
        }

        
        public static List<Raman> getAllRamen()
        {
            return db.Ramen.ToList();
        }

        public static void updateRamen(int id, string name, int meatId, string broth, int price) 
        {
            Raman ramen = db.Ramen.Find(id);
            ramen.Name = name;
            ramen.MeatId = meatId;
            ramen.Borth = broth;
            ramen.Price = price;
            db.SaveChanges();
        }

        public static Raman getRamenBasedOnID(int id)
        {
            return (from data in db.Ramen where data.RamenId == id select data).FirstOrDefault();
        }

        public static Boolean deleteRamen(int id)
        {
            Raman ramen = getRamenBasedOnID(id);
            db.Ramen.Remove(ramen);
            db.SaveChanges();
            return true;
        }

        public static void addCart(Cart newCart)
        {
            db.Carts.Add(newCart);
            db.SaveChanges();
        }

        public static List<Cart> getAllCart()
        {
            return db.Carts.ToList();
        }

        public static Cart getCartBasedOnID(int id)
        {
            return (from data in db.Carts where data.CartId == id select data).FirstOrDefault();
        }

        public static List<Cart> getAllCartBasedOnUserID(int id)
        {
            return (from data in db.Carts where data.UserId == id select data).ToList();
        }

        public static Boolean clearCart(int id)
        {
            Cart cart = getCartBasedOnID(id);
            db.Carts.Remove(cart);
            db.SaveChanges();
            return true;
        }

        public static Boolean clearUserCart(int id)
        {
            List<Cart> cart = getAllCartBasedOnUserID(id);

            foreach(var i in cart)
            {
                db.Carts.Remove(i);
            }
            db.SaveChanges();
            return true;
        }

        public static void addHeader(Header newHeader)
        {
            db.Headers.Add(newHeader);
            db.SaveChanges();
        }
        public static void addDetail(Detail newDetail)
        {
            db.Details.Add(newDetail);
            db.SaveChanges();
        }

        public static List<Header> getUserHistory(int id)
        {
            return (from data in db.Headers where data.UserId == id select data).ToList();
        }

        public static List<Header> getAllUserHistory()
        {
            return db.Headers.ToList();
        }

        public static Header getHeaderBasedOnID(int id)
        {
            return (from data in db.Headers where data.HeaderId == id select data).FirstOrDefault();
        }

        public static Detail getDetailBasedOnID(int id)
        {
            return (from data in db.Details where data.DetailID == id select data).FirstOrDefault();
        }
    }
}