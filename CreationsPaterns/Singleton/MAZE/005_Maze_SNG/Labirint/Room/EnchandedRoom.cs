﻿using System;


namespace Labirint
{
    // Класс волшебная комната.
    class EnchantedRoom : Room
    {
        // Поля.
        private Spell spell = null;

        // Конструкторы.
       
        public EnchantedRoom(int roomNo)
            : base(roomNo)
        {
        }

        public EnchantedRoom(int number, Spell spell)
            : base(number)
        {            
            this.spell = spell;
        }
    }
}
