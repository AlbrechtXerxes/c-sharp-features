using System;
using Xunit;

namespace YTCSharpFeatures.Test
{
    public class AdvancedPatternMatchingTest
    {
        [Fact]
        public void SwitchSimplierPatternTest()
        {
            var result = FromRainbow(Rainbow.Red);
        }

        [Fact]
        public void SwitchMatchingObjectPatternTest()
        {
            var point = new MyPoint(1, 2, 3);
            var result = ComputeSalesTax(point);
        }

        [Fact]
        public void SwitchMatchingByTwoParamsTest()
        {
            var result = RockPaperScissors("rock", "scissors");
        }

        [Fact]
        public void DeconstructPatternTest()
        {
            var point = new MyPoint(1, 2, 3);
            if (point is MyPoint(1, var myY, _))
            {
                // Code here will be executed only if the point MyPoint.X == 1, myY is a new variable  
            }
            if (point is MyPoint(1, 2, 3))
            {
            }
            if (point is MyPoint(1, 2, 4))
            {
            }
            if (point is MyPoint(_, _, _))
            {
            }
            const int a = 1;
            const int b = 2;
            const int c = 3;
            if (point is MyPoint(a, b, c))
            {
            }
        }

        [Fact]
        public void WhenPatternTest()
        {
            var result = GetPointWithWhenExpression();
        }

        public enum Rainbow
        {
            Red,
            Orange,
            Yellow,
            Green,
            Blue,
            Indigo,
            Violet
        }

        public static int FromRainbow(Rainbow colorBand) =>
    colorBand switch
    {
        Rainbow.Red => 1,
        Rainbow.Orange => 2,
        Rainbow.Yellow => 3,
        Rainbow.Green => 4,
        _ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(colorBand)),
    };

        //Matching by object properties
        public static decimal ComputeSalesTax(MyPoint point) =>
            point switch
            {
                { X: 1, Y: 0 } => 11,
                { X: 1, Y: 2 } => 22,
                { X: 1 } => 33,
                _ => 0
            };

        //Matching by two parameters, usually we used only one
        public static string RockPaperScissors(string first, string second)
            => (first, second) switch
            {
                ("rock", "paper") => "Paper wins.",
                ("rock", "scissors") => "Rock wins.",
                ("paper", "rock") => "Paper wins.",
                ("paper", "scissors") => " Scissors wins.",
                ("scissors", "rock") => "Rock wins.",
                ("scissors", "paper") => "Scissors wins.",
                (_, _) => "tie/draw!"
            };

        public int GetPointWithWhenExpression()
        {
            var point = new MyPoint(1, 2, 3);
            return point switch
            {
                MyPoint b when b.X < 1 => 1,
                MyPoint b when b.X >= 1 => 2,
                MyPoint => 3,
            };
        }
    }

    public class MyPoint
    {
        public MyPoint(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        //deconstruct, unpacking data -- necessary for this feature
        public void Deconstruct(out int x, out int y, out int z) =>
        (x, y, z) = (X, Y, Z);
    }
}
