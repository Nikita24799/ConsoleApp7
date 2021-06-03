using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Point
    {
        public int x;
        public int y;
        public int sym;
        private Point tail;
        private ConsoleColor cyan;

        public Point(Point head)
        {
        }   

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point(Point tail, ConsoleColor cyan)
        {
            this.tail = tail;
            this.cyan = cyan;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        internal void Move(int i, Direction direction)
        {
            throw new NotImplementedException();
        }

        internal void Clear()
        {
            throw new NotImplementedException();
        }

        internal bool IsHit(Point point)
        {
            throw new NotImplementedException();
        }
    }
}
