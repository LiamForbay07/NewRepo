using NumberWordAnalyzerApi.BusinessLogic.Interfaces;
using NumberWordAnalyzerApi.BusinessLogic.Implementation;
using NumberWordAnalyzerApi.DTOs;

namespace NumberWordAnalyzer.UnitTest
{
    public class NumberWordAnalyzerTests
    {
        private readonly INumberWordAnalyzer _numberWordAnalyzer;

        public NumberWordAnalyzerTests()
        {
            //Concrete call because dependency injection would mean that unit tests will have to depend on NumberWordAnalyzerApi to be running to collect it's service collection and configurations:
            _numberWordAnalyzer = new NumberWordAnalyzerApi.BusinessLogic.Implementation.NumberWordAnalyzer();
        }

        [Fact]
        public void NumberWordAnalyzerStillPickUpWordIfThereAreNumbersInString()
        {
            var input = "one234254two23threefour";
            var result = new List<WordCountResultDTO>();
            result = _numberWordAnalyzer.CountNumberWordsFromString(input);
            Assert.NotNull(result);
            Assert.True(result.Count > 0);
        }

        [Fact]
        public void NumberWordAnalyzerStillPickUpWordIfOrderedString()
        {
            var input = "onetwothreefour";
            var result = new List<WordCountResultDTO>();
            result = _numberWordAnalyzer.CountNumberWordsFromString(input);
            Assert.NotNull(result);
            Assert.True(result.Count > 0);
        }

        [Fact]
        public void NumberWordAnalyzerStillPickUpWordIfUpperCaseAndLowerCase()
        {
            var input = "onetwoThreeFour";
            var result = new List<WordCountResultDTO>();

            var isCapitalThreeCounted = false;
            var isCapitalFourCounted = false;

            result = _numberWordAnalyzer.CountNumberWordsFromString(input);
            isCapitalThreeCounted = result.FirstOrDefault(x => x.Word is "Three" or "three").Count > 0;
            isCapitalFourCounted = result.FirstOrDefault(x => x.Word is "Four" or "four").Count > 0;

            Assert.NotNull(result);
            Assert.True(isCapitalThreeCounted);
            Assert.True(isCapitalFourCounted);
        }

        [Fact]
        public void NumberWordAnalyzerStillPickUpWordIfRandomizedOrder()
        {
            var input = "onedgfhjkluytrsgfhjietenadgrhejsfbeonedbsjdbsthree";
            var result = new List<WordCountResultDTO>();
            result = _numberWordAnalyzer.CountNumberWordsFromString(input);
            Assert.NotNull(result);
            Assert.True(result.Count > 0);
        }
    }
}