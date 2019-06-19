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

            float expected = 0.2f;
            float actual = ease.In(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void In_Xis0p3_Yis0p0461()
        {
            Ease ease = new Circular();
            float x = 0.3f;

            float expected = 0.0461f;
            float actual = ease.In(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InInverse_Xis0p6_Yis0p9165()
        {
            Ease ease = new Circular();
            float x = 0.6f;

            float expected = 0.9165f;
            float actual = ease.InInverse(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InInverse_Xis0p3_Yis0p7141()
        {
            Ease ease = new Circular();
            float x = 0.3f;

            float expected = 0.7141f;
            float actual = ease.InInverse(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }
        #endregion


        #region Out
        [TestMethod]
        public void Out_Xis0p6_Yis0p9165()
        {
            Ease ease = new Circular();
            float x = 0.6f;

            float expected = 0.9165f;
            float actual = ease.Out(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void Out_Xis0p3_Yis0p7141()
        {
            Ease ease = new Circular();
            float x = 0.3f;

            float expected = 0.7141f;
            float actual = ease.Out(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void OutInverse_Xis0p6_Yis0p714()
        {
            Ease ease = new Circular();
            float x = 0.6f;

            float expected = 0.2f;
            float actual = ease.OutInverse(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void OutInverse_Xis0p3_Yis0p0461()
        {
            Ease ease = new Circular();
            float x = 0.3f;

            float expected = 0.0461f;
            float actual = ease.OutInverse(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }
        #endregion


        #region InOut
        [TestMethod]
        public void InOut_Xis0p6_Yis0p8()
        {
            Ease ease = new Circular();
            float x = 0.6f;

            float expected = 0.8f;
            float actual = ease.InOut(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InOut_Xis0p3_Yis0p1()
        {
            Ease ease = new Circular();
            float x = 0.3f;

            float expected = 0.1f;
            float actual = ease.InOut(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_Xis0p6_Yis0p5101()
        {
            Ease ease = new Circular();
            float x = 0.6f;

            float expected = 0.5101f;
            float actual = ease.InOutInverse(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_Xis0p3_Yis0p4583()
        {
            Ease ease = new Circular();
            float x = 0.3f;

            float expected = 0.4583f;
            float actual = ease.InOutInverse(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }
        #endregion
    }
}
