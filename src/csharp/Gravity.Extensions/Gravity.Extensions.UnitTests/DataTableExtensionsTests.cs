using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Data;

namespace Gravity.Extensions.UnitTests
{
    [TestClass]
    public class DataTableExtensionsTests
    {
        [DataTestMethod]
        [DataRow("||Key||Value||\r\n|build|Test Build|\r\n|project|Bug Manager|")]
        [DataRow("||Key||Value||\n|build|Test Build|\n|project|Bug Manager|")]
        public void FromMarkDownPositive(string markDown)
        {
            // parse
            var table = new DataTable().FromMarkDown(markDown);

            // assert
            Assert.IsTrue(table.Rows.Count == 2);
        }
    }
}