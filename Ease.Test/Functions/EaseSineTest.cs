namespace Easing.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class EaseSineTest
    {
        #region In
        [TestMethod]
        public void In_InputInRange_ReturnsExpectedPoint()
        {
            Ease ease = new Sine();
            float x = 0.6f;

            Point expected = new Point(x, 0.4122f);
            Point actual = ease.In(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InInverse_InputInRange_ReturnsExpectedPoint()
        {
            Ease ease = new Sine();
            float y = 0.6f;

            Point expected = new Point(0.738f, y);
            Point actual = ease.InInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void In_OffsetOriginAndDestinationInputInRange_ReturnsExpectedPoint()
        {
            Point origin = new Point(3, 3);
            Point destination = new Point(4, 4);
            Ease ease = new Sine(origin, destination);
            float x = 3.6f;

            Point expected = new Point(x, 3.4122f);
            Point actual = ease.In(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InInverse_OffsetOriginAndDestinationInputInRange_ReturnsExpectedPoint()
        {
            Point origin = new Point(3, 3);
            Point destination = new Point(4, 4);
            Ease ease = new Sine(origin, destination);
            float y = 3.6f;

            Point expected = new Point(3.738f, y);
            Point actual = ease.InInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }
        #endregion


        #region Out
        [TestMethod]
        public void Out_InputInRange_ReturnsExpectedPoint()
        {
            Ease ease = new Sine();
            float x = 0.6f;

            Point expected = new Point(x, 0.809f);
            Point actual = ease.Out(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void OutInverse_InputInRange_ReturnsExpectedPoint()
        {
            Ease ease = new Sine();
            float y = 0.6f;

            Point expected = new Point(0.4097f, y);
            Point actual = ease.OutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void Out_OffsetOriginAndDestinationInputInRange_ReturnsExpectedPoint()
        {
            Point origin = new Point(3, 3);
            Point destination = new Point(4, 4);
            Ease ease = new Sine(origin, destination);
            float x = 3.6f;

            Point expected = new Point(x, 3.809f);
            Point actual = ease.Out(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void OutInverse_OffsetOriginAndDestinationInputInRange_ReturnsExpectedPoint()
        {
            Point origin = new Point(3, 3);
            Point destination = new Point(4, 4);
            Ease ease = new Sine(origin, destination);
            float y = 3.6f;

            Point expected = new Point(3.4097f, y);
            Point actual = ease.OutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }
        #endregion


        #region InOut
        [TestMethod]
        public void InOut_InputInRange_ReturnsExpectedPoint()
        {
            Ease ease = new Sine();
            float x = 0.6f;

            Point expected = new Point(x, 0.6545f);
            Point actual = ease.InOut(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_InputInRange_ReturnsExpectedPoint()
        {
            Ease ease = new Sine();
            float y = 0.6f;

            Point expected = new Point(0.5641f, y);
            Point actual = ease.InOutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InOut_OffsetOriginAndDestinationInputInRange_ReturnsExpectedPoint()
        {
            Point origin = new Point(3, 3);
            Point destination = new Point(4, 4);
            Ease ease = new Sine(origin, destination);
            float x = 3.6f;

            Point expected = new Point(x, 3.809f);
            Point actual = ease.Out(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_OffsetOriginAndDestinationInputInRange_ReturnsExpectedPoint()
        {
            Point origin = new Point(3, 3);
            Point destination = new Point(4, 4);
            Ease ease = new Sine(origin, destination);
            float y = 3.6f;

            Point expected = new Point(3.4097f, y);
            Point actual = ease.OutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }
        #endregion
    }
}
