using FluentAssertions;
using Practice_.Net8.src.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_.Net8_Tests.General
{
  
    public class EncodingStringsToBytes_Test
    {
        [Fact]
        public void EncodingDecodingTets()
        {

            string originalName = "bruceprsad";
            byte[] asciiEncodedName = EncodingStringsToBytes.ConvertToAsciiEncoding(originalName);
            string generatedName = EncodingStringsToBytes.ConvertToAsciiDecoding(asciiEncodedName);
            generatedName.Should().Be(originalName);


            string originalAddress = "NarreWarren";
            byte[] utf8EncodedAddress = EncodingStringsToBytes.ConvertToUTF8Encoding(originalAddress);
            string generatedAddress = EncodingStringsToBytes.ConvertToUTF8Decoding(utf8EncodedAddress);
            originalAddress.Should().Be(generatedAddress);

        }

    }
}
