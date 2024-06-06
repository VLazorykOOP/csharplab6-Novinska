using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab6CSharp
{
    public class Rectangle : IEnumerable<int>
    {
        protected int a, b, c;

        public int SideA
        {
            get { return a; }
            set
            {
                if (value >= 0)
                {
                    a = value;
                }
                else
                {
                    throw new InvalidOperationException("Attempt to assign negative value to rectangle side");
                }
            }
        }

        public int SideB
        {
            get { return b; }
            set
            {
                if (value >= 0)
                {
                    b = value;
                }
                else
                {
                    throw new InvalidOperationException("Attempt to assign negative value to rectangle side");
                }
            }
        }

        public Rectangle() : this(1, 1, 0) { }

        public Rectangle(int a, int b) : this(a, b, 0) { }

        public Rectangle(int a, int b, int c)
        {
            SideA = a;
            SideB = b;
            if (c >= 0 && c <= 15)
            {
                this.c = c;
            }
            else
            {
                throw new ArgumentException("Out of range possible colors");
            }
        }

        public ConsoleColor Color => (ConsoleColor)c;

        public void PrintSides()
        {
            Console.WriteLine("a side = {0}", a);
            Console.WriteLine("b side = {0}", b);
        }

        public int CalculatePerimeter() => 2 * (a + b);

        public int CalculateArea() => a * b;

        public bool IsSquare() => a == b;

        public int this[int index]
        {
            get
            {
                return index switch
                {
                    0 => a,
                    1 => b,
                    2 => c,
                    _ => throw new ArgumentException("Out of range")
                };
            }
        }

        public static Rectangle operator ++(Rectangle instance)
        {
            instance.a++;
            instance.b++;
            return instance;
        }

        public static Rectangle operator --(Rectangle instance)
        {
            instance.a--;
            instance.b--;
            return instance;
        }

        public static Rectangle operator *(Rectangle instance, int scalar)
        {
            return new Rectangle(instance.a * scalar, instance.b * scalar);
        }

        public static implicit operator bool(Rectangle instance) => instance.IsSquare();

        public static explicit operator string(Rectangle instance) => $"{instance.a}; {instance.b}; {instance.c}";

        public static explicit operator Rectangle(string text)
        {
            var parts = text.Split(';');
            if (parts.Length == 3 &&
                int.TryParse(parts[0].Trim(), out int a) &&
                int.TryParse(parts[1].Trim(), out int b) &&
                int.TryParse(parts[2].Trim(), out int c))
            {
                return new Rectangle(a, b, c);
            }
            throw new InvalidCastException("Attempt to convert string with invalid format to Rectangle");
        }

        public override string ToString() => $"Side A: {a}; Side B: {b}; Color: {Color}";

        public IEnumerator<int> GetEnumerator()
        {
            yield return a;
            yield return b;
            yield return c;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
