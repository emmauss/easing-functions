namespace Easing.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class EaseSineTest
    {
        #region In
        [TestMethod]
        public void In_Xis0p6_Yis0p4122()
        {
            Ease ease = new Sine();
            float x = 0.6f;

            Point expected = new Point(x, 0.4122f);
            Point actual = ease.In(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void In_Xis0p3_Yis0p109()
        {
            Ease ease = new Sine();
            float x = 0.3f;

            Point expected = new Point(x, 0.109f);
            Point actual = ease.In(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InInverse_Yis0p6_Xis0p738()
        {
            Ease ease = new Sine();
            float y = 0.6f;

            Point expected = new Point(0.738f, y);
            Point actual = ease.InInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InInverse_Yis0p3_Xis0p5064()
        {
            Ease ease = new Sine();
            float y = 0.3f;

            Point expected = new Point(0.5064f, y);
            Point actual = ease.InInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }
        #endregion


        #region Out
        [TestMethod]
        public void Out_Xis0p6_Yis0p809()
        {
            Ease ease = new Sine();
            float x = 0.6f;

            Point expected = new Point(x, 0.809f);
            Point actual = ease.Out(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void Out_Xis0p3_Yis0p454()
        {
            Ease ease = new Sine();
            float x = 0.3f;

            Point expected = new Point(x, 0.454f);
            Point actual = ease.Out(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void OutInverse_Yis0p6_Xis0p4097()
        {
            Ease ease = new Sine();
            float y = 0.6f;

            Point expected = new Point(0.4097f, y);
            Point actual = ease.OutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void OutInverse_Yis0p3_Xis0p194()
        {
            Ease ease = new Sine();
            float y = 0.3f;

            Point expected = new Point(0.194f, y);
            Point actual = ease.OutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }
        #endregion


        #region InOut
        [TestMethod]
        public void InOut_Xis0p6_Yis0p6545()
        {
            Ease ease = new Sine();
            float x = 0.6f;

            Point expected = new Point(x, 0.6545f);
            Point actual = ease.InOut(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InOut_Xis0p3_Yis0p2061()
        {
            Ease ease = new Sine();
            float x = 0.3f;

            Point expected = new Point(x, 0.2061f);
            Point actual = ease.InOut(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_Yis0p6_Xis0p5641()
        {
            Ease ease = new Sine();
            float y = 0.6f;

            Point expected = new Point(0.5641f, y);
            Point actual = ease.InOutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_Yis0p3_Xis0p369()
        {
            Ease ease = new Sine();
            float y = 0.3f;

            Point expected = new Point(0.369f, y);
            Point actual = ease.InOutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }
        #endregion
    }
}
