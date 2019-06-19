//namespace Easing.Test
//{
//    using Microsoft.VisualStudio.TestTools.UnitTesting;

//    [TestClass]
//    public class EaseLinearTest
//    {
//        #region In
//        [TestMethod]
//        public void In_Xis0p6_Yis0p6()
//        {
//            Ease ease = new Linear();
//            float x = 0.6f;

//            float expected = 0.6f;
//            float actual = ease.In(x);

//            Assert.AreEqual(expected, actual, 0.001f);
//        }

//        [TestMethod]
//        public void In_Xis0p3_Yis0p3()
//        {
//            Ease ease = new Linear();
//            float x = 0.3f;

//            float expected = 0.3f;
//            float actual = ease.In(x);

//            Assert.AreEqual(expected, actual, 0.001f);
//        }

//        [TestMethod]
//        public void InInverse_Xis0p6_Yis0p6()
//        {
//            Ease ease = new Linear();
//            float x = 0.6f;

//            float expected = 0.6f;
//            float actual = ease.InInverse(x);

//            Assert.AreEqual(expected, actual, 0.001f);
//        }

//        [TestMethod]
//        public void InInverse_Xis0p3_Yis0p3()
//        {
//            Ease ease = new Linear();
//            float x = 0.3f;

//            float expected = 0.3f;
//            float actual = ease.InInverse(x);

//            Assert.AreEqual(expected, actual, 0.001f);
//        }
//        #endregion


//        #region Out
//        [TestMethod]
//        public void Out_Xis0p6_Yis0p6()
//        {
//            Ease ease = new Linear();
//            float x = 0.6f;

//            float expected = 0.6f;
//            float actual = ease.Out(x);

//            Assert.AreEqual(expected, actual, 0.001f);
//        }

//        [TestMethod]
//        public void Out_Xis0p3_Yis0p3()
//        {
//            Ease ease = new Linear();
//            float x = 0.3f;

//            float expected = 0.3f;
//            float actual = ease.Out(x);

//            Assert.AreEqual(expected, actual, 0.001f);
//        }

//        [TestMethod]
//        public void OutInverse_Xis0p6_Yis0p6()
//        {
//            Ease ease = new Linear();
//            float x = 0.6f;

//            float expected = 0.6f;
//            float actual = ease.OutInverse(x);

//            Assert.AreEqual(expected, actual, 0.001f);
//        }

//        [TestMethod]
//        public void OutInverse_Xis0p3_Yis0p3()
//        {
//            Ease ease = new Linear();
//            float x = 0.3f;

//            float expected = 0.3f;
//            float actual = ease.OutInverse(x);

//            Assert.AreEqual(expected, actual, 0.001f);
//        }
//        #endregion


//        #region InOut
//        [TestMethod]
//        public void InOut_Xis0p6_Yis0p6()
//        {
//            Ease ease = new Linear();
//            float x = 0.6f;

//            float expected = 0.6f;
//            float actual = ease.InOut(x);

//            Assert.AreEqual(expected, actual, 0.001f);
//        }

//        [TestMethod]
//        public void InOut_Xis0p3_Yis0p3()
//        {
//            Ease ease = new Linear();
//            float x = 0.3f;

//            float expected = 0.3f;
//            float actual = ease.InOut(x);

//            Assert.AreEqual(expected, actual, 0.001f);
//        }

//        [TestMethod]
//        public void InOutInverse_Xis0p6_Yis0p6()
//        {
//            Ease ease = new Linear();
//            float x = 0.6f;

//            float expected = 0.6f;
//            float actual = ease.InOutInverse(x);

//            Assert.AreEqual(expected, actual, 0.001f);
//        }

//        [TestMethod]
//        public void InOutInverse_Xis0p3_Yis0p3()
//        {
//            Ease ease = new Linear();
//            float x = 0.3f;

//            float expected = 0.3f;
//            float actual = ease.InOutInverse(x);

//            Assert.AreEqual(expected, actual, 0.001f);
//        }
//        #endregion

//    }
//}
