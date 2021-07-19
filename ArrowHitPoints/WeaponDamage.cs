﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ArrowHitPoints
{
    class WeaponDamage
    {
        private int roll;
        /// <summary>
        /// Sets or gets the 3d6 roll.
        /// </summary>
        public int Roll
        {
            get { return roll; }
            set { roll = value; CalculateDamage(); }
        }

        private bool flaming;
        /// <summary>
        /// True if the sword is flaming, false otherwise.
        /// </summary>
        public bool Flaming
        {
            get { return flaming; }
            set { flaming = value; CalculateDamage(); }
        }

        private bool magic;
        /// <summary>
        /// True if the sword is magic, false otherwise.
        /// </summary>
        public bool Magic
        {
            get { return magic; }
            set { magic = value; CalculateDamage(); }
        }

        /// <summary>
        /// Contains the calculate damage.
        /// </summary>
        public int Damage { get; protected set; }

        protected virtual void CalculateDamage()
        {
            /* the subclass overrides this */
        }

        /// <summary>
        /// The constructor calculates damage based on default Magic
        /// and Flaming values and a starting 3d6 roll.
        /// </summary>
        /// <param name="startingRoll">Starting 3d6 roll</param>
        public WeaponDamage(int startingRoll)
        {
            roll = startingRoll;
            CalculateDamage();
        }
    }
}
