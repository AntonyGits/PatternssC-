using System;

namespace Labirint
{
    class MazeGame
    {
        // Метод CreateMaze - создает лабиринт из двух комнат с одной дверью между комнатами.
        public Maze CreateMaze()
        {
            // Лабиринт.
            Maze aMaze = new Maze();

            Room r1 = new Room(1);
            Room r2 = new Room(2);

            // Дверь - данный экземпляр содержит ссылки на две комнаты. (Является общим для двух комнат.)
            Door theDoor = new Door(r1, r2);

            aMaze.AddRoom(r1);
            aMaze.AddRoom(r2);

            r1.SetSide(Direction.North, new Wall());
            r1.SetSide(Direction.East, theDoor);
            r1.SetSide(Direction.South, new Wall());
            r1.SetSide(Direction.West, new Wall());

            r2.SetSide(Direction.North, new Wall());
            r2.SetSide(Direction.East, new Wall());
            r2.SetSide(Direction.South, new Wall());
            r2.SetSide(Direction.West, theDoor);

            return aMaze;
        }
    }
}
