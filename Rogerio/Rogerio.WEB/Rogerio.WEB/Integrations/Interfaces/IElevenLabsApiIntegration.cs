namespace Rogerio.WEB.Integrations.Interfaces
{
    public interface IElevenLabsApiIntegration
    {
        Task<string> TextToSpeech(string text);
    }
}
