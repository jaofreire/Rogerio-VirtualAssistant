namespace Rogerio.WEB.Integrations.ElevenLabsApi.Requests
{
    public class TextToSpeechRequest
    {
        public string Text { get; set; } = string.Empty;
        public string Model_id { get; set; } = "eleven_multilingual_v2";

        public TextToSpeechRequest(string text)
        {
            Text = text;
        }
    }

}
