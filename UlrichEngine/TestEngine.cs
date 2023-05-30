using System;
using System.Drawing;
using System.Windows;

namespace UlrichEngine
{
    class TestEngine : Engine
    {
        public TestEngine() : base(new Vector2D(800, 500), "Testing")
        {

        }

        public override void OnLoad()
        {
            p = new Shape(new Vector2D(0, 200), new Vector2D(50, 50), Color.Red);
        }
        Shape p;
        public override void OnUpdate(float deltaTime)
        {
            Keys keys = new Keys();
            float dt = deltaTime;
            int speed = 100;
            if(keys.Left)
            {
                p.Position.X -= speed * dt;
            } 
            if (keys.Right)
            {
                p.Position.X += speed * dt;
            } 
            if (keys.Up)
            {
                p.Position.Y -= speed * dt;
            } 
            if (keys.Down)
            {
                p.Position.Y += speed * dt;
            }
        }
    }
}
