//namespace Easing.Test
//{
//    using Microsoft.VisualStudio.TestTools.UnitTesting;

//    [TestClass]
//    public class EaseQuarticTest
//    {
//        #region In
//        [TestMethod]
//        public void In_Xis0p6_Yis0p1296()
//        {
//            Ease ease = new Quartic();
//            float x = 0.6f;

//            float expected = 0.1296f;
//            float actual = ease.In(x);

//            Assert.AreEqual(expected, actual, 0.001f);
//        }

//        [TestMethod]
//        public void In_Xis0p3_Yis0p0081()
//        {
//            Ease ease = new Quartic();
//            float x = 0.3f;

//            float expected = 0.0081f;
//            float actual = ease.In(x);

//            Assert.AreEqual(expected, actual, 0.001f);
//        }

//        [TestMethod]
//        public void InInverse_Xis0p6_Yis0p8801()
//        {
//            Ease ease = new Quartic();
//            float x = 0.6f;

//            float expected = 0.8801f;
//            float actual = ease.InInverse(x);

//            Assert.AreEqual(expected, actual, 0.001f);
//        }

//        [TestMethod]
//        public void InInverse_Xis0p3_Yis0p7401()
//        {
//            Ease ease = new Quartic();
//            float x = 0.3f;

//            float expected = 0.7401f;
//            float actual = ease.InInverse(x);

//            Assert.AreEqual(expected, actual, 0.001f);
//        }
//        #endregion


//        #region Out
//        [TestMethod]
//        public void Out_Xis0p6_Yis0p9744()
//        {
//            Ease ease = new Quartic();
//            float x = 0.6f;

//            float expected = 0.9744f;
//            float actual = ease.Out(x);

//            Assert.AreEqual(expected, actual, 0.001f);
//        }

//        [TestMethod]
//        public void Out_Xis0p3_Yis0p7599()
//        {
//            Ease ease = new Quartic();
//            float x = 0.3f;

//            float expected = 0.7599f;
//            float actual = ease.Out(x);

//            Assert.AreEqual(expected, actual, 0.001f);
//        }

//        [TestMethod]
//        public void OutInverse_Xis0p6_Yis0p2047()
//        {
//            Ease ease = new Quartic();
//            float x = 0.6f;

//            float expected = 0.2047f;
//            float actual = ease.OutInverse(x);

//            Assert.AreEqual(expected, actual, 0.001f);
//        }

//        [TestMethod]
//        public void OutInverse_Xis0p3_Yis0p0853()
//        {
//            Ease ease = new Quartic();
//            float x = 0.3f;

//            float expected = 0.0853f;
//            float actual = ease.OutInverse(x);

//            Assert.AreEqual(expected, actual, 0.001f);
//        }
//        #endregion


//        #region InOut
//        [TestMethod]
//        public void InOut_Xis0p6_Yis0p7952()
//        {
//            Ease ease = new Quartic();
//            float x = 0.6f;

//            float expected = 0.7952f;
//            float actual = ease.InOut(x);

//            Assert.AreEqual(expected, actual, 0.001f);
//        }

//        [TestMethod]
//        public void InOut_Xis0p3_Yis0p0648()
//        {
//            Ease ease = new Quartic();
//            float x = 0.3f;

//            float expected = 0.0648f;
//            float actual = ease.InOut(x);

//            Assert.AreEqual(expected, actual, 0.001f);
//        }

//        [TestMethod]
//        public void InOutInverse_Xis0p6_Yis0p5271()
//        {
//            Ease ease = new Quartic();
//            float x = 0.6f;

//            float expected = 0.5271f;
//            float actual = ease.InOutInverse(x);

//            Assert.AreEqual(expected, actual, 0.001f);
//        }

//        [TestMethod]
//        public void InOutInverse_Xis0p3_Yis0p4401()
//        {
//            Ease ease = new Quartic();
//            float x = 0.3f;

//            float expected = 0.4401f;
//            float actual = ease.InOutInverse(x);

//            Assert.AreEqual(expected, actual, 0.001f);
//        }
//        #endregion

//    }
//}
