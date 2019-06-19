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

            float expected = 0.36f;
            float actual = ease.In(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void In_Xis0p3_Yis0p09()
        {
            Ease ease = new Quadratic();
            float x = 0.3f;

            float expected = 0.09f;
            float actual = ease.In(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InInverse_Xis0p6_Yis0p7746()
        {
            Ease ease = new Quadratic();
            float x = 0.6f;

            float expected = 0.7746f;
            float actual = ease.InInverse(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InInverse_Xis0p3_Yis0p5477()
        {
            Ease ease = new Quadratic();
            float x = 0.3f;

            float expected = 0.5477f;
            float actual = ease.InInverse(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }
        #endregion


        #region Out
        [TestMethod]
        public void Out_Xis0p6_Yis0p84()
        {
            Ease ease = new Quadratic();
            float x = 0.6f;

            float expected = 0.84f;
            float actual = ease.Out(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void Out_Xis0p3_Yis0p51()
        {
            Ease ease = new Quadratic();
            float x = 0.3f;

            float expected = 0.51f;
            float actual = ease.Out(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void OutInverse_Xis0p6_Yis0p3675()
        {
            Ease ease = new Quadratic();
            float x = 0.6f;

            float expected = 0.3675f;
            float actual = ease.OutInverse(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void OutInverse_Xis0p3_Yis0p1633()
        {
            Ease ease = new Quadratic();
            float x = 0.3f;

            float expected = 0.1633f;
            float actual = ease.OutInverse(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }
        #endregion


        #region InOut
        [TestMethod]
        public void InOut_Xis0p6_Yis0p68()
        {
            Ease ease = new Quadratic();
            float x = 0.6f;

            float expected = 0.68f;
            float actual = ease.InOut(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InOut_Xis0p3_Yis0p18()
        {
            Ease ease = new Quadratic();
            float x = 0.3f;

            float expected = 0.18f;
            float actual = ease.InOut(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_Xis0p6_Yis0p5528()
        {
            Ease ease = new Quadratic();
            float x = 0.6f;

            float expected = 0.5528f;
            float actual = ease.InOutInverse(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_Xis0p3_Yis0p3873()
        {
            Ease ease = new Quadratic();
            float x = 0.3f;

            float expected = 0.3873f;
            float actual = ease.InOutInverse(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }
        #endregion

    }
}

