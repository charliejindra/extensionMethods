using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace extensionMethods
{
    public class extensionMethods
    {
        [Fact]
        public void UsingThem()
        {
            int x = 12;
            if (x.isEven())
            {
                //say hoorya
            }
        }
    }
}