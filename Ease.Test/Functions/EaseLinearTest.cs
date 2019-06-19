namespace Easing.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class EaseLinearTest
    {
        #region In
        [TestMethod]
        public void In_Xis0p6_Yis0p6()
        {
            Ease ease = new Linear();
            float x = 0.6f;

            Point expected = new Point(x, 0.6f);
            Point actual = ease.In(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void In_Xis0p3_Yis0p3()
        {
            Ease ease = new Linear();
            float x = 0.3f;

            Point expected = new Point(x, 0.3f);
            Point actual = ease.In(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InInverse_Xis0p6_Yis0p6()
        {
            Ease ease = new Linear();
            float y = 0.6f;

            Point expected = new Point(0.6f, y);
            Point actual = ease.InInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InInverse_Xis0p3_Yis0p3()
        {
            Ease ease = new Linear();
            float y = 0.3f;

            Point expected = new Point(0.3f, y);
            Point actual = ease.InInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }
        #endregion


        #region Out
        [TestMethod]
        public void Out_Xis0p6_Yis0p6()
        {
            Ease ease = new Linear();
            float x = 0.6f;

            Point expected = new Point(x, 0.6f);
            Point actual = ease.Out(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void Out_Xis0p3_Yis0p3()
        {
            Ease ease = new Linear();
            float x = 0.3f;

            Point expected = new Point(x, 0.3f);
            Point actual = ease.Out(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void OutInverse_Xis0p6_Yis0p6()
        {
            Ease ease = new Linear();
            float y = 0.6f;

            Point expected = new Point(0.6f, y);
            Point actual = ease.OutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void OutInverse_Xis0p3_Yis0p3()
        {
            Ease ease = new Linear();
            float y = 0.3f;

            Point expected = new Point(0.3f, y);
            Point actual = ease.OutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }
        #endregion


        #region InOut
        [TestMethod]
        public void InOut_Xis0p6_Yis0p6()
        {
            Ease ease = new Linear();
            float x = 0.6f;

            Point expected = new Point(x, 0.6f);
            Point actual = ease.InOut(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InOut_Xis0p3_Yis0p3()
        {
            Ease ease = new Linear();
            float x = 0.3f;

            Point expected = new Point(x, 0.3f);
            Point actual = ease.InOut(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_Xis0p6_Yis0p6()
        {
            Ease ease = new Linear();
            float y = 0.6f;

            Point expected = new Point(0.6f, y);
            Point actual = ease.InOutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_Xis0p3_Yis0p3()
        {
            Ease ease = new Linear();
            float y = 0.3f;

            Point expected = new Point(0.3f, y);
            Point actual = ease.InOutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }
        #endregion

    }
}
