namespace Easing.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class EaseQuinticTest
    {
        #region In
        [TestMethod]
        public void In_Xis0p6_Yis0p0778()
        {
            Ease ease = new Quintic();
            float x = 0.6f;

            Point expected = new Point(x, 0.0778f);
            Point actual = ease.In(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void In_Xis0p3_Yis0p0024()
        {
            Ease ease = new Quintic();
            float x = 0.3f;

            Point expected = new Point(x, 0.0024f);
            Point actual = ease.In(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InInverse_Yis0p6_Xis0p9029()
        {
            Ease ease = new Quintic();
            float y = 0.6f;

            Point expected = new Point(0.9029f, y);
            Point actual = ease.InInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InInverse_Yis0p3_Xis0p786()
        {
            Ease ease = new Quintic();
            float y = 0.3f;

            Point expected = new Point(0.786f, y);
            Point actual = ease.InInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }
        #endregion


        #region Out
        [TestMethod]
        public void Out_Xis0p6_Yis0p9898()
        {
            Ease ease = new Quintic();
            float x = 0.6f;

            Point expected = new Point(x, 0.9898f);
            Point actual = ease.Out(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void Out_Xis0p3_Yis0p8319()
        {
            Ease ease = new Quintic();
            float x = 0.3f;

            Point expected = new Point(x, 0.8319f);
            Point actual = ease.Out(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void OutInverse_Yis0p6_Xis0p1674()
        {
            Ease ease = new Quintic();
            float y = 0.6f;

            Point expected = new Point(0.1674f, y);
            Point actual = ease.OutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void OutInverse_Yis0p3_Xis0p0689()
        {
            Ease ease = new Quintic();
            float y = 0.3f;

            Point expected = new Point(0.0689f, y);
            Point actual = ease.OutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }
        #endregion


        #region InOut
        [TestMethod]
        public void InOut_Xis0p6_Yis0p8362()
        {
            Ease ease = new Quintic();
            float x = 0.6f;

            Point expected = new Point(x, 0.8362f);
            Point actual = ease.InOut(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InOut_Xis0p3_Yis0p0389()
        {
            Ease ease = new Quintic();
            float x = 0.3f;

            Point expected = new Point(x, 0.0389f);
            Point actual = ease.InOut(x);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_Yis0p6_Xis0p5218()
        {
            Ease ease = new Quintic();
            float y = 0.6f;

            Point expected = new Point(0.5218f, y);
            Point actual = ease.InOutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.01f);
            Assert.AreEqual(expected.Y, actual.Y, 0.01f);
        }

        [TestMethod]
        public void InOutInverse_Yis0p3_Xis0p4514()
        {
            Ease ease = new Quintic();
            float y = 0.3f;

            Point expected = new Point(0.4514f, y);
            Point actual = ease.InOutInverse(y);

            Assert.AreEqual(expected.X, actual.X, 0.001f);
            Assert.AreEqual(expected.Y, actual.Y, 0.001f);
        }
        #endregion
    }
}
