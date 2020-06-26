using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace extensionMethods
{
    public class methodsTests
    {

        [Fact]
        public void OverloadingMethods()
        {
            var method = new methodExamples();

            var fullName = method.FormatName("Han", "Solo");

            Assert.Equal("Solo, Han", fullName);

            fullName = method.FormatName("Han", "D", "Solo");

            Assert.Equal("Solo, Han D.", fullName);
        }

    }
}
