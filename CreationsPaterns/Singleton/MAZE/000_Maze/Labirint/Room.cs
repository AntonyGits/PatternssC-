using System;
using System.Collections.Generic;

namespace Labirint
{
    class Room : MapSite
    {       
        int roomNumber = 0;        
        Dictionary<Direction, MapSite> sides;  
                
        public Room(int roomNo)
        {
            this.roomNumber = roomNo;
            sides = new Dictionary<Direction, MapSite>(4); 
        }
                
        public override void Enter()
        {
            Console.WriteLine("Room");
        }

        public MapSite GetSide(Direction direction)
        {
            return sides[direction];
        }

        public void SetSide(Direction direction, MapSite mapSide)
        {
            this.sides.Add(direction, mapSide);
        }
                
        public int RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }
    }
}
