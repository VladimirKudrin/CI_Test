using NUnit.Framework;
using Util;

namespace ExecutablePathTest
{
    [TestFixture]
    public class Tests
    {
        [OneTimeSetUp]
        public void Init()
        {
            ExecutablePath.InitializeFake(string.Empty);
            Logger.Debug("Trace Init - file : " + ExecutablePath.Combine("Files", "Instruments.txt"));
        }

        [Test]
        public void RemoveBulk()
        {
        }
    }
}