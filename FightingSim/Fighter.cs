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
        static Random generator = new Random();


        public int Attack()
        {
           
                int randomAttack = generator.Next(1, 10);

                return randomAttack;


        }
        public void Hurt(int amount)
        {

            hp = hp - amount;
            
            if (hp < 0)
            {

                hp = 0;

            }
  

        }
        public bool isAlive()
        {

            if(hp <= 0)
            {

                
                return false;
                

            }
            else if (hp >= 0)
            {
                return true;

            }


            return false;


        }
        public int GetHp()
        {

            

            return hp;



        }



    }
}
