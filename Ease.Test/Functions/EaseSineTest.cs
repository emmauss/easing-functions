namespace Easing.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class EaseSineTest
    {
        #region In
        [TestMethod]
        public void In_InputInRange_ReturnsExpectedValue()
        {
            Ease ease = new Sine();
            float x = 0.6f;

            float expected = 0.4122f;
            float actual = ease.In(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InInverse_InputInRange_ReturnsExpectedValue()
        {
            Ease ease = new Sine();
            float y = 0.6f;

            float expected = 0.738f;
            float actual = ease.InInverse(y);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void In_ChangedScaleInputInRange_ReturnsExpectedValue()
        {
            Vector scale = new Vector(4, 6);
            Ease ease = new Sine(scale);
            float x = 2.5f;

            float expected = 2.667f;
            float actual = ease.In(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InInverse_ChangedScaleInputInRange_ReturnsExpectedValue()
        {
            Vector scale = new Vector(4, 6);
            Ease ease = new Sine(scale);
            float y = 2.5f;

            float expected = 2.414f;
            float actual = ease.InInverse(y);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void In_InputBelowRange_ReturnsOrigin()
        {
            Ease ease = new Sine();
            float x = -0.5f;

            float expected = 0;
            float actual = ease.In(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InInverse_InputBelowRange_ReturnsOrigin()
        {
            Ease ease = new Sine();
            float y = -0.6f;

            float expected = 0;
            float actual = ease.InInverse(y);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void In_ChangedScaleInputBelowRange_ReturnsOrigin()
        {
            Vector scale = new Vector(4, 6);
            Ease ease = new Sine(scale);
            float x = -1;

            float expected = 0;
            float actual = ease.In(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InInverse_ChangedScaleInputBelowRange_ReturnsOrigin()
        {
            Vector scale = new Vector(4, 6);
            Ease ease = new Sine(scale);
            float y = -1;

            float expected = 0;
            float actual = ease.InInverse(y);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void In_InputAboveRange_ReturnsDestination()
        {
            Ease ease = new Sine();
            float x = 1.5f;

            float expected = ease.Scale.Y;
            float actual = ease.In(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InInverse_InputAboveRange_ReturnsDestination()
        {
            Ease ease = new Sine();
            float y = 1.6f;

            float expected = ease.Scale.X;
            float actual = ease.InInverse(y);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void In_ChangedScaleInputAboveRange_ReturnsDestination()
        {
            Vector scale = new Vector(4, 6);
            Ease ease = new Sine(scale);
            float x = 11.1f;

            float expected = ease.Scale.Y;
            float actual = ease.In(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InInverse_ChangedScaleInputAboveRange_ReturnsDestination()
        {
            Vector scale = new Vector(4, 6);
            Ease ease = new Sine(scale);
            float y = 6.1f;

            float expected = ease.Scale.X;
            float actual = ease.InInverse(y);

            Assert.AreEqual(expected, actual, 0.001f);
        }
        #endregion


        #region Out
        [TestMethod]
        public void Out_InputInRange_ReturnsExpectedValue()
        {
            Ease ease = new Sine();
            float x = 0.6f;

            float expected = 0.809f;
            float actual = ease.Out(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void OutInverse_InputInRange_ReturnsExpectedValue()
        {
            Ease ease = new Sine();
            float y = 0.6f;

            float expected = 0.4097f;
            float actual = ease.OutInverse(y);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void Out_ChangedScaleInputInRange_ReturnsExpectedValue()
        {
            Vector scale = new Vector(4, 6);
            Ease ease = new Sine(scale);
            float x = 2.5f;

            float expected = 4.989f;
            float actual = ease.Out(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void OutInverse_ChangedScaleInputInRange_ReturnsExpectedValue()
        {
            Vector scale = new Vector(4, 6);
            Ease ease = new Sine(scale);
            float y = 2.5f;

            float expected = 1.094f;
            float actual = ease.OutInverse(y);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void Out_InputBelowRange_ReturnsOrigin()
        {
            Ease ease = new Sine();
            float x = -0.5f;

            float expected = 0;
            float actual = ease.Out(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void OutInverse_InputBelowRange_ReturnsOrigin()
        {
            Ease ease = new Sine();
            float y = -0.6f;

            float expected = 0;
            float actual = ease.OutInverse(y);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void Out_ChangedScaleInputBelowRange_ReturnsOrigin()
        {
            Vector scale = new Vector(4, 6);
            Ease ease = new Sine(scale);
            float x = -1.1f;

            float expected = 0;
            float actual = ease.Out(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void OutInverse_ChangedScaleInputBelowRange_ReturnsOrigin()
        {
            Vector scale = new Vector(4, 6);
            Ease ease = new Sine(scale);
            float y = -1.1f;

            float expected = 0;
            float actual = ease.OutInverse(y);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void Out_InputAboveRange_ReturnsDestination()
        {
            Ease ease = new Sine();
            float x = 1.5f;

            float expected = ease.Scale.Y;
            float actual = ease.Out(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void OutInverse_InputAboveRange_ReturnsDestination()
        {
            Ease ease = new Sine();
            float y = 1.6f;

            float expected = ease.Scale.X;
            float actual = ease.OutInverse(y);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void Out_ChangedScaleInputAboveRange_ReturnsDestination()
        {
            Vector scale = new Vector(4, 6);
            Ease ease = new Sine(scale);
            float x = 11.1f;

            float expected = ease.Scale.Y;
            float actual = ease.Out(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void OutInverse_ChangedScaleInputAboveRange_ReturnsDestination()
        {
            Vector scale = new Vector(4, 6);
            Ease ease = new Sine(scale);
            float y = 6.1f;

            float expected = ease.Scale.X;
            float actual = ease.OutInverse(y);

            Assert.AreEqual(expected, actual, 0.001f);
        }
        #endregion


        #region InOut
        [TestMethod]
        public void InOut_InputInRange_ReturnsExpectedValue()
        {
            Ease ease = new Sine();
            float x = 0.6f;

            float expected = 0.6545f;
            float actual = ease.InOut(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_InputInRange_ReturnsExpectedValue()
        {
            Ease ease = new Sine();
            float y = 0.6f;

            float expected = 0.5641f;
            float actual = ease.InOutInverse(y);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InOut_ChangedScaleInputInRange_ReturnsExpectedValue()
        {
            Vector scale = new Vector(4, 6);
            Ease ease = new Sine(scale);
            float x = 2.5f;

            float expected = 4.148f;
            float actual = ease.InOut(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_ChangedScaleInputInRange_ReturnsExpectedValue()
        {
            Vector scale = new Vector(4, 6);
            Ease ease = new Sine(scale);
            float y = 2.5f;

            float expected = 1.787f;
            float actual = ease.InOutInverse(y);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InOut_InputBelowRange_ReturnsOrigin()
        {
            Ease ease = new Sine();
            float x = -0.5f;

            float expected = 0;
            float actual = ease.InOut(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_InputBelowRange_ReturnsOrigin()
        {
            Ease ease = new Sine();
            float y = -0.6f;

            float expected = 0;
            float actual = ease.InOutInverse(y);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InOut_ChangedScaleInputBelowRange_ReturnsOrigin()
        {
            Vector scale = new Vector(4, 6);
            Ease ease = new Sine(scale);
            float x = -1.1f;

            float expected = 0;
            float actual = ease.InOut(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_ChangedScaleInputBelowRange_ReturnsOrigin()
        {
            Vector scale = new Vector(4, 6);
            Ease ease = new Sine(scale);
            float y = -1.1f;

            float expected = 0;
            float actual = ease.InOutInverse(y);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InOut_InputAboveRange_ReturnsDestination()
        {
            Ease ease = new Sine();
            float x = 1.5f;

            float expected = ease.Scale.Y;
            float actual = ease.InOut(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_InputAboveRange_ReturnsDestination()
        {
            Ease ease = new Sine();
            float y = 1.6f;

            float expected = ease.Scale.X;
            float actual = ease.InOutInverse(y);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InOut_ChangedScaleInputAboveRange_ReturnsDestination()
        {
            Vector scale = new Vector(4, 6);
            Ease ease = new Sine(scale);
            float x = 11.1f;

            float expected = ease.Scale.Y;
            float actual = ease.InOut(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_ChangedScaleInputAboveRange_ReturnsDestination()
        {
            Vector scale = new Vector(4, 6);
            Ease ease = new Sine(scale);
            float y = 6.1f;

            float expected = ease.Scale.X;
            float actual = ease.InOutInverse(y);

            Assert.AreEqual(expected, actual, 0.001f);
        }
        #endregion
    }
}
