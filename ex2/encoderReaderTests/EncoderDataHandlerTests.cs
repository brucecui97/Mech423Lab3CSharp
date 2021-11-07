using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Tests
{
    [TestClass()]
    public class EncoderDataHandlerTests
    {
        [TestMethod()]
        public void calculateRotationalSpeedHzTest()
        {
            EncoderData encoderData = new EncoderData(127, 123, 154, 167);
            double expectedRotationalSpeedHz = (32635 - 39591) / EncoderDataHandler.COUNT_PER_REVOLUTION / EncoderDataHandler.SECONDS_BETWEEN_UART;
            Assert.AreEqual(EncoderDataHandler.calculateRotationalSpeedHz(encoderData), expectedRotationalSpeedHz);
            //0111111101111011 - 1001101010100111
        }
    }
}