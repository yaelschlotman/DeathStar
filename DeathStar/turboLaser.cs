using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeathStar
{
    class turboLaser
    {
        float position = 0;
        float elevation = 0;
        Ammo ammo;
        bool isReady = false;

        public turboLaser(string gas)
        {
            ammo = new Ammo(gas); 
        }
        
        public void powerOn()
        {
            isReady = true 
        }

        public void changeElevation(float degreeChange)
        {
            if ((elevation + degreeChange >= 0) & (elevation + degreeChange <= 75))
            {
                elevation = elevation + degreeChange;
            }
            else
            {
                Console.WriteLine("Error: Change Outside Parameter");
            }
        }   
        public void changePostion(float degreeChange)
        {
            if ((position + degreeChange >= -30) & (position + degreeChange <= 150))
            {
                position = position + degreeChange;
            }
            else
            {
                Console.WriteLine("Error: Change Outside Parameter");
            }
        }    


    }


}