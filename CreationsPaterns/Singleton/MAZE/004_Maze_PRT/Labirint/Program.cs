﻿using System;
using System.Threading;


namespace Labirint
{
    class Program
    {
        static void Main()
        {
            // Создаем генератор лабиринта.
            MazeGame game = new MazeGame();

            //Конфигурируем фабрику базовыми элементами лабиринта
            MazePrototypeFactory simpleMazeFactory = new MazePrototypeFactory(new Maze(), new Wall(), new Room(), new Door());

            // Конфигурируем фабрику специальными элементами лабиринта
            // MazePrototypeFactory bombedMazeFactory = new MazePrototypeFactory(new Maze(), new BombedWall(), new RoomWithBomb(), new Door());
            // MazePrototypeFactory enchantedMazeFactory = new MazePrototypeFactory(new Maze(), new Wall(), new EnchantedRoom(), new DoorNeedingSpell());

            // Создаем лабиринт из двух комнат используя фабричный метод - CreateMaze().
            Maze maze = game.CreateMaze(simpleMazeFactory);
                        
            // Генератор псевдослучайных последовательностей.
            Random random = new Random();

            // Попадаем в лабиринт, выбирая комнату случайным образом.
            Room room = maze.RoomNo(random.Next(1, 3));

            // Выбранная сторона.
            MapSite site = null;


            // ИГРОВАЯ ПЕТЛЯ.

            // Начинаем идти по лабиринту. 
            while (true)
            {                

                // Случайным образом выбираем новую сторону.
                switch (random.Next(0, 5))
                {
                    // Выбираем направление куда будем идти (получаем ссылку на сторону). 
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

                // Отображаем номер комнаты в которой сейчас находимся.
                Console.Write("Я в комнате {0}. Делаю шаг. - ", room.RoomNumber);

                // Делаем шаг в выбранную сторону. (Визуальное отображение стороны на экране)
                site.Enter();

                if (site is Door) // Если дверь, то перейти в другую комнату.
                {
                    Door door = (Door)site;
                    // Переход в другую комнату (Получение ссылки на новую комнату).
                    room = door.OtherSideFrom(room);
                }

                // Иначе стена. Тогда опять ищем другое направление в той-же комнате.

                // Задержка между шагами.
                Thread.Sleep(800);
            }
        }
    }
}
