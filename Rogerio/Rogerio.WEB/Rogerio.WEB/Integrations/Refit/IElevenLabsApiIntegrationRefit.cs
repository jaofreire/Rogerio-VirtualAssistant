using Refit;
using Rogerio.WEB.Integrations.ElevenLabsApi.Requests;

namespace Rogerio.WEB.Integrations.Refit
{
    public interface IElevenLabsApiIntegrationRefit
    {
        [Post("/v1/text-to-speech/{voiceId}")]
        Task<HttpResponseMessage> TextToSpeech([Header("xi-api-key")]string apiKey, [AliasAs("voiceId")]string voiceId, [Body]TextToSpeechRequest request);
    }
}
