using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RoutingPointProblem
{
    [TestClass]
    public class RoutingCoordinatesStruct
    {
        [TestMethod]
        public void TestRoutingCoordinates()
        {
            point startingPoint = new point(0, 0);
            point estimatedEndingPoint = new point(1, 1);
            string[] commands = new string[] { "up", "right", "right", "left", "up", "down"};
            Assert.AreEqual(estimatedEndingPoint, FindLastPoint(startingPoint, commands));
        }

        public struct point
        {
            public int x;
            public int y;
            public point(int p1, int p2)
            {
                x = p1;
                y = p2;
            }
        }

        public point FindLastPoint(point calculatedEndingPoint, string[] commands)
        {
            commands = new string[] { "up", "right", "right", "left", "up", "down"};
            for (int index = 0; index < commands.Length; index++)
            {
                if (commands[index] == "up") { calculatedEndingPoint.y = calculatedEndingPoint.y + 1; }
                else if (commands[index] == "down") { calculatedEndingPoint.y = calculatedEndingPoint.y - 1; }
                else if (commands[index] == "right") { calculatedEndingPoint.x = calculatedEndingPoint.x + 1; }
                else if (commands[index] == "left") { calculatedEndingPoint.x = calculatedEndingPoint.x - 1; }
            }
            
            return calculatedEndingPoint;
        }
    }
}