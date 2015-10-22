using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Daily_3_Easy_CS
{
    [TestClass]
    public class TestCode
    {
        Code code;
        [TestMethod]
        public void codeDecode() {
            code = new Code();

            Assert.AreEqual("Dry run.", code.decode(code.encode("Dry run.")));
            
        }
    }
}
