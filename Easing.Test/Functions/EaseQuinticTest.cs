namespace Easing.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Easing;

    [TestClass]
    public class EaseQuinticTest
    {
        #region In
        [TestMethod]
        public void In_InputInRange_ReturnsExpectedValue()
        {
            Ease ease = new Quintic();
            float x = 0.6f;

            float expected = 0.0778f;
            float actual = ease.In(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InInverse_InputInRange_ReturnsExpectedValue()
        {
            Ease ease = new Quintic();
            float y = 0.6f;

            float expected = 0.9029f;
            float actual = ease.InInverse(y);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void In_ChangedScaleInputInRange_ReturnsExpectedValue()
        {
            Vector scale = new Vector(4, 6);
            Ease ease = new Quintic(scale);
            float x = 2.5f;

            float expected = 0.572f;
            float actual = ease.In(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InInverse_ChangedScaleInputInRange_ReturnsExpectedValue()
        {
            Vector scale = new Vector(4, 6);
            Ease ease = new Quintic(scale);
            float y = 2.5f;

            float expected = 3.358f;
            float actual = ease.InInverse(y);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void In_InputBelowRange_ReturnsOrigin()
        {
            Ease ease = new Quintic();
            float x = -0.5f;

            float expected = 0;
            float actual = ease.In(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InInverse_InputBelowRange_ReturnsOrigin()
        {
            Ease ease = new Quintic();
            float y = -0.6f;

            float expected = 0;
            float actual = ease.InInverse(y);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void In_ChangedScaleInputBelowRange_ReturnsOrigin()
        {
            Vector scale = new Vector(4, 6);
            Ease ease = new Quintic(scale);
            float x = -1.1f;

            float expected = 0;
            float actual = ease.In(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InInverse_ChangedScaleInputBelowRange_ReturnsOrigin()
        {
            Vector scale = new Vector(4, 6);
            Ease ease = new Quintic(scale);
            float y = -1.1f;

            float expected = 0;
            float actual = ease.InInverse(y);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void In_InputAboveRange_ReturnsDestination()
        {
            Ease ease = new Quintic();
            float x = 1.5f;

            float expected = ease.Scale.Y;
            float actual = ease.In(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InInverse_InputAboveRange_ReturnsDestination()
        {
            Ease ease = new Quintic();
            float y = 1.6f;

            float expected = ease.Scale.X;
            float actual = ease.InInverse(y);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void In_ChangedScaleInputAboveRange_ReturnsDestination()
        {
            Vector scale = new Vector(4, 6);
            Ease ease = new Quintic(scale);
            float x = 11.1f;

            float expected = ease.Scale.Y;
            float actual = ease.In(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InInverse_ChangedScaleInputAboveRange_ReturnsDestination()
        {
            Vector scale = new Vector(4, 6);
            Ease ease = new Quintic(scale);
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
            Ease ease = new Quintic();
            float x = 0.6f;

            float expected = 0.9898f;
            float actual = ease.Out(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void OutInverse_InputInRange_ReturnsExpectedValue()
        {
            Ease ease = new Quintic();
            float y = 0.6f;

            float expected = 0.1674f;
            float actual = ease.OutInverse(y);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void Out_ChangedScaleInputInRange_ReturnsExpectedValue()
        {
            Vector scale = new Vector(4, 6);
            Ease ease = new Quintic(scale);
            float x = 2.5f;

            float expected = 5.956f;
            float actual = ease.Out(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void OutInverse_ChangedScaleInputInRange_ReturnsExpectedValue()
        {
            Vector scale = new Vector(4, 6);
            Ease ease = new Quintic(scale);
            float y = 2.5f;

            float expected = 0.409f;
            float actual = ease.OutInverse(y);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void Out_InputBelowRange_ReturnsOrigin()
        {
            Ease ease = new Quintic();
            float x = -0.5f;

            float expected = 0;
            float actual = ease.Out(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void OutInverse_InputBelowRange_ReturnsOrigin()
        {
            Ease ease = new Quintic();
            float y = -0.6f;

            float expected = 0;
            float actual = ease.OutInverse(y);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void Out_ChangedScaleInputBelowRange_ReturnsOrigin()
        {
            Vector scale = new Vector(4, 6);
            Ease ease = new Quintic(scale);
            float x = -1.1f;

            float expected = 0;
            float actual = ease.Out(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void OutInverse_ChangedScaleInputBelowRange_ReturnsOrigin()
        {
            Vector scale = new Vector(4, 6);
            Ease ease = new Quintic(scale);
            float y = -1.1f;

            float expected = 0;
            float actual = ease.OutInverse(y);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void Out_InputAboveRange_ReturnsDestination()
        {
            Ease ease = new Quintic();
            float x = 1.5f;

            float expected = ease.Scale.Y;
            float actual = ease.Out(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void OutInverse_InputAboveRange_ReturnsDestination()
        {
            Ease ease = new Quintic();
            float y = 1.6f;

            float expected = ease.Scale.X;
            float actual = ease.OutInverse(y);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void Out_ChangedScaleInputAboveRange_ReturnsDestination()
        {
            Vector scale = new Vector(4, 6);
            Ease ease = new Quintic(scale);
            float x = 11.1f;

            float expected = ease.Scale.Y;
            float actual = ease.Out(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void OutInverse_ChangedScaleInputAboveRange_ReturnsDestination()
        {
            Vector scale = new Vector(4, 6);
            Ease ease = new Quintic(scale);
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
            Ease ease = new Quintic();
            float x = 0.6f;

            float expected = 0.8362f;
            float actual = ease.InOut(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_InputInRange_ReturnsExpectedValue()
        {
            Ease ease = new Quintic();
            float y = 0.6f;

            float expected = 0.5218f;
            float actual = ease.InOutInverse(y);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void InOut_InputInRange2_ReturnsExpectedValue()
        {
            Ease ease = new Quintic();
            float x = 0.4f;

            float expected = 0.1638f;
            float actual = ease.InOut(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_InputInRange2_ReturnsExpectedValue()
        {
            Ease ease = new Quintic();
            float y = 0.4f;

            float expected = 0.4782f;
            float actual = ease.InOutInverse(y);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void InOut_ChangedScaleInputInRange_ReturnsExpectedValue()
        {
            Vector scale = new Vector(4, 6);
            Ease ease = new Quintic(scale);
            float x = 2.5f;

            float expected = 5.288f;
            float actual = ease.InOut(x);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void InOutInverse_ChangedScaleInputInRange_ReturnsExpectedValue()
        {
            Vector scale = new Vector(4, 6);
            Ease ease = new Quintic(scale);
            float y = 2.5f;

            float expected = 1.928f;
            float actual = ease.InOutInverse(y);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void InOut_ChangedScaleInputInRange2_ReturnsExpectedValue()
        {
            Vector scale = new Vector(4, 6);
            Ease ease = new Quintic(scale);
            float x = 1.5f;

            float expected = 0.712f;
            float actual = ease.InOut(x);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void InOutInverse_ChangedScaleInputInRange2_ReturnsExpectedValue()
        {
            Vector scale = new Vector(4, 6);
            Ease ease = new Quintic(scale);
            float y = 3.5f;

            float expected = 2.072f;
            float actual = ease.InOutInverse(y);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void InOut_InputBelowRange_ReturnsOrigin()
        {
            Ease ease = new Quintic();
            float x = -0.5f;

            float expected = 0;
            float actual = ease.InOut(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_InputBelowRange_ReturnsOrigin()
        {
            Ease ease = new Quintic();
            float y = -0.6f;

            float expected = 0;
            float actual = ease.InOutInverse(y);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InOut_ChangedScaleInputBelowRange_ReturnsOrigin()
        {
            Vector scale = new Vector(4, 6);
            Ease ease = new Quintic(scale);
            float x = -1.1f;

            float expected = 0;
            float actual = ease.InOut(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_ChangedScaleInputBelowRange_ReturnsOrigin()
        {
            Vector scale = new Vector(4, 6);
            Ease ease = new Quintic(scale);
            float y = -1.1f;

            float expected = 0;
            float actual = ease.InOutInverse(y);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InOut_InputAboveRange_ReturnsDestination()
        {
            Ease ease = new Quintic();
            float x = 1.5f;

            float expected = ease.Scale.Y;
            float actual = ease.InOut(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_InputAboveRange_ReturnsDestination()
        {
            Ease ease = new Quintic();
            float y = 1.6f;

            float expected = ease.Scale.X;
            float actual = ease.InOutInverse(y);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InOut_ChangedScaleInputAboveRange_ReturnsDestination()
        {
            Vector scale = new Vector(4, 6);
            Ease ease = new Quintic(scale);
            float x = 11.1f;

            float expected = ease.Scale.Y;
            float actual = ease.InOut(x);

            Assert.AreEqual(expected, actual, 0.001f);
        }

        [TestMethod]
        public void InOutInverse_ChangedScaleInputAboveRange_ReturnsDestination()
        {
            Vector scale = new Vector(4, 6);
            Ease ease = new Quintic(scale);
            float y = 6.1f;

            float expected = ease.Scale.X;
            float actual = ease.InOutInverse(y);

            Assert.AreEqual(expected, actual, 0.001f);
        }
        #endregion
    }
}
