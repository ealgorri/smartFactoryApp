namespace smartFactoryApp.Models
{
    internal class Parameters
    {
        public enum Direction
        {
            stop = 0,
            left = 1,
            right = 2,
            up = 3,
            down = 4,
            upRight = 5,
            upLeft = 6,
            downRight = 7,
            downLeft = 8,
            rotateRight = 9,
            rotateLeft = 10,
         }
        public const int step = 3;
        public const double rotationStep = 10; // Grad pro Drehung
    }
}