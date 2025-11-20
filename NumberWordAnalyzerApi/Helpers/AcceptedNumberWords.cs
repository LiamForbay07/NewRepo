namespace NumberWordAnalyzerApi.Helpers
{
    public static class AcceptedNumberWords
    {
        //Dictionary of accepted number words
        public static Dictionary<string, int> GetAcceptedNumberWords()
        {
            Dictionary<string, int> acceptedNumberWords = new(StringComparer.OrdinalIgnoreCase)
            {
                ["zero"] = 0,
                ["one"] = 1,
                ["two"] = 2,
                ["three"] = 3,
                ["four"] = 4,
                ["five"] = 5,
                ["six"] = 6,
                ["seven"] = 7,
                ["eight"] = 8,
                ["nine"] = 9,
                ["ten"] = 10
            };
            return acceptedNumberWords;
        }
    }
}
