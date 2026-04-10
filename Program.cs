using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Globalization;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
using System.Xml;
using System;

namespace G_NET_9_Adv03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1
            //Exercise 1: Student Grade Manager
            //Create a program that manages student grades using One Of Collections
            //Create a Collection with these grades: 85, 92, 78, 95, 88, 70, 100, 65
            //Print the collection, Count, first and last grade
            //Sort the grades ascending, then print
            //Get the first grade above 90
            //Get all grades below 75(failing grades)
            //Remove all failing grades(below 75)
            //Check if any grade equals 100
            //Create a List<string> where each grade becomes "Grade: X"
            //===============================================================

            #endregion

            #region Exercise 2
            //Exercise 2: Leaderboard
            //Create a leaderboard that automatically sorts players by score.
            //Add: 500 = "Ahmed", 200 = "Sara", 800 = "Ali", 350 = "Mona"
            //Print all entries(they should be sorted by score automatically)
            //Access the first key and first value
            //Check if score 500 exists
            //Safely get the player with score 999
            //Remove the player with score 200 and print the updated list
            //===============================================================

            #endregion

            #region Exercise 3
            //Exercise 3: Phone Book
            //Build a phone book application.
            //Create a Collection with 4 contacts(name → phone number)
            //Add a new contact using [] syntax (add or update)
            //Try adding a duplicate using .Add() — catch the exception and print the error
            //Try adding a duplicate using .TryAdd() — print whether it succeeded
            //Search for a contact that doesn’t exist
            //Get a contact with a fallback of "Not Found"
            //Print all Keys on one line, then all Values on another line
            //===============================================================

            #endregion

            #region Exercise 4
            //Exercise 4: Unique Email Validator
            //Use Collection to manage unique email addresses.
            //Create a HashSet<string> with a case -insensitive comparer: new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            //Add these emails: "ahmed@test.com", "AHMED@test.com", "sara@test.com", "Sara@Test.Com"
            //Print Count — how many are actually stored? Explain why.
            //Create two sets: Set A = { 1, 2, 3, 4, 5 } and Set B = { 4,5,6,7,8}
            //Print the result of: UnionWith, IntersectWith, ExceptWith
            //Use IsSubsetOf to check if { 1,2} is a subset of Set A
            //===============================================================

            #endregion

            #region Exercise 5
            //Exercise 5: Print Queue Simulator
            //Simulate a printer queue
            //Create a Queue<string> and enqueue 5 documents: "Report.pdf", "Invoice.pdf", "Letter.docx", "Resume.pdf", "Photo.jpg"
            //Print the queue contents and Count
            //Use Peek to see which document will print next(without removing)
            //Process the queue: Dequeue each document and print "Printing: [name]"
            //Try TryDequeue on the now - empty queue — what happens?
            //===============================================================

            #endregion

            #region Exercise 6
            //Exercise 6: Browser History(Undo)
            //Simulate browser back / forward
            //Create a Stack<string> for browser history
            //Push 5 URLs: "google.com", "github.com", "stackoverflow.com", "youtube.com", "claude.ai"
            //Use Peek to see the current page(top of stack)
            //Press "back" 3 times using Pop — print each page you leave
            //Print the current page after going back
            //Try TryPop on an empty stack — what happens?
            //===============================================================

            #endregion

        }
    }
}
