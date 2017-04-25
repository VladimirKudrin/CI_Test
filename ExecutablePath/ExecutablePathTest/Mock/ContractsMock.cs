using System.Collections.Generic;
using Util;

namespace TopTrader.Util.Test.Mock
{
    public class ModelMock
    {
        public ModelMock()
        {
            ExecutablePath.InitializeFake(string.Empty);

            Logger.Debug("Trace Init - file : " + ExecutablePath.Combine("Files", "Instruments.txt"));

            var jsonInstruments = System.IO.File.ReadAllText(ExecutablePath.Combine("Files", "Instruments.txt"));
            var jsonContracts = System.IO.File.ReadAllText(ExecutablePath.Combine("Files", "Contracts.txt"));
        }
    }
}