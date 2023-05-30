using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Controls;
using System.Windows.Forms;

namespace UlrichEngine
{
    public class Canvas : Form
    {
        public Canvas()
        {
            this.DoubleBuffered= true;
        }
    }
    abstract class Engine
    {
        public static Vector2D ScreenSize = new Vector2D(500, 500);
        public string Title = "";
        public Canvas Window = null;
        public Thread GameLoopThread = null;
        public static List<Shape> RenderStack = new List<Shape>();
        public Engine(Vector2D screenSize, string title) {
            ScreenSize = screenSize;
            Title = title;
            Window = new Canvas();
            Window.Size = new Size((int)screenSize.X, (int)screenSize.Y);
            Window.Text = title;
            Window.Paint += Renderer;
            GameLoopThread = new Thread(GameLoop);
            GameLoopThread.SetApartmentState(ApartmentState.STA);
            GameLoopThread.Start();
            Application.Run(Window);
        }

        public static void RegisterShape(Shape s)
        {
            if(s != null)
            {
                RenderStack.Add(s);
            }
        }

        private void GameLoop()
        {
            OnLoad();
            DateTime previousTime = DateTime.Now;
            while (true)
            {
                try
                {
                    Window.BeginInvoke((MethodInvoker)delegate
                    { Window.Refresh(); });
                    DateTime currentTime = DateTime.Now;
                    float deltaTime = (float)(currentTime -         previousTime).TotalSeconds; 
                    previousTime = currentTime; 
                    OnUpdate(deltaTime);
                    Thread.Sleep(1);
                } catch(Exception)
                {
                    Console.WriteLine("Something bad happened");
                }
            }
        }

        private void Renderer(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);  
            List<Shape> Renderer = new List<Shape>(RenderStack);
            foreach (Shape s in Renderer)
            {
                g.FillRectangle(new SolidBrush(s.color), (int)s.Position.X, (int)s.Position.Y, (int)s.Scale.X, (int)s.Scale.Y);
            }
        }

        public abstract void OnLoad();
        public abstract void OnUpdate(float deltaTime);
    }
}
