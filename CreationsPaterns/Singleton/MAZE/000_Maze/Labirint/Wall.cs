using System;

namespace Labirint
{
    class Wall : MapSite
    {
        // Конструктор.
        public Wall()
        {
        }

        public override void Enter()
        {
            Console.WriteLine("Wall");
        }
    }
}
