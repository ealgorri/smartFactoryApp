using System;
using System.Drawing;

namespace smartFactoryApp.Models
{
    internal class Robot
    {
        // Position als double, damit bei schrägen Bewegungen keine Rundungsfehler aufsummiert werden
        private double x;
        private double y;
        Rectangle borders;
        private double angle; // Ausrichtung in Grad (0..360), im Uhrzeigersinn, 0 = nach oben

        public Point Location
        {
            get { return new Point((int)Math.Round(x), (int)Math.Round(y)); }
            set { x = value.X; y = value.Y; }
        }
        public Rectangle Borders { get => borders; set { borders = value; } }
        public double Angle { get => angle; }

        public Robot(Point location)
        {
            Location = location;
        }

        public Robot(Point location, Rectangle borders)
        {
            Location = location;
            this.borders = borders;
        }
        public void Bewegen(Parameters.Direction dir)
        {
            int speed = Parameters.step;

            // Bewegung relativ zur Ausrichtung des Roboters:
            // forward = +1 vorwärts / -1 rückwärts, sideways = +1 nach rechts / -1 nach links
            int forward = 0;
            int sideways = 0;

            switch (dir)
            {
                case Parameters.Direction.up:        forward = 1;                break;
                case Parameters.Direction.down:      forward = -1;               break;
                case Parameters.Direction.left:      sideways = -1;              break;
                case Parameters.Direction.right:     sideways = 1;               break;
                case Parameters.Direction.upRight:   forward = 1;  sideways = 1;  break;
                case Parameters.Direction.upLeft:    forward = 1;  sideways = -1; break;
                case Parameters.Direction.downRight: forward = -1; sideways = 1;  break;
                case Parameters.Direction.downLeft:  forward = -1; sideways = -1; break;
                case Parameters.Direction.rotateRight:
                    angle = (angle + Parameters.rotationStep) % 360;
                    return;
                case Parameters.Direction.rotateLeft:
                    angle = (angle - Parameters.rotationStep + 360) % 360;
                    return;
                case Parameters.Direction.stop: return;
                default: return;
            }

            // Lokale Richtung (vorwärts/seitwärts) in Bildschirmkoordinaten umrechnen.
            // Vorwärts-Vektor: (sin a, -cos a), Rechts-Vektor: (cos a, sin a); y wächst nach unten.
            double rad = angle * Math.PI / 180.0;
            double sin = Math.Sin(rad);
            double cos = Math.Cos(rad);

            double newX = x + speed * (forward * sin + sideways * cos);
            double newY = y + speed * (-forward * cos + sideways * sin);

            // Nur bewegen, wenn die neue Position innerhalb der Grenzen liegt
            if (newX >= borders.Left && newX <= borders.Right &&
                newY >= borders.Top && newY <= borders.Bottom)
            {
                x = newX;
                y = newY;
            }
        }
    }
}
