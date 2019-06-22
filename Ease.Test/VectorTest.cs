namespace Easing.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class VectorTest
    {
        [TestMethod]
        public void StaticFeildZero_IsActuallyZero()
        {
            bool xIsZero = Vector.Zero.X == 0;
            bool yIsZero = Vector.Zero.Y == 0;

            Assert.IsTrue(xIsZero && yIsZero);
        }

        #region -
        [TestMethod]
        public void OperatorSubtract_14x25ySubtract7x32y_Returns7xN7y()
        {
            Vector lhs = new Vector(14, 25);
            Vector rhs = new Vector(7, 32);

            Vector actual = lhs - rhs;
            Vector expected = new Vector(7, -7);

            Assert.AreEqual(actual, expected);
        }
        #endregion


        #region +
        [TestMethod]
        public void OperatorAdd_14x25yAdd7x32y_Returns21x57y()
        {
            Vector lhs = new Vector(14, 25);
            Vector rhs = new Vector(7, 32);

            Vector actual = lhs + rhs;
            Vector expected = new Vector(21, 57);

            Assert.AreEqual(actual, expected);
        }
        #endregion


        #region ==
        [TestMethod]
        public void OperatorEquals_5x9yEquals5x9y_ReturnsTrue()
        {
            Vector lhs = new Vector(5, 9);
            Vector rhs = new Vector(5, 9);

            bool actual = lhs == rhs;
            bool expected = true;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void OperatorEquals_5x9yEquals5x10y_ReturnsFalse()
        {
            Vector lhs = new Vector(5, 9);
            Vector rhs = new Vector(5, 10);

            bool actual = lhs == rhs;
            bool expected = false;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void OperatorEquals_5x9yEquals6x9y_ReturnsFalse()
        {
            Vector lhs = new Vector(5, 9);
            Vector rhs = new Vector(6, 9);

            bool actual = lhs == rhs;
            bool expected = false;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void OperatorEquals_5x9yEquals6x10y_ReturnsFalse()
        {
            Vector lhs = new Vector(5, 9);
            Vector rhs = new Vector(6, 10);

            bool actual = lhs == rhs;
            bool expected = false;

            Assert.AreEqual(actual, expected);
        }
        #endregion


        #region !=
        [TestMethod]
        public void OperatorNotEquals_5x9yNotEquals6x10y_ReturnsTrue()
        {
            Vector lhs = new Vector(5, 9);
            Vector rhs = new Vector(6, 10);

            bool actual = lhs != rhs;
            bool expected = true;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void OperatorNotEquals_5x9yNotEquals6x9y_ReturnsTrue()
        {
            Vector lhs = new Vector(5, 9);
            Vector rhs = new Vector(6, 9);

            bool actual = lhs != rhs;
            bool expected = true;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void OperatorNotEquals_5x9yNotEquals5x10y_ReturnsTrue()
        {
            Vector lhs = new Vector(5, 9);
            Vector rhs = new Vector(5, 10);

            bool actual = lhs != rhs;
            bool expected = true;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void OperatorNotEquals_5x9yNotEquals5x9y_ReturnsFalse()
        {
            Vector lhs = new Vector(5, 9);
            Vector rhs = new Vector(5, 9);

            bool actual = lhs != rhs;
            bool expected = false;

            Assert.AreEqual(actual, expected);
        }
        #endregion


        #region GetHasCode
        [TestMethod]
        public void GetHasCode_5x9yAnd5x9y_ReturnsSameHashcode()
        {
            Vector lhs = new Vector(5, 9);
            Vector rhs = new Vector(5, 9);

            Assert.AreEqual(lhs.GetHashCode(), rhs.GetHashCode());
        }

        [TestMethod]
        public void GetHasCode_5x9yAnd5x10y_ReturnsDifferentHashcode()
        {
            Vector lhs = new Vector(5, 9);
            Vector rhs = new Vector(5, 10);

            Assert.AreNotEqual(lhs.GetHashCode(), rhs.GetHashCode());
        }
        #endregion
    }
}
