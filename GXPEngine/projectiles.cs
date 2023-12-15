using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace GXPEngine
{
    internal class projectiles : Sprite
    {
        public projectiles() : base("Bullet.png")
        {
            SetScaleXY(0.3f);
            //SetColor(255, 0, 0);
        }
       public void Update() 
       {
          Move(1,0);
       }


    }
}
