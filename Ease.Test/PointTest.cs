namespace Easing.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PointTest
    {
        [TestMethod]
        public void StaticFeildZero_IsActuallyZero()
        {
            bool xIsZero = Point.Zero.X == 0;
            bool yIsZero = Point.Zero.Y == 0;

            Assert.IsTrue(xIsZero && yIsZero);
        }

        #region -
        [TestMethod]
        public void OperatorSubtract_14x25ySubtract7x32y_Returns7xN7y()
        {
            Point lhs = new Point(14, 25);
            Point rhs = new Point(7, 32);

            Point actual = lhs - rhs;
            Point expected = new Point(7, -7);

            Assert.AreEqual(actual, expected);
        }
        #endregion


        #region +
        [TestMethod]
        public void OperatorAdd_14x25yAdd7x32y_Returns21x57y()
        {
            Point lhs = new Point(14, 25);
            Point rhs = new Point(7, 32);

            Point actual = lhs + rhs;
            Point expected = new Point(21, 57);

            Assert.AreEqual(actual, expected);
        }
        #endregion


        #region ==
        [TestMethod]
        public void OperatorEquals_5x9yEquals5x9y_ReturnsTrue()
        {
            Point lhs = new Point(5, 9);
            Point rhs = new Point(5, 9);

            bool actual = lhs == rhs;
            bool expected = true;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void OperatorEquals_5x9yEquals5x10y_ReturnsFalse()
        {
            Point lhs = new Point(5, 9);
            Point rhs = new Point(5, 10);

            bool actual = lhs == rhs;
            bool expected = false;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void OperatorEquals_5x9yEquals6x9y_ReturnsFalse()
        {
            Point lhs = new Point(5, 9);
            Point rhs = new Point(6, 9);

            bool actual = lhs == rhs;
            bool expected = false;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void OperatorEquals_5x9yEquals6x10y_ReturnsFalse()
        {
            Point lhs = new Point(5, 9);
            Point rhs = new Point(6, 10);

            bool actual = lhs == rhs;
            bool expected = false;

            Assert.AreEqual(actual, expected);
        }
        #endregion


        #region !=
        [TestMethod]
        public void OperatorNotEquals_5x9yNotEquals6x10y_ReturnsTrue()
        {
            Point lhs = new Point(5, 9);
            Point rhs = new Point(6, 10);

            bool actual = lhs != rhs;
            bool expected = true;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void OperatorNotEquals_5x9yNotEquals6x9y_ReturnsTrue()
        {
            Point lhs = new Point(5, 9);
            Point rhs = new Point(6, 9);

            bool actual = lhs != rhs;
            bool expected = true;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void OperatorNotEquals_5x9yNotEquals5x10y_ReturnsTrue()
        {
            Point lhs = new Point(5, 9);
            Point rhs = new Point(5, 10);

            bool actual = lhs != rhs;
            bool expected = true;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void OperatorNotEquals_5x9yNotEquals5x9y_ReturnsFalse()
        {
            Point lhs = new Point(5, 9);
            Point rhs = new Point(5, 9);

            bool actual = lhs != rhs;
            bool expected = false;

            Assert.AreEqual(actual, expected);
        }
        #endregion


        #region GetHasCode
        [TestMethod]
        public void GetHasCode_5x9yAnd5x9y_ReturnsSameHashcode()
        {
            Point lhs = new Point(5, 9);
            Point rhs = new Point(5, 9);

            Assert.AreEqual(lhs.GetHashCode(), rhs.GetHashCode());
        }

        [TestMethod]
        public void GetHasCode_5x9yAnd5x10y_ReturnsDifferentHashcode()
        {
            Point lhs = new Point(5, 9);
            Point rhs = new Point(5, 10);

            Assert.AreNotEqual(lhs.GetHashCode(), rhs.GetHashCode());
        }
        #endregion
    }
}
