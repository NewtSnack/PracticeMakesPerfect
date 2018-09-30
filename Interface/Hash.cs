using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Diagnostics;

namespace Practice
{
    struct UserInfo
    {
        public int userId;
        public string userName;
        public UserInfo(int id, string name)
        {
            userId = id;
            userName = name;
        }
    }
    class Hash
    {
        private static Hashtable userInfoHash;
        static List<UserInfo> userInfoList;
        static Stopwatch sw;

        public static void HashExample()
        {
            userInfoHash = new Hashtable();
            userInfoList = new List<UserInfo>();
            sw = new Stopwatch();
            //adding
            for (int cou = 0; cou < 4000000; cou++)
            {
                userInfoHash.Add(cou, "user" + cou);
                userInfoList.Add(new UserInfo(cou, "user" + cou));
            }
            //removing
            if (userInfoHash.ContainsKey(0))
            {
                userInfoHash.Remove(0);
            }
            //setting
            if (userInfoHash.ContainsKey(1))
            {
                userInfoHash[1] = "replacedName";
            }
            //Looping
            //foreach(DictionaryEntry entry in userInfoHash)
            //{
            //    Console.WriteLine("Key: " + entry.Key + " / Value: " + entry.Value);
            //}
            //Access
            Random randomUserGen = new Random();
            int randomUser = -1;
            sw.Start();
            float startTime = 0;
            float endTime = 0;
            float deltaTime = 0;
            string userName = "";

            int cycles = 5;
            int cycle = 0;
            while (cycle < cycles)
            {
                randomUser = randomUserGen.Next(3000000, 4000000);
                startTime = sw.ElapsedMilliseconds;
                userName = (string)userInfoHash[randomUser];
                endTime = sw.ElapsedMilliseconds;
                deltaTime = endTime - startTime;
                Console.WriteLine("Time taken to retrieve " + userName + " from hash took " + string.Format("{0:0.##}",deltaTime) + "ms");
                cycle++;
            }
            
        }
        static string GetUserFromList(int userId)
        {
            for (int i = 0; i < userInfoList.Count; i++)
            {
                if (userInfoList[i].userId ==userId)
                {
                    return userInfoList[i].userName;
                }
            }
            return string.Empty;
        }
        
    }
}
