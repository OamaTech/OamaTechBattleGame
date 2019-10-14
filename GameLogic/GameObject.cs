
using System.Windows.Forms;

namespace GameObjects
{
    public class GameObject
    {
        public string TagName { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Speed { get; set; }
        public bool GoingLeft { get; set; }
        public bool GoingRight { get; set; }

        public GameObject(string tagName, int width, int height, int speed)
        {
            this.TagName = tagName;
            this.Width = width;
            this.Height = height;
            this.Speed = speed;
        }

        /// <summary>
        /// During each iteration of our game loop we will update our GameObject
        /// </summary>
        public virtual void Update() { }
    }
}
