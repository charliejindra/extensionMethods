using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace extensionMethods
{
    public class VariousOOPStuff
    {
        
        [Fact]
        public void MakeARetiree()
        {
            var earl = new Retiree()
            {
                FirstName = "Earl",
                LastName = "Jones"
            };
        }
    }

}
