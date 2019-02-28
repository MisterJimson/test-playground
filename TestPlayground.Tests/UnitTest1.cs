using System;
using Newtonsoft.Json;
using Xunit;
using Should;

namespace TestPlayground.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestTest()
        {
            var test = new TestClass
            {
                TestField = TimeSpan.FromMinutes(30)
            };

            var json = JsonConvert.SerializeObject(test);

            var result = JsonConvert.DeserializeObject<TestClass>(json);

            result.TestField.ShouldEqual(test.TestField);
        }

        class TestClass
        {
            public TimeSpan TestField;
        }
    }
}