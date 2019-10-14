using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GameObjects
{
    public class Enemy : GameObject
    {
        public Enemy(Point location)
        {
            this.Controls.Add(this.GetPictureBox());
            this.Location = location;
            this.Width = 50;
            this.Height = 50;
            this.Speed = 10;
        }

        public override Image GetImage()
        {
            return Graphics.Enemy;
        }

        public override void UpdateObject()
        {
            this.MoveDown(this.Speed);
            if(this.Top > this.ParentForm.Height)
            {
                this.ParentForm.Controls.Remove(this);
            }
        }

    }
}
