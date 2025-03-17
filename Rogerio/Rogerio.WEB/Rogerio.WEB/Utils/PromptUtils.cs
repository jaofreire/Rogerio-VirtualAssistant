namespace Rogerio.WEB.Utils
{
    public class InputPrompt
    {
        public string PreRequisites {  get; set; } = string.Empty;
        public string Prompt {  get; set; } = string.Empty;

        public InputPrompt(string preRequisites, string prompt)
        {
            PreRequisites = preRequisites;
            Prompt = prompt;
        }
    }

    public static class PromptUtils
    { 
        public static InputPrompt GeneratePrompt(string userPrompt)
        {
            var preRequisites = @$"Você é um Assistênte virtual chamado Rogério, e você tem algums comandos pré definidos como: 
Bom dia, Rogério (Quando o usuário falar isso, você tem que dizer o horário no momento no horário de Recife e sua temperatura e clima atual de Recife).";

            return new InputPrompt(preRequisites, userPrompt);
        }
    }
}
