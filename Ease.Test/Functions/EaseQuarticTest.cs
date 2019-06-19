namespace Easing.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class EaseQuarticTest
    {
        #region In
        [TestMethod]
        public void In_Xis0p6_Yis0p1296()
        {
            Ease ease = new Quartic();
            float x = 0.6f;

            Point expected = new Point(x, 0.1296f);
            Point actual = ease.In(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void In_Xis0p3_Yis0p0081()
        {
            Ease ease = new Quartic();
            float x = 0.3f;

            Point expected = new Point(x, 0.0081f);
            Point actual = ease.In(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InInverse_Xis0p6_Yis0p8801()
        {
            Ease ease = new Quartic();
            float y = 0.6f;

            Point expected = new Point(0.8801f, y);
            Point actual = ease.InInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InInverse_Xis0p3_Yis0p7401()
        {
            Ease ease = new Quartic();
            float y = 0.3f;

            Point expected = new Point(0.7401f, y);
            Point actual = ease.InInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }
        #endregion


        #region Out
        [TestMethod]
        public void Out_Xis0p6_Yis0p9744()
        {
            Ease ease = new Quartic();
            float x = 0.6f;

            Point expected = new Point(x, 0.9744f);
            Point actual = ease.Out(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void Out_Xis0p3_Yis0p7599()
        {
            Ease ease = new Quartic();
            float x = 0.3f;

            Point expected = new Point(x, 0.7599f);
            Point actual = ease.Out(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void OutInverse_Xis0p6_Yis0p2047()
        {
            Ease ease = new Quartic();
            float y = 0.6f;

            Point expected = new Point(0.2047f, y);
            Point actual = ease.OutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void OutInverse_Xis0p3_Yis0p0853()
        {
            Ease ease = new Quartic();
            float y = 0.3f;

            Point expected = new Point(0.0853f, y);
            Point actual = ease.OutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }
        #endregion


        #region InOut
        [TestMethod]
        public void InOut_Xis0p6_Yis0p7952()
        {
            Ease ease = new Quartic();
            float x = 0.6f;

            Point expected = new Point(x, 0.7952f);
            Point actual = ease.InOut(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InOut_Xis0p3_Yis0p0648()
        {
            Ease ease = new Quartic();
            float x = 0.3f;

            Point expected = new Point(x, 0.0648f);
            Point actual = ease.InOut(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_Xis0p6_Yis0p5271()
        {
            Ease ease = new Quartic();
            float y = 0.6f;

            Point expected = new Point(0.5271f, y);
            Point actual = ease.InOutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_Xis0p3_Yis0p4401()
        {
            Ease ease = new Quartic();
            float y = 0.3f;

            Point expected = new Point(0.4401f, y);
            Point actual = ease.InOutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }
        #endregion

    }
}
