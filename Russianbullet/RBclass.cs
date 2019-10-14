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
        public int Shotaway = 3;

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
                MessageBox.Show("you are dead!");
            }
            else if(FireRemain > 1)
            {
                MessageBox.Show("keep playing");
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
                MessageBox.Show("you survived");
            }
            else if (Shotaway > 2)
            {
                MessageBox.Show("keep playing");
                Bullet--;
                Shotaway--;
            }
            else
            {
                Bullet--;
                Shotaway--;
            }
            

            return ShootingAwayChances;

        }

        internal object bulletechange(object lodedgunspin)
        {
            throw new NotImplementedException();
        }
    }
}
