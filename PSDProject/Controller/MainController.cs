using PSDProject.Factory;
using PSDProject.Handler;
using PSDProject.Model;
using PSDProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Controller
{
    public class MainController
    {
        public static String userRegister(String name, String email, String gender, String password, String confirmPassword)
        {

            if (name.Equals("") || email.Equals("") || gender.Equals("") || password.Equals(""))
            {
                return "No Input";
            }
            else if (name.Length < 5 || name.Length > 15)
            {
                return "Name must be between 5-15 characters only!";
            }

            else if (!email.EndsWith(".com"))
            {
                return "Email must end with .com!";
            }

            else if (!password.Equals(confirmPassword))
            {
                return "password must be the same with confirmation password";
            }

            else
            {

                User user = MainFactory.createUser(name, email, gender, password);
                MainRepository.insertUser(user);
                return "Successful";

            }

        }

        public static String userLogin(String username, String password)
        {
            if (username.Equals("") || password.Equals(""))
            {
                return "No Input";
            }
            else
            {
                User user = MainRepository.getUser(username, password);
                if (user == null)
                {
                    return "false";
                }
                else
                {
                    return "true";
                }

            }
        }
        
        public static string updateUser(int id, string name, string email, string gender, string password)
        {
            if (name.Equals("") || email.Equals("") || gender.Equals("") || password.Equals(""))
            {
                return "No Input";
            }
            else if (name.Length < 5 || name.Length > 15)
            {
                return "Name must be between 5-15 characters only!";
            }

            else if (!email.EndsWith(".com"))
            {
                return "Email must end with .com!";
            }
            else
            {
                MainHandler.updateUser(id, name, email, gender, password);
                return "Profile Successfuly Updated";
            }
        }
        
        public static String insertRamen(String name, String meat, String broth, int price)
        {
            if (!name.Contains("Ramen"))
            {
                return "name must contain 'Ramen'!";
            }

            //validasi meat sudah di front end

            else if (broth.Equals(""))
            {
                return "broth cannot be empty!";
            }
            else if (price < 3000)
            {
                return "price must be at least 3000!";
            }
            else
            {
                int meatId = 0;

                if (meat.Equals("Beef"))
                {
                    meatId = 1;
                }
                else if (meat.Equals("Chicken"))
                {
                    meatId = 2;
                }
                else if (meat.Equals("Fish"))
                {
                    meatId = 3;
                }
                Raman newRamen = MainFactory.createRamen(name, meatId, broth, price);
                MainHandler.insertRamen(newRamen);
                return "Successfully";
            }

        }

        public static string updateRamen(int id, string name, string meat, string broth, int price)
        {
            if (!name.Contains("Ramen"))
            {
                return "name must contain 'Ramen'!";
            }

            //validasi meat sudah di front end

            else if (broth.Equals(""))
            {
                return "broth cannot be empty!";
            }
            else if (price < 3000)
            {
                return "price must be at least 3000!";
            }
            else
            {
                int meatId = 0;

                if (meat.Equals("Beef"))
                {
                    meatId = 1;
                }
                else if (meat.Equals("Chicken"))
                {
                    meatId = 2;
                }
                else if (meat.Equals("Fish"))
                {
                    meatId = 3;
                }

                
                MainHandler.updateRamen(id, name, meatId, broth, price);
                return "Successfully";
            }
        }
        public static string deleteRamen(int RamenId)
        {
            Boolean ramen = MainRepository.deleteRamen(RamenId);
            return "Successfuly";
        }

        public static String addCart(int RamenId, int UserId, int Quantity)
        {

            Cart newCart = MainFactory.createCart(RamenId, UserId, Quantity);
            MainRepository.addCart(newCart);
            return "Successfully";

        }

        public static string clearCart(int CartId)
        {
            Boolean cart = MainRepository.clearCart(CartId);
            return "Successfuly";
        }

        public static string clearUserCart(int UserId)
        {
            Boolean cart = MainRepository.clearUserCart(UserId);
            return "Successfully";
        }

        public static Header addHeader(int UserId, int StaffId)
        {
            Header newHeader = MainFactory.createHeader(UserId, StaffId);
            MainRepository.addHeader(newHeader);
            return newHeader;
        }

        public static void addDetail(int HeaderId, int RamenId, int Quantity)
        {
            Detail newDetail = MainFactory.createDetail(HeaderId, RamenId, Quantity);
            MainRepository.addDetail(newDetail);
        }

        
    }
}