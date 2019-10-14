

using System.Windows.Forms;

namespace GameObjects
{
    public class Player : GameObject
    {
        public Player(string tagName, int width, int height, int speed) 
            : base(tagName, width, height, speed) { }

        public override void Update()
        {
            SetDirection();
            Move();
            if (IsShooting())
            {
                Shoot();
            }
        }

        public PictureBox CreatePlayer()
        {
            PictureBox graphics = new PictureBox();
            graphics.Image = Graphics.Hero;


        }

        private void Move()
        {
            if (GoingLeft)
            {

            }
        }

        private void Shoot()
        {

        }

        private bool IsShooting()
        {
            return Control.ModifierKeys == Keys.Space;
        }

        private void SetDirection()
        {
            if(Control.ModifierKeys == Keys.Left)
            {
                GoingLeft = true;
                GoingRight = false;
            }
            else if(Control.ModifierKeys == Keys.Right)
            {
                GoingLeft = false;
                GoingRight = true;
            }
            else
            {
                GoingLeft = false;
                GoingRight = false;
            }
        }


    }
}
