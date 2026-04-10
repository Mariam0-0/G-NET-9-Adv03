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
using System.Drawing;

namespace G_NET_9_Adv03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1
            //Exercise 1: Student Grade Manager
            //Create a program that manages student grades using One Of Collections
            //1. Create a Collection with these grades: 85, 92, 78, 95, 88, 70, 100, 65
            //2. Print the collection, Count, first and last grade
            //3. Sort the grades ascending, then print
            //4. Get the first grade above 90
            //5. Get all grades below 75(failing grades)
            //6. Remove all failing grades(below 75)
            //7. Check if any grade equals 100
            //8. Create a List<string> where each grade becomes "Grade: X"
            //===============================================================

            //// 1.
            //List<int> grades = new List<int>() { 85, 92, 78, 95, 88, 70, 100, 65 };

            ////2. 
            //Console.Write("Grades: ");
            //PrintList(grades);
            //Console.WriteLine($"Grades Count: {grades.Count}");
            //Console.WriteLine($"First Grade: {grades[0]}");
            //Console.WriteLine($"Last Grade: {grades[grades.Count - 1]}");


            ////3.
            //Console.WriteLine("========================================");
            //Console.WriteLine();
            //grades.Sort();
            //Console.WriteLine("Grades After Sorting: ");
            //PrintList(grades);


            ////4. Get the first grade above 90
            //Console.WriteLine("========================================");
            //Console.WriteLine();
            //foreach(int grade in grades)
            //{
            //    if(grade > 90)
            //    {
            //        Console.WriteLine($"First grade after 90 found: {grade}");
            //        break;
            //    }
            //}


            ////5. Get all grades below 75(failing grades)
            //Console.WriteLine("========================================");
            //Console.WriteLine();
            //List<int> failing = new List<int>();
            //foreach (int grade in grades)
            //{
            //    if (grade < 70)
            //    {
            //        failing.Add(grade);
            //    }

            //}
            //Console.Write("Failing grades: ");
            //PrintList(failing);


            ////6. Remove all failing grades(below 75)
            //Console.WriteLine("========================================");
            //Console.WriteLine();

            //grades.RemoveAll(g => g < 75);
            //Console.WriteLine("Grades >= 75: ");
            //PrintList(grades);

            ////7. Check if any grade equals 100

            //bool found = grades.Contains(100);
            //if(found)
            //    Console.WriteLine("Grade = 100 was found");
            //else
            //    Console.WriteLine("Grade = 100 not found :(");


            ////8. Create a List<string> where each grade becomes "Grade: X"
            //List<string> gradesString = new List<string>();
            //foreach (int grade in grades)
            //{
            //    gradesString.Add($"Grade: {grade}");
            //}
            //Console.WriteLine("String grades: ");
            //foreach (string grade in gradesString)
            //{
            //    Console.WriteLine(grade);
            //}
            #endregion

            #region Exercise 2
            //Exercise 2: Leaderboard
            //Create a leaderboard that automatically sorts players by score.
            //1.Add: 500 = "Ahmed", 200 = "Sara", 800 = "Ali", 350 = "Mona"
            //2.Print all entries(they should be sorted by score automatically)
            //3.Access the first key and first value
            //4.Check if score 500 exists
            //5.Safely get the player with score 999
            //6.Remove the player with score 200 and print the updated list
            //===============================================================

            //1.
            //SortedList<int, string> leaderboard = new()
            //{
            //    [500] = "Ahmed",
            //    [200] = "Sara",
            //    [800] = "Ali",
            //    [350] = "Mona"
            //};

            //2.Print all entries(they should be sorted by score automatically)

            //Console.WriteLine("Leaderboard Entries:");
            //for(int i =0; i < leaderboard.Count; i++) 
            //{
            //    Console.WriteLine($"{leaderboard.Keys[i]}");
            //}

            //3.Access the first key and first value

            //Console.WriteLine($"First Key: {leaderboard.Keys[0]}");
            //Console.WriteLine($"First Value: {leaderboard.Values[0]}");



            //4.Check if score 500 exists

            //bool found = leaderboard.ContainsKey(500);
            //if (found)
            //    Console.WriteLine("Key 100 was found");
            //else
            //    Console.WriteLine("Key 100 was not found :(");


            //5.Safely get the player with score 999
            //bool found = leaderboard.TryGetValue(999, out string result);
            //if (found)
            //    Console.WriteLine($"Player with key 999 was found: {result}");
            //else
            //    Console.WriteLine("Player with key 999 was not found :(");


            //6.Remove the player with score 200 and print the updated list
            //leaderboard.Remove(200);
            //Console.WriteLine("Leaderboard entries after removing key 200:");
            //for (int i = 0; i < leaderboard.Count; i++)
            //{
            //    Console.WriteLine($"{leaderboard.Keys[i]} - {leaderboard.Values[i]}");
            //}




            #endregion

            #region Exercise 3
            //Exercise 3: Phone Book
            //Build a phone book application.
            //1.Create a Collection with 4 contacts(name → phone number)
            //2.Add a new contact using [] syntax (add or update)
            //3.Try adding a duplicate using .Add() — catch the exception and print the error
            //4.Try adding a duplicate using .TryAdd() — print whether it succeeded
            //5.Search for a contact that doesn’t exist
            //6.Get a contact with a fallback of "Not Found"
            //7.Print all Keys on one line, then all Values on another line
            //===============================================================

            ////1.Create a Collection with 4 contacts(name → phone number)
            //Dictionary<string, int> phoneBook = new()
            //{
            //    ["Ahmed"] = 0123,
            //    ["Sara"] = 0456,
            //    ["Ali"] = 0789,
            //    ["Marwa"] = 0321
            //};

            ////2.Add a new contact using [] syntax (add or update)
            //phoneBook["Mona"] = 0654; // ADD
            //phoneBook["Ali"] = 0194; // UPDATE


            ////3.Try adding a duplicate using .Add() — catch the exception and print the error
            //try
            //{
            //    phoneBook.Add("Ahmed", 0284);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine($"ERROR cannot add duplicates: {e}");
            //}


            ////4.Try adding a duplicate using .TryAdd() — print whether it succeeded
            //bool check = phoneBook.TryAdd("Ahmed", 0546);
            //if ( check )
            //{
            //    Console.WriteLine("Added succesfully");
            //}
            //else
            //{
            //    Console.WriteLine("Duplicates not allowed");
            //}


            ////5.Search for a contact that doesn’t exist
            //bool found = phoneBook.ContainsKey("Doaa");
            //if ( found )
            //    Console.WriteLine("Doaa was found");
            //else
            //    Console.WriteLine("Doaa was not found");


            ////6.Get a contact with a fallback of "Not Found"
            //int found2 = phoneBook.GetValueOrDefault("Doaa", -1);
            //Console.WriteLine(found2 == -1 ? "Not Found" : found2.ToString());


            ////7.Print all Keys on one line, then all Values on another line

            //Console.WriteLine(string.Join(", ", phoneBook.Keys));

            //Console.WriteLine( string.Join(", ", phoneBook.Values));
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
        static void PrintList (List<int> list)
        {
            Console.Write("[");
            for (int i = 0; i < list.Count; i++)
            {
                if (i == list.Count - 1)
                    Console.Write($"{list[i]}]");
                else
                    Console.Write($"{list[i]}, ");
            }
            Console.WriteLine();

        }
    }
}
