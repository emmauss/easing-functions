namespace Easing.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class EaseSineTest
    {
        #region In
        [TestMethod]
        public void In_Xis0p6_Yis0p4122()
        {
            Ease ease = new Sine();
            float x = 0.6f;

            float expected = 0.4122f;
            float actual = ease.In(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void In_Xis0p3_Yis0p109()
        {
            Ease ease = new Sine();
            float x = 0.3f;

            float expected = 0.109f;
            float actual = ease.In(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InInverse_Xis0p6_Yis0p738()
        {
            Ease ease = new Sine();
            float x = 0.6f;

            float expected = 0.738f;
            float actual = ease.InInverse(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InInverse_Xis0p3_Yis0p5064()
        {
            Ease ease = new Sine();
            float x = 0.3f;

            float expected = 0.5064f;
            float actual = ease.InInverse(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }
        #endregion


        #region Out
        [TestMethod]
        public void Out_Xis0p6_Yis0p809()
        {
            Ease ease = new Sine();
            float x = 0.6f;

            float expected = 0.809f;
            float actual = ease.Out(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void Out_Xis0p3_Yis0p454()
        {
            Ease ease = new Sine();
            float x = 0.3f;

            float expected = 0.454f;
            float actual = ease.Out(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void OutInverse_Xis0p6_Yis0p4097()
        {
            Ease ease = new Sine();
            float x = 0.6f;

            float expected = 0.4097f;
            float actual = ease.OutInverse(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void OutInverse_Xis0p3_Yis0p194()
        {
            Ease ease = new Sine();
            float x = 0.3f;

            float expected = 0.194f;
            float actual = ease.OutInverse(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }
        #endregion


        #region InOut
        [TestMethod]
        public void InOut_Xis0p6_Yis0p6545()
        {
            Ease ease = new Sine();
            float x = 0.6f;

            float expected = 0.6545f;
            float actual = ease.InOut(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InOut_Xis0p3_Yis0p2061()
        {
            Ease ease = new Sine();
            float x = 0.3f;

            float expected = 0.2061f;
            float actual = ease.InOut(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_Xis0p6_Yis0p5641()
        {
            Ease ease = new Sine();
            float x = 0.6f;

            float expected = 0.5641f;
            float actual = ease.InOutInverse(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_Xis0p3_Yis0p369()
        {
            Ease ease = new Sine();
            float x = 0.3f;

            float expected = 0.369f;
            float actual = ease.InOutInverse(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }
        #endregion
    }
}
