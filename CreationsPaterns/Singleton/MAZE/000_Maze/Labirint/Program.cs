using System;
using System.Threading;


namespace Labirint
{
    class Program
    {
        static void Main()
        {
            // Генератор лабиринта.
            MazeGame mazeGame = new MazeGame();

            // Создается лабиринт из двух комнат используя фабричный метод - CreateMaze().
            Maze maze = mazeGame.CreateMaze();

            // Генератор псевдослучайных последовательностей.
            Random random = new Random();

            // Ввод имнимого игрока в лабиринт (комната выбирается случайным образом).
            Room room = maze.RoomNo(random.Next(1, 3));

            // Выбранная сторона.
            MapSite site = null;


            // ИГРОВАЯ ПЕТЛЯ.

            // Начало прохождения лабиринта. 
            while (true)
            {                

                // Выбор новой стороны случайным образом.
                switch (random.Next(0, 4))
                {
                    // Выбор стороны направления (получаем ссылку на сторону). 
                    case 0:
                        site = room.GetSide(Direction.North);
                        break;
                    case 1:
                        site = room.GetSide(Direction.South);
                        break;
                    case 2:
                        site = room.GetSide(Direction.East);
                        break;
                    case 3:
                        site = room.GetSide(Direction.West);
                        break;
                }

                // Отображение номера комнаты в которой сейчас находится мнимый игрок.
                Console.Write("Я в комнате {0}. Делаю шаг. - ", room.RoomNumber);

                // Попытка следать шаг в выбранную сторону (Визуальное отображение стороны на экране).
                site.Enter();

                if (site is Door) // Если дверь, то перейти в другую комнату.
                {
                    Door door = (Door)site;
                    // Переход в другую комнату (Получение ссылки на новую комнату).
                    room = door.OtherSideFrom(room);
                }

                // Иначе стена. Тогда продолжается поиск другого направления в той-же комнате.

                // Задержка между шагами.
                Thread.Sleep(800);
            }
        }
    }
}
