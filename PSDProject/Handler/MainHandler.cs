using PSDProject.Handler;
using PSDProject.Model;
using PSDProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Handler
{
    public class MainHandler
    {
        public static void insertUser(User user)
        {
            MainRepository.insertUser(user);
        }

        public static void userLogin(string username, string password)
        {
            MainRepository.getUser(username, password);
        }
        
        public static void updateUser(int id, string name, string email, string gender, string password)
        {
            MainRepository.updateUser(id, name, email, gender, password);
        }

        public static void insertRamen(Raman ramen)
        {
            MainRepository.insertRamen(ramen);
        }

        public static void updateRamen(int id, String name, int meatId, String broth, int price)
        {
            MainRepository.updateRamen(id, name, meatId, broth, price);
        }

        
    }
}