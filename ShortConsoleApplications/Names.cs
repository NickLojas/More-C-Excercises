using System;
using System.Linq;

/* Implement the FindCommon method. When passed two arrays of names, 
   it will return an array containing the names that appear in either or both arrays. 
   The returned array should have no duplicates.
   
   For example, calling Names.FindCommon(new string[]{'Ava', 'Emma', 'Olivia'}, 
   new string[]{'Olivia', 'Sophia', 'Emma'}) should return an array containing Ava,
   Emma, Olivia, and Sophia in any order.*/

namespace ShortConsoleApplications
{
    public static class Names
    {
        public static string[] FindCommon(string[] names1, string[] names2)
        {
            return names1.Union(names2).ToArray();
        }
    }
}