﻿using System;
using System.Collections.Generic;

namespace ArraysAndListsExcecise1
{
    class Program 
    {
        static void Main (string[] args)
        {
            List<String> friendNames = GetFriendNames();
            DisplayFriendNames(friendNames);
        }
        static void DisplayFriendNames(List<String> friendNames) 
        {
            if (friendNames.Count == 1) 
            {
                Console.WriteLine(friendNames[0] + " likes your post.");
            }
            else if (friendNames.Count == 2) 
            {
                Console.WriteLine(friendNames[0] + " and " + friendNames[1] + " like your post.");
            }
            else 
            {
                Console.WriteLine(friendNames[0] + ", " + friendNames[1] + " and " + (friendNames.Count - 2) + " others like your post.");
            }
        }
        static List<String> GetFriendNames() {
            List<String> friendNames = new List<string>();
            Boolean NameEntered = true;
            while (NameEntered) {
                Console.WriteLine("Enter the name of a friend that liked your post: ");
                String name = Console.ReadLine();
                if (String.IsNullOrEmpty(name))
                {
                    NameEntered = false;
                }
                else 
                {
                    friendNames.Add(name);
                }
            } 
            return friendNames;
        }
    }
}
