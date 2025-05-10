using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonExplorer;

namespace DungeonExplorer
{
    internal class GameMap
    //class manages all the rooms in the dungen 
    //and the navagation between them
    {
        private Dictionary<string, Room> rooms = new Dictionary<string, Room>();
        //dictoanry to store rooms 
        public void AddRoom(string name, Room room)
        //room is added with unique identifiyer
        {
            rooms[name] = room;
        }
        //if the rooms have the same name name is overwriten 

        public Room GetRoom(string name)
        {
            if (rooms.ContainsKey(name))
                return rooms[name];
            else
                Console.WriteLine($"Room '{name}' does not exist.");
            return null;
        }

        //this retrives the room name from dictonary 
        //and if rooms not fount it returns erroe 

        public void DisplayRooms()
        //shows all rommes in dungen 
        {
            Console.WriteLine("Available rooms:");
            foreach (var roomName in rooms.Keys)
            {
                Console.WriteLine($"- {roomName}");
            }
        }
    }
}
