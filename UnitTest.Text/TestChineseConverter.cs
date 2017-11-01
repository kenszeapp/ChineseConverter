using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pickup.Text; 

namespace UnitTest.Text
{
    [TestClass]
    public class TestChineseConverter
    {
        [TestMethod]
        public void TestToSimplified()
        {
            string hant = "漢字";
            string sc = ChineseConverter.ToSimplified(hant);
            Assert.AreEqual(sc, "汉字");
        }

        [TestMethod]
        public void TestToTraditional()
        {
            string sc = "汉字";
            string hant = ChineseConverter.ToTraditional(sc);            
            Assert.AreEqual(hant, "漢字");
        }


        [TestMethod]
        public void TestToSimplified2()
        {
            string hant = @"美股昨日變化不大，道指上升28點或0.12%，收報23377.24點，標普500指數微升2.43點或0.09%，收報2575點，納指則升28或0.43%，至6727.67點，再創收市新高。雖然只是輕微上升，但若以10月份計表現依然不俗，道指及標普更是連升七個月，為自2012年以來最長月度升幅。單計10月份，道指累升4.3%，標普500指數累升2.2%，納指亦累漲3.6%。 

道指昨日反彈，其中一個原因又是與稅改有關。美國總統特朗普表示，並不希望逐步分階段實施公司減稅。惟早前有美國媒體表示，眾議院編寫稅改方案之Ways and Means委員會成員正討論未來五年逐步下調企業稅，令美國企業稅率於2022年才降至稅改計劃的20 % 的目標。無論如何，稅改稍有差次或未能於年內通過，對美股亦肯定有負面影響。 
";
            string sc = ChineseConverter.ToSimplified(hant);
            string expect = @"美股昨日变化不大，道指上升28点或0.12％，收报23377.24点，标普500指数微升2.43点或0.09％，收报2575点，纳指则升28或0.43％，至6727.67点，再创收市新高。虽然只是轻微上升，但若以10月份计表现依然不俗，道指及标普更是连升七个月，为自2012年以来最长月度升幅。单计10月份，道指累升4.3 ％，标普500指数累升2.2％，纳指亦累涨3.6％。

道指昨日反弹，其中一个原因又是与税改有关。美国总统特朗普表示，并不希望逐步分阶段实施公司减税。惟早前有美国媒体表示，众议院编写税改方案之Ways and Means委员会成员正讨论未来五年逐步下调企业税，令美国企业税率于2022年才降至税改计划的20％的目标。无论如何，税改稍有差次或未能于年内通过，对美股亦肯定有负面影响。";
            Assert.AreEqual(sc, expect);
        }


        [TestMethod]
        public void TestToVBSimplified2()
        {
            string hant = @"美股昨日變化不大，道指上升28點或0.12%，收報23377.24點，標普500指數微升2.43點或0.09%，收報2575點，納指則升28或0.43%，至6727.67點，再創收市新高。雖然只是輕微上升，但若以10月份計表現依然不俗，道指及標普更是連升七個月，為自2012年以來最長月度升幅。單計10月份，道指累升4.3%，標普500指數累升2.2%，納指亦累漲3.6%。 

道指昨日反彈，其中一個原因又是與稅改有關。美國總統特朗普表示，並不希望逐步分階段實施公司減稅。惟早前有美國媒體表示，眾議院編寫稅改方案之Ways and Means委員會成員正討論未來五年逐步下調企業稅，令美國企業稅率於2022年才降至稅改計劃的20 % 的目標。無論如何，稅改稍有差次或未能於年內通過，對美股亦肯定有負面影響。 
";
            string sc = VBChineseConverter.ToSimplified(hant);
            string expect = @"美股昨日变化不大，道指上升28点或0.12％，收报23377.24点，标普500指数微升2.43点或0.09％，收报2575点，纳指则升28或0.43％，至6727.67点，再创收市新高。虽然只是轻微上升，但若以10月份计表现依然不俗，道指及标普更是连升七个月，为自2012年以来最长月度升幅。单计10月份，道指累升4.3 ％，标普500指数累升2.2％，纳指亦累涨3.6％。

道指昨日反弹，其中一个原因又是与税改有关。美国总统特朗普表示，并不希望逐步分阶段实施公司减税。惟早前有美国媒体表示，众议院编写税改方案之Ways and Means委员会成员正讨论未来五年逐步下调企业税，令美国企业税率于2022年才降至税改计划的20％的目标。无论如何，税改稍有差次或未能于年内通过，对美股亦肯定有负面影响。";
            Assert.AreEqual(sc, expect);

        }
    }
}
