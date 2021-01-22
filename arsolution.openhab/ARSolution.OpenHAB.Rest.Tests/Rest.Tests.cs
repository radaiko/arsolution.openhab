using ARSolution.OpenHAB.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ARSolution.OpenHAB.Rest.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private readonly string openhabServer = "192.168.1.207";

        private readonly int openhabPort = 8080;

        [TestMethod]
        public async System.Threading.Tasks.Task GetItemsAsync_IsSuccessfullAsync()
        {
            var rest = new Rest(openhabServer, openhabPort);
            Item[] items = await rest.GetItemsAsync().ConfigureAwait(false);
            Assert.IsNotNull(items);
        }
    }
}