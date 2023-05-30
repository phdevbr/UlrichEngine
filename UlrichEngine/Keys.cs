using System.Windows.Input;

namespace UlrichEngine
{
    public class Keys
    {
        public bool S = ((Keyboard.GetKeyStates(Key.S) & KeyStates.Down) > 0) ? true : false;
        public bool W = ((Keyboard.GetKeyStates(Key.W) & KeyStates.Down) > 0) ? true : false;
        public bool A = ((Keyboard.GetKeyStates(Key.A) & KeyStates.Down) > 0) ? true : false;
        public bool D = ((Keyboard.GetKeyStates(Key.D) & KeyStates.Down) > 0) ? true : false;
        public bool Up = ((Keyboard.GetKeyStates(Key.Up) & KeyStates.Down) > 0) ? true : false;
        public bool Down = ((Keyboard.GetKeyStates(Key.Down) & KeyStates.Down) > 0) ? true : false;
        public bool Left = ((Keyboard.GetKeyStates(Key.Left) & KeyStates.Down) > 0) ? true : false;
        public bool Right = ((Keyboard.GetKeyStates(Key.Right) & KeyStates.Down) > 0) ? true : false;
    }
}
