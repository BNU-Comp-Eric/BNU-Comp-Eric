using System;
using System.Collections.Generic;
using System.Text;

namespace EricConsoleApp.Unit5
{
    public class BatesMotel
    {
        public const int MAXN_ROOMS = 20;
        public const int MAXN_GUESTS = 4;
        private static int[] rooms;
        private int roomNumber, guests;
        private static int roomsBooked = 0, totalGuests = 0;

        public BatesMotel()
        {
            rooms = new int[MAXN_ROOMS + 1];
        }

        /// <summary>
        /// This method displays the menu where
        /// the user can select what they wish to do
        /// and calls the selected method
        /// </summary>
        public void RunMotel()
        {
            string choice = "";

            do
            {
                Console.Clear();
                SimpleIO.WriteTitle("Bates Motel", "Task 5.6");
                Console.WriteLine("The Bates Motel");
                Console.WriteLine("===================");
                Console.WriteLine("1. Book a room");
                Console.WriteLine("2. Vacate a room");
                Console.WriteLine("3. Display ALL rooms");
                Console.WriteLine("4. Vacate ALL rooms");
                Console.WriteLine("5. Quit");
                Console.Write("Enter your choice : ");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    BookRoom();
                }
                else if (choice == "2")
                {
                    VacateOneRoom();
                }
                else if (choice == "3")
                {
                    ShowAllRooms();
                }
                else if (choice == "4")
                {
                    VacateAllRooms();
                }
            } 
            while (choice != "5"); 
        }

        /// <summary>
        /// This method allows the user to 
        /// book a room
        /// </summary>
        public void BookRoom()
        {
            SimpleIO.WriteTitle("Bates Motel", "Task 5.6");
            Console.WriteLine("\nThe Bates Motel");
            Console.WriteLine("=================");
            Console.WriteLine("Book a room");

            Console.Write("Enter the room number: ");
            do
            {
                roomNumber = Convert.ToInt32(Console.ReadLine());
                if (rooms[roomNumber] != 0)
                {
                    Console.WriteLine("Sorry this Room is already booked");
                    Console.Write("\nPlease pick a different Room : ");
                }
            } while (rooms[roomNumber] != 0);

            Console.Write("How many guests : ");
            do
            {
                guests = Convert.ToInt32(Console.ReadLine());
                if (guests > MAXN_GUESTS)
                {
                    Console.WriteLine("You can only have less then 4 guests booked within room " + roomNumber);
                    Console.Write("How many guests : ");
                }
            }
            while (guests > MAXN_GUESTS);

            rooms[roomNumber] = guests;

            totalGuests += guests;
            roomsBooked++;
        }

        /// <summary>
        /// This method displays all the rooms in the motel
        /// </summary>
        public void ShowAllRooms()
        {
            SimpleIO.WriteTitle("Bates Motel", "Task 5.6");
            Console.WriteLine("Bates Motel Room Status");
            Console.WriteLine("=======================");
            for (int i = 1; i < MAXN_ROOMS + 1; i++)
            {
                Console.WriteLine("Room " + i + "\t" + rooms[i] + " guests");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// This method allows the user to vacate 
        /// one room
        /// </summary>
        public void VacateOneRoom()
        {
            SimpleIO.WriteTitle("Bates Motel", "Task 5.6");
            Console.Write("Which Room would you like to vacate: ");
            roomNumber = Convert.ToInt32(Console.ReadLine());
            totalGuests -= rooms[roomNumber];
            rooms[roomNumber] = 0;
            Console.Write("Room " + roomNumber + " has been vacated");
            roomsBooked -= 1;

            Console.ReadKey();
        }

        /// <summary>
        /// This method will vacate all the rooms
        /// in the motel
        /// </summary>
        public void VacateAllRooms()
        {
            SimpleIO.WriteTitle("Bates Motel", "Task 5.6");
            Array.Clear(rooms, 0, rooms.Length);

            Console.WriteLine("All rooms have been vacated!");
        }
    }
}
