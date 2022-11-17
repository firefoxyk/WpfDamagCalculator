using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;//для работы с выводом строк в окно вывода

namespace WpfDamagCalculator
{
        internal class SwordDamage
        {
            private const int BASE_DAMAGE = 3;
            private const int FLAME_DAMAGE = 2;
            /// <summary>
            /// Константы калькулятора дамага
            /// </summary>
            private int roll;
            /// <summary>
            /// Устанавливает или получает бросок кубика 3на6
            /// </summary>
            public int Roll
            {
                get { return roll; }
                set { roll = value; CalculatrDamage(); }
            }

            public int Damage { get; private set; }
            /// <summary>
            /// Вычисляет поражение в зависимости от текущих свойств
            /// </summary>
            public void CalculatrDamage()
            {
                decimal MagicMultiplier = 1M;
                if (Magic) MagicMultiplier = 1.75M;

                Damage = BASE_DAMAGE;
                Damage = (int)(Roll * MagicMultiplier) + BASE_DAMAGE;

                if (Flaming) Damage += FLAME_DAMAGE;
            }
            private bool magic;
            /// <summary>
            /// Если меч волшебный true, иначе false
            /// </summary>
            public bool Magic
            {
                get { return magic; }
                set { magic = value; CalculatrDamage(); }
            }
            public bool flaming;
            /// <summary>
            /// Если меч огненный true, иначе false
            /// </summary>
            public bool Flaming
            {
                get { return flaming; }
                set { flaming = value; CalculatrDamage(); }
            }
            /// <summary>
            /// Вычисление поражения для занчений magic и flaminf по умолчанию и нач броска 3на6
            /// </summary>
            /// <param name="startindRoll"> Начальный бросок 3на6</param>
            public SwordDamage(int startindRoll)
            {
                roll = startindRoll;
                CalculatrDamage();
            }
        }
    }