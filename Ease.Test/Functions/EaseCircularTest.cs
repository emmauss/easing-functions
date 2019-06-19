namespace Easing.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class EaseCircularTest
    {
        #region In
        [TestMethod]
        public void In_Xis0p6_Yis0p2()
        {
            Ease ease = new Circular();
            float x = 0.6f;

            Point expected = new Point(x, 0.2f);
            Point actual = ease.In(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void In_Xis0p3_Yis0p0461()
        {
            Ease ease = new Circular();
            float x = 0.3f;

            Point expected = new Point(x, 0.0461f);
            Point actual = ease.In(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InInverse_Yis0p6_Xis0p9165()
        {
            Ease ease = new Circular();
            float y = 0.6f;

            Point expected = new Point(0.9165f, y);
            Point actual = ease.InInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InInverse_Yis0p3_Xis0p7141()
        {
            Ease ease = new Circular();
            float y = 0.3f;

            Point expected = new Point(0.7141f, y);
            Point actual = ease.InInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }
        #endregion


        #region Out
        [TestMethod]
        public void Out_Xis0p6_Yis0p9165()
        {
            Ease ease = new Circular();
            float x = 0.6f;

            Point expected = new Point(x, 0.9165f);
            Point actual = ease.Out(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void Out_Xis0p3_Yis0p7141()
        {
            Ease ease = new Circular();
            float x = 0.3f;

            Point expected = new Point(x, 0.7141f);
            Point actual = ease.Out(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void OutInverse_Yis0p6_Xis0p714()
        {
            Ease ease = new Circular();
            float y = 0.6f;

            Point expected = new Point(0.2f, y);
            Point actual = ease.OutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void OutInverse_Yis0p3_Xis0p0461()
        {
            Ease ease = new Circular();
            float y = 0.3f;

            Point expected = new Point(0.0461f, y);
            Point actual = ease.OutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }
        #endregion


        #region InOut
        [TestMethod]
        public void InOut_Xis0p6_Yis0p8()
        {
            Ease ease = new Circular();
            float x = 0.6f;

            Point expected = new Point(x, 0.8f);
            Point actual = ease.InOut(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InOut_Xis0p3_Yis0p1()
        {
            Ease ease = new Circular();
            float x = 0.3f;

            Point expected = new Point(x, 0.1f);
            Point actual = ease.InOut(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_Yis0p6_Xis0p5101()
        {
            Ease ease = new Circular();
            float y = 0.6f;

            Point expected = new Point(0.5101f, y);
            Point actual = ease.InOutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_Yis0p3_Xis0p4583()
        {
            Ease ease = new Circular();
            float y = 0.3f;

            Point expected = new Point(0.4583f, y);
            Point actual = ease.InOutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }
        #endregion
    }
}
