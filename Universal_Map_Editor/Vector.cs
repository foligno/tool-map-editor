namespace Universal_Map_Editor
{    
    public class Vector
    {
        private int _x;
        private int _y;

        public Vector()
        {
            this._x = 0;
            this._y = 0;
        }

        public Vector(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }
    }
}
