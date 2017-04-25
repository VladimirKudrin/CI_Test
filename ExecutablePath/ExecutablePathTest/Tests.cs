using System;
using NUnit.Framework;
using TopTrader.Util.Test.Mock;

namespace ExecutablePathTest
{
    [TestFixture]
    public class Tests
    {
        private ModelMock _modelMock = null;
        [OneTimeSetUp]
        public void Init()
        {
            _modelMock = new ModelMock();
        }

        [Test]
        public void RemoveBulk()
        {
            Console.WriteLine("message from RemoveBulk");
        }
    }
}