using Tyuiu.YachmenevaPV.Sprint3.Task3.V5.Lib;
namespace Tyuiu.YachmenevaPV.Sprint3.Task3.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceCharInString()
        {
            DataService ds = new DataService();

            string value = "fifa al fall";
            char replaceable = 'a';
            char replacement = '*';
            string res = ds.ReplaceCharInString(value, replaceable, replacement);
            string wait = "fif* *l f*ll";
            Assert.AreEqual(wait, res);

        }
    }
}
