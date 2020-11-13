using System;
using Newtonsoft.Json;
using Shouldly;
using Xunit;

namespace TestDotnetApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var json = JsonConvert.SerializeObject(new {
                TestProp = "hello"
            });
            
            json.ShouldMatchApproved();
        }
    }
}