using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingSim
{
    class Fighter
    {

        private int hp = 50;
        public string name;
        Random generator = new Random();


        public int Attack()
        {
            while(hp != 0){

                int randomAttack = generator.Next(1, 10);

                return randomAttack;

            }

        }
        public void Hurt(int amount)
        {


        }



    }
}
