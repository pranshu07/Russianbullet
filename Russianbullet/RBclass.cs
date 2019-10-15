using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Russianbullet
{
   public class RBclass
    {
        public int ShootingAwayChances = 2;
        public int Bullet = 0;
        public int FireRemain = 4;
       

        public void LoadBullet()

        {  
         
            Bullet = 6;
        }

        public int SpinChamber()

        {
            Random rand = new Random();
            Bullet = rand.Next(1, 7);
            return Bullet;
        }

        public int Fire()
        {
            

            if(Bullet == 1)
            {
                MessageBox.Show("You are dead , do you want to play again?!");
                Application.Restart();
            }
            else if(FireRemain > 1)
            {
                MessageBox.Show("keep it up ");
                Bullet--;
                FireRemain--;
            }
            else
            {
                Bullet--;
                FireRemain--;
            }

            

            return FireRemain;
        }

        public int ShootingAway()
        {

            if (Bullet == 1)
            {
                MessageBox.Show("You survived, do you want to play again?");
                Application.Restart();
            }
            else if (ShootingAwayChances > 1)
            {
                MessageBox.Show("Keep it up");
                Bullet--;
                ShootingAwayChances--;
            }
            else
            {
                Bullet--;
                ShootingAwayChances--;
            }
            

            return ShootingAwayChances;

        }
    }
}
