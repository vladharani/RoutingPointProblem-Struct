using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RoutingPointProblem
{
    [TestClass]
    public class RoutingCoordinatesStruct
    {
        public enum command
        {
            up,
            down,
            left,
            right
        };

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
        [TestMethod]
        public void TestRoutingCoordinates()
        {
            point startingPoint = new point(0, 0);
            point estimatedEndingPoint = new point(1, 1);
            command[] commandsList = new command[] { command.up, command.right };
            Assert.AreEqual(estimatedEndingPoint, FindLastPoint(startingPoint, commandsList));
        }

        public point FindLastPoint(point calculatedEndingPoint, command[] commandsList)
        {
            for (int index = 0; index < commandsList.Length; index++)
            {
                switch (commandsList[index])
                {
                    case command.up:
                        calculatedEndingPoint.y = calculatedEndingPoint.y + 1;
                        break;
                    case command.down:
                        calculatedEndingPoint.y = calculatedEndingPoint.y - 1;
                        break;
                    case command.right:
                        calculatedEndingPoint.x = calculatedEndingPoint.x + 1;
                        break;
                    case command.left:
                        calculatedEndingPoint.x = calculatedEndingPoint.x - 1;
                        break;
                }
            }
            return calculatedEndingPoint;
        }
    }
}