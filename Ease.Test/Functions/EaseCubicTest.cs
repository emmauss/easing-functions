namespace Easing.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class EaseCubicTest
    {
        #region In
        [TestMethod]
        public void In_Xis0p6_Yis0p216()
        {
            Ease ease = new Cubic();
            float x = 0.6f;

            Point expected = new Point(x, 0.216f);
            Point actual = ease.In(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void In_Xis0p3_Yis0p027()
        {
            Ease ease = new Cubic();
            float x = 0.3f;

            Point expected = new Point(x, 0.027f);
            Point actual = ease.In(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InInverse_Yis0p6_Xis0p8434()
        {
            Ease ease = new Cubic();
            float y = 0.6f;

            Point expected = new Point(0.8434f, y);
            Point actual = ease.InInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InInverse_Yis0p3_Xis0p6694()
        {
            Ease ease = new Cubic();
            float y = 0.3f;

            Point expected = new Point(0.6694f, y);
            Point actual = ease.InInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }
        #endregion


        #region Out
        [TestMethod]
        public void Out_Xis0p6_Yis0p936()
        {
            Ease ease = new Cubic();
            float x = 0.6f;

            Point expected = new Point(x, 0.936f);
            Point actual = ease.Out(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void Out_Xis0p3_Yis0p657()
        {
            Ease ease = new Cubic();
            float x = 0.3f;

            Point expected = new Point(x, 0.657f);
            Point actual = ease.Out(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void OutInverse_Yis0p6_Xis0p2632()
        {
            Ease ease = new Cubic();
            float y = 0.6f;

            Point expected = new Point(0.2632f, y);
            Point actual = ease.OutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void OutInverse_Yis0p3_Xis0p1121()
        {
            Ease ease = new Cubic();
            float y = 0.3f;

            Point expected = new Point(0.1121f, y);
            Point actual = ease.OutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }
        #endregion


        #region InOut
        [TestMethod]
        public void InOut_Xis0p6_Yis0p744()
        {
            Ease ease = new Cubic();
            float x = 0.6f;

            Point expected = new Point(x, 0.744f);
            Point actual = ease.InOut(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InOut_Xis0p3_Yis0p108()
        {
            Ease ease = new Cubic();
            float x = 0.3f;

            Point expected = new Point(x, 0.108f);
            Point actual = ease.InOut(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_Yis0p6_Xis0p5358()
        {
            Ease ease = new Cubic();
            float y = 0.6f;

            Point expected = new Point(0.5358f, y);
            Point actual = ease.InOutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_Yis0p3_Xis0p4217()
        {
            Ease ease = new Cubic();
            float y = 0.3f;

            Point expected = new Point(0.4217f, y);
            Point actual = ease.InOutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }
        #endregion

    }
}
