using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GXPEngine
{
    internal class Player : AnimationSprite
    {
        int moveSpeed;
        float jumpHeight;
        public Player(int Speed, float height) : base("Player.png", 4 ,4)
        {
            moveSpeed = Speed;
            jumpHeight = height;
            SetOrigin(width/2, height/2);
            
            scale = 2;
        }
        public void Update()
        {
             bool isJumping = false;
            if (Input.GetKey(Key.D))
            {
                Move(moveSpeed, 0);
                SetCycle(8, 4, 1);
                Animate(0.03f);
            }
            else if (Input.GetKey(Key.A))
            {

                Move(-moveSpeed, 0);
                SetCycle(4, 4, 1);
                Animate(0.03f);
            }
            else
            {
                //SetFrame();
            }

            if (!isJumping && Input.GetKeyDown(Key.SPACE))
            {
                Move(0, -jumpHeight);
                isJumping = true;
            }
            if (Input.GetKeyUp(Key.SPACE))
            {
                Move(0, jumpHeight);
                isJumping = false;
            }


        }

    }
}
