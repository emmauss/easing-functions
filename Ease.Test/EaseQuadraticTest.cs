using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Easing.Test
{
    [TestClass]
    public class EaseQuadraticTest
    {
        #region In
        [TestMethod]
        public void In_Current1DetlaTime0p1_1()
        {
            Ease.Quadratic ease = new Ease.Quadratic();
            float current = 1.0f;
            float deltaTime = 0.1f;

            float expected = 1f;
            float actual = ease.In(current, deltaTime);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void In_Current1DetlaTime0p2_1()
        {
            Ease.Quadratic ease = new Ease.Quadratic();
            float current = 1.0f;
            float deltaTime = 0.2f;

            float expected = 1f;
            float actual = ease.In(current, deltaTime);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void In_Current0p5DetlaTime0p1_0p6514()
        {
            Ease.Quadratic ease = new Ease.Quadratic();
            float current = 0.5f;
            float deltaTime = 0.1f;

            float expected = 0.6514f;
            float actual = ease.In(current, deltaTime);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void In_Current0p3DetlaTime0p1_0p4195()
        {
            Ease.Quadratic ease = new Ease.Quadratic();
            float current = 0.3f;
            float deltaTime = 0.1f;

            float expected = 0.4195f;
            float actual = ease.In(current, deltaTime);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void In_Current7DetlaTime0p3YScale7TScale3_1()
        {
            Ease.Quadratic ease = new Ease.Quadratic();
            float current = 7.0f;
            float deltaTime = 0.3f;
            float yScale = 7.0f;
            float xScale = 3.0f;

            float expected = 1f;
            float actual = ease.In(current, deltaTime, yScale, xScale);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void In_Current7DetlaTime0p6YScale7TScale3_1()
        {
            Ease.Quadratic ease = new Ease.Quadratic();
            float current = 7.0f;
            float deltaTime = 0.6f;
            float yScale = 7.0f;
            float xScale = 3.0f;

            float expected = 1f;
            float actual = ease.In(current, deltaTime, yScale, xScale);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void In_Current3p5DetlaTime0p3YScale7TScale3_0p6514()
        {
            Ease.Quadratic ease = new Ease.Quadratic();
            float current = 3.5f;
            float deltaTime = 0.3f;
            float yScale = 7.0f;
            float xScale = 3.0f;

            float expected = 0.6514f;
            float actual = ease.In(current, deltaTime, yScale, xScale);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void In_Current2p1DetlaTime0p3YScale7TScale3_0p4195()
        {
            Ease.Quadratic ease = new Ease.Quadratic();
            float current = 2.1f;
            float deltaTime = 0.3f;
            float yScale = 7.0f;
            float xScale = 3.0f;

            float expected = 0.4195f;
            float actual = ease.In(current, deltaTime, yScale, xScale);

            Assert.AreEqual(expected, actual, 0.01f);
        }
        #endregion


        #region Out
        [TestMethod]
        public void Out_Current1DetlaTime0p1_1()
        {
            Ease.Quadratic ease = new Ease.Quadratic();
            float current = 1.0f;
            float deltaTime = 0.1f;

            float expected = 1f;
            float actual = ease.Out(current, deltaTime);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void Out_Current1DetlaTime0p2_1()
        {
            Ease.Quadratic ease = new Ease.Quadratic();
            float current = 1.0f;
            float deltaTime = 0.2f;

            float expected = 1f;
            float actual = ease.Out(current, deltaTime);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void Out_Current0p5DetlaTime0p1_0p6314()
        {
            Ease.Quadratic ease = new Ease.Quadratic();
            float current = 0.5f;
            float deltaTime = 0.1f;

            float expected = 0.6314f;
            float actual = ease.Out(current, deltaTime);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void Out_Current0p3DetlaTime0p1_0p4573()
        {
            Ease.Quadratic ease = new Ease.Quadratic();
            float current = 0.3f;
            float deltaTime = 0.1f;

            float expected = 0.4573f;
            float actual = ease.Out(current, deltaTime);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void Out_Current7DetlaTime0p3YScale7TScale3_1()
        {
            Ease.Quadratic ease = new Ease.Quadratic();
            float current = 7.0f;
            float deltaTime = 0.3f;
            float yScale = 7.0f;
            float xScale = 3.0f;

            float expected = 1f;
            float actual = ease.Out(current, deltaTime, yScale, xScale);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void Out_Current7DetlaTime0p6YScale7TScale3_1()
        {
            Ease.Quadratic ease = new Ease.Quadratic();
            float current = 7.0f;
            float deltaTime = 0.6f;
            float yScale = 7.0f;
            float xScale = 3.0f;

            float expected = 1f;
            float actual = ease.Out(current, deltaTime, yScale, xScale);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void Out_Current3p5DetlaTime0p3YScale7TScale3_0p6314()
        {
            Ease.Quadratic ease = new Ease.Quadratic();
            float current = 3.5f;
            float deltaTime = 0.3f;
            float yScale = 7.0f;
            float xScale = 3.0f;

            float expected = 0.6314f;
            float actual = ease.Out(current, deltaTime, yScale, xScale);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void Out_Current2p1DetlaTime0p3YScale7TScale3_0p4573()
        {
            Ease.Quadratic ease = new Ease.Quadratic();
            float current = 2.1f;
            float deltaTime = 0.3f;
            float yScale = 7.0f;
            float xScale = 3.0f;

            float expected = 0.4573f;
            float actual = ease.Out(current, deltaTime, yScale, xScale);

            Assert.AreEqual(expected, actual, 0.01f);
        }
        #endregion


        #region InOut
        [TestMethod]
        public void InOut_Current1DetlaTime0p1_1()
        {
            Ease.Quadratic ease = new Ease.Quadratic();
            float current = 1.0f;
            float deltaTime = 0.1f;

            float expected = 1f;
            float actual = ease.InOut(current, deltaTime);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void InOut_Current1DetlaTime0p2_1()
        {
            Ease.Quadratic ease = new Ease.Quadratic();
            float current = 1.0f;
            float deltaTime = 0.2f;

            float expected = 1f;
            float actual = ease.InOut(current, deltaTime);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void InOut_Current0p5DetlaTime0p1_0p68()
        {
            Ease.Quadratic ease = new Ease.Quadratic();
            float current = 0.5f;
            float deltaTime = 0.1f;

            float expected = 0.68f;
            float actual = ease.InOut(current, deltaTime);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void InOut_Current0p3DetlaTime0p1_0p4743()
        {
            Ease.Quadratic ease = new Ease.Quadratic();
            float current = 0.3f;
            float deltaTime = 0.1f;

            float expected = 0.4743f;
            float actual = ease.InOut(current, deltaTime);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void InOut_Current7DetlaTime0p3YScale7TScale3_1()
        {
            Ease.Quadratic ease = new Ease.Quadratic();
            float current = 7.0f;
            float deltaTime = 0.3f;
            float yScale = 7.0f;
            float xScale = 3.0f;

            float expected = 1f;
            float actual = ease.InOut(current, deltaTime, yScale, xScale);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void InOut_Current7DetlaTime0p6YScale7TScale3_1()
        {
            Ease.Quadratic ease = new Ease.Quadratic();
            float current = 7.0f;
            float deltaTime = 0.6f;
            float yScale = 7.0f;
            float xScale = 3.0f;

            float expected = 1f;
            float actual = ease.InOut(current, deltaTime, yScale, xScale);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void InOut_Current3p5DetlaTime0p3YScale7TScale3_0p68()
        {
            Ease.Quadratic ease = new Ease.Quadratic();
            float current = 3.5f;
            float deltaTime = 0.3f;
            float yScale = 7.0f;
            float xScale = 3.0f;

            float expected = 0.68f;
            float actual = ease.InOut(current, deltaTime, yScale, xScale);

            Assert.AreEqual(expected, actual, 0.01f);
        }

        [TestMethod]
        public void InOut_Current2p1DetlaTime0p3YScale7TScale3_0p4743()
        {
            Ease.Quadratic ease = new Ease.Quadratic();
            float current = 2.1f;
            float deltaTime = 0.3f;
            float yScale = 7.0f;
            float xScale = 3.0f;

            float expected = 0.4743f;
            float actual = ease.InOut(current, deltaTime, yScale, xScale);

            Assert.AreEqual(expected, actual, 0.01f);
        }
        #endregion
    }
}

