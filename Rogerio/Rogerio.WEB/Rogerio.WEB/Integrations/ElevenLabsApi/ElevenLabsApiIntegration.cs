using Rogerio.WEB.Integrations.ElevenLabsApi.Requests;
using Rogerio.WEB.Integrations.Interfaces;
using Rogerio.WEB.Integrations.Refit;

namespace Rogerio.WEB.Integrations.ElevenLabsApi
{
    public class ElevenLabsApiIntegration : IElevenLabsApiIntegration
    {
        private readonly IElevenLabsApiIntegrationRefit _elevenLabsRefit;
        private readonly IConfiguration _configuration;

        private readonly string _apiKey;
        private readonly string _voiceId = "pNInz6obpgDQGcFmaJgB";

        public ElevenLabsApiIntegration(IElevenLabsApiIntegrationRefit elevenLabsRefit, IConfiguration configuration)
        {
            _elevenLabsRefit = elevenLabsRefit;
            _configuration = configuration;

            _apiKey = _configuration["ElevenLabsAPI:ApiKey"]!;
        }

        public async Task<string> TextToSpeech(string text)
        {
            var textToSpeechRequest = new TextToSpeechRequest(text);
            var textToSpeechResponse = await _elevenLabsRefit.TextToSpeech(_apiKey, _voiceId, textToSpeechRequest);

            if (textToSpeechResponse.IsSuccessStatusCode)
            {
                var audioBytes = await textToSpeechResponse.Content.ReadAsByteArrayAsync();
                string base64Audio = Convert.ToBase64String(audioBytes);

                return base64Audio;
            }

            return "";
        }
    }
}
