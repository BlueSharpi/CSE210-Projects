public class PromptGenerator {
    private string[] _promptsList = {
        "How did I see the hand of the Lord in my life today?",
        "How did I make an effort to stretch myself today?",
        "How was I able to look beyond myself and serve someone else today?",
        "What did the Holy Spirit teach me today?",
        "In what way can I resolve to do better tomorrow?"};
    public string GetRandomPrompt() {
        Random random = new Random();
        string result = _promptsList[random.Next(_promptsList.Length)];
        return result;
    }
}