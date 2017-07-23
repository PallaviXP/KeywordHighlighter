using System;
using Core;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
         KeywordController _controller;
        public UnitTest1()
        {
            _controller = new KeywordController();

        }
        [Fact]
        public void WhenKeywordNotPresentInputShouldReturnAsItIs()
        {
            string str = "my string";
            var output = _controller.HighlightKewords(str);

            Assert.Equal(str, output);

        }

         [Fact]
        public void WhenKeywordPresentInputShouldReturnWithHighlightedWords()
        {
            string str = "as string";
            string expected = "[blue]as[blue] string";
            var output = _controller.HighlightKewords(str);

            Assert.Equal(expected, output);

        }
    }
}
