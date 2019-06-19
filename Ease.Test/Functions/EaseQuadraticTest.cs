namespace Easing.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class EaseQuadraticTest
    {
        #region In
        [TestMethod]
        public void In_Xis0p6_Yis0p36()
        {
            Ease ease = new Quadratic();
            float x = 0.6f;

            Point expected = new Point(x, 0.36f);
            Point actual = ease.In(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void In_Xis0p3_Yis0p09()
        {
            Ease ease = new Quadratic();
            float x = 0.3f;

            Point expected = new Point(x, 0.09f);
            Point actual = ease.In(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InInverse_Yis0p6_Xis0p7746()
        {
            Ease ease = new Quadratic();
            float y = 0.6f;

            Point expected = new Point(0.7746f, y);
            Point actual = ease.InInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InInverse_Yis0p3_Xis0p5477()
        {
            Ease ease = new Quadratic();
            float y = 0.3f;

            Point expected = new Point(0.5477f, y);
            Point actual = ease.InInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }
        #endregion


        #region Out
        [TestMethod]
        public void Out_Xis0p6_Yis0p84()
        {
            Ease ease = new Quadratic();
            float x = 0.6f;

            Point expected = new Point(x, 0.84f);
            Point actual = ease.Out(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void Out_Xis0p3_Yis0p51()
        {
            Ease ease = new Quadratic();
            float x = 0.3f;

            Point expected = new Point(x, 0.51f);
            Point actual = ease.Out(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void OutInverse_Yis0p6_Xis0p3675()
        {
            Ease ease = new Quadratic();
            float y = 0.6f;

            Point expected = new Point(0.3675f, y);
            Point actual = ease.OutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void OutInverse_Yis0p3_Xis0p1633()
        {
            Ease ease = new Quadratic();
            float y = 0.3f;

            Point expected = new Point(0.1633f, y);
            Point actual = ease.OutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }
        #endregion


        #region InOut
        [TestMethod]
        public void InOut_Xis0p6_Yis0p68()
        {
            Ease ease = new Quadratic();
            float x = 0.6f;

            Point expected = new Point(x, 0.68f);
            Point actual = ease.InOut(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InOut_Xis0p3_Yis0p18()
        {
            Ease ease = new Quadratic();
            float x = 0.3f;

            Point expected = new Point(x, 0.18f);
            Point actual = ease.InOut(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_Yis0p6_Xis0p5528()
        {
            Ease ease = new Quadratic();
            float y = 0.6f;

            Point expected = new Point(0.5528f, y);
            Point actual = ease.InOutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_Yis0p3_Xis0p3873()
        {
            Ease ease = new Quadratic();
            float y = 0.3f;

            Point expected = new Point(0.3873f, y);
            Point actual = ease.InOutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }
        #endregion

    }
}

