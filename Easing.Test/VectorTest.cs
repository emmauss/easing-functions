namespace Easing.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Easing;

    [TestClass]
    public class VectorTest
    {
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


        #region *
        [TestMethod]
        public void OperatorMultiply_5x7yMultiply3_Returns15x21y()
        {
            Vector lhs = new Vector(5, 7);
            float rhs = 3;

            Vector actual = lhs * rhs;
            Vector expected = new Vector(15, 21);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void OperatorMultiply_5x7yMultiplyNeg3_Returns15x21y()
        {
            Vector lhs = new Vector(5, 7);
            float rhs = -3;

            Vector actual = lhs * rhs;
            Vector expected = new Vector(-15, -21);

            Assert.AreEqual(actual, expected);
        }
        #endregion


        #region /
        [TestMethod]
        public void OperatorDivide_30x27yDivide3_Returns10x9y()
        {
            Vector lhs = new Vector(30, 27);
            float rhs = 3;

            Vector actual = lhs / rhs;
            Vector expected = new Vector(10, 9);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void OperatorDivide_30x27yDivideNeg3_ReturnsNeg10xNeg9y()
        {
            Vector lhs = new Vector(30, 27);
            float rhs = -3;

            Vector actual = lhs / rhs;
            Vector expected = new Vector(-10, -9);

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
