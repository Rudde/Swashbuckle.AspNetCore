using System;
using System.Collections.Generic;
using System.Text.Json;
using Xunit;

namespace Swashbuckle.AspNetCore.SwaggerGen.Test
{
    /// <summary>
    /// For ad-hoc serializer testing
    /// </summary>
    public class JsonSerializerTesting
    {
        [Fact]
        public void Serialize()
        {
            object dto = new TestDto { Prop1 = 123 };
            //var dto = new Dictionary<string, object>
            //{
            //    ["foo"] = "bar"
            //};

            var jsonString = JsonSerializer.Serialize(dto);

            //throw new Exception(jsonString);
        }

        [Fact]
        public void Deserialize()
        {
            var dto = JsonSerializer.Deserialize<TestDto>(
                "{ \"Prop1\": 123 }");
        }
    }

    public class TestDto
    {
        public int Prop1 { get; set; }
    }
}
