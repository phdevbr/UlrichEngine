using System.Drawing;

namespace UlrichEngine
{
    public class Shape
    {
        public Vector2D Position { get; set; }
        public Vector2D Scale { get; set; }
        public Color color = Color.Black;
        public Shape(Vector2D position, Vector2D scale, Color color)
        {
            Position = position;
            Scale = scale;
            this.color = color;
            Engine.RegisterShape(this);
        }
    }
}
