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

            float expected = 0.0778f;
            float actual = ease.In(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void In_Xis0p3_Yis0p0024()
        {
            Ease ease = new Quintic();
            float x = 0.3f;

            float expected = 0.0024f;
            float actual = ease.In(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InInverse_Xis0p6_Yis0p9029()
        {
            Ease ease = new Quintic();
            float x = 0.6f;

            float expected = 0.9029f;
            float actual = ease.InInverse(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InInverse_Xis0p3_Yis0p786()
        {
            Ease ease = new Quintic();
            float x = 0.3f;

            float expected = 0.786f;
            float actual = ease.InInverse(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }
        #endregion


        #region Out
        [TestMethod]
        public void Out_Xis0p6_Yis0p9898()
        {
            Ease ease = new Quintic();
            float x = 0.6f;

            float expected = 0.9898f;
            float actual = ease.Out(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void Out_Xis0p3_Yis0p8319()
        {
            Ease ease = new Quintic();
            float x = 0.3f;

            float expected = 0.8319f;
            float actual = ease.Out(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void OutInverse_Xis0p6_Yis0p1674()
        {
            Ease ease = new Quintic();
            float x = 0.6f;

            float expected = 0.1674f;
            float actual = ease.OutInverse(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void OutInverse_Xis0p3_Yis0p0689()
        {
            Ease ease = new Quintic();
            float x = 0.3f;

            float expected = 0.0689f;
            float actual = ease.OutInverse(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }
        #endregion


        #region InOut
        [TestMethod]
        public void InOut_Xis0p6_Yis0p8362()
        {
            Ease ease = new Quintic();
            float x = 0.6f;

            float expected = 0.8362f;
            float actual = ease.InOut(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InOut_Xis0p3_Yis0p0389()
        {
            Ease ease = new Quintic();
            float x = 0.3f;

            float expected = 0.0389f;
            float actual = ease.InOut(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_Xis0p6_Yis0p5218()
        {
            Ease ease = new Quintic();
            float x = 0.6f;

            float expected = 0.521823f;
            float actual = ease.InOutInverse(x);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void InOutInverse_Xis0p3_Yis0p4514()
        {
            Ease ease = new Quintic();
            float x = 0.3f;

            float expected = 0.4514f;
            float actual = ease.InOutInverse(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }
        #endregion
    }
}
