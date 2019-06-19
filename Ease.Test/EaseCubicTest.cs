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

            float expected = 0.216f;
            float actual = ease.In(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void In_Xis0p3_Yis0p027()
        {
            Ease ease = new Cubic();
            float x = 0.3f;

            float expected = 0.027f;
            float actual = ease.In(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InInverse_Xis0p6_Yis0p8434()
        {
            Ease ease = new Cubic();
            float x = 0.6f;

            float expected = 0.8434f;
            float actual = ease.InInverse(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InInverse_Xis0p3_Yis0p6694()
        {
            Ease ease = new Cubic();
            float x = 0.3f;

            float expected = 0.6694f;
            float actual = ease.InInverse(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }
        #endregion


        #region Out
        [TestMethod]
        public void Out_Xis0p6_Yis0p936()
        {
            Ease ease = new Cubic();
            float x = 0.6f;

            float expected = 0.936f;
            float actual = ease.Out(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void Out_Xis0p3_Yis0p657()
        {
            Ease ease = new Cubic();
            float x = 0.3f;

            float expected = 0.657f;
            float actual = ease.Out(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void OutInverse_Xis0p6_Yis0p2632()
        {
            Ease ease = new Cubic();
            float x = 0.6f;

            float expected = 0.2632f;
            float actual = ease.OutInverse(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void OutInverse_Xis0p3_Yis0p1121()
        {
            Ease ease = new Cubic();
            float x = 0.3f;

            float expected = 0.1121f;
            float actual = ease.OutInverse(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }
        #endregion


        #region InOut
        [TestMethod]
        public void InOut_Xis0p6_Yis0p744()
        {
            Ease ease = new Cubic();
            float x = 0.6f;

            float expected = 0.744f;
            float actual = ease.InOut(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InOut_Xis0p3_Yis0p108()
        {
            Ease ease = new Cubic();
            float x = 0.3f;

            float expected = 0.108f;
            float actual = ease.InOut(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_Xis0p6_Yis0p5358()
        {
            Ease ease = new Cubic();
            float x = 0.6f;

            float expected = 0.5358f;
            float actual = ease.InOutInverse(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_Xis0p3_Yis0p4217()
        {
            Ease ease = new Cubic();
            float x = 0.3f;

            float expected = 0.4217f;
            float actual = ease.InOutInverse(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }
        #endregion

    }
}
