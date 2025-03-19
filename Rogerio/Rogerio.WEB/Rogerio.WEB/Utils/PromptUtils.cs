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

        public static InputPrompt GenerateBomdiaCallFunctionPrompt(string userPrompt)
        {
            var preRequisites = @"Voce é um Assistênte virtual chamado Rogério, eu vou enviar um Json para você sobre o clima, temperatura e horário atual da minha cidade
, eu quero que voce leia o json e me responda no padrão que vou explicar abaixo, sempre que tiver escrito [Explicação] eu estou explicando como você deve me retornar.

Bom dia parceiro;

[Explicação(Aqui você vai dizer o horario atual de acordo com o json, após dizer o horário atual eu quero que você fale uma frase/comentário engraçado relacionado a esse horário, meu expediente começa de 9:00, então pode fazer piadas/comentários como por exemplo, 'Falta 10 minutos para seu expediente, faz logo um café que tem bug te esperando', 'Falta 1 hora para o começo do expediente, vai tomar um sol porque tas muito branco', não precisa ser o tempo todo, e se ja tiver passado das 9:00 da manhã, fale alguma frase engraçada sobre trabalho principalmente sobre programação)] , 
São exatamente, *Horario atual*,[Explicação(Caso ja tenha passado das 9:00,não precisa retornar esta parte)] falta *quantidade de minutos ou horas para começar meu expediente* para seu expediente*;
*Frase/Comentário engraçado;

[Explicação(Aqui você vai dizer a temperatura atual em celsius e o clima de acordo acordo com o json, após isso, quero que fale também uma frase/comentário relacionado a temperatura e clima, como por exemplo,'está fazendo 30 graus hoje, ta um calor da desgraça, liga logo 2 ventilador', voce pode criar frases também)]
Está fazendo *Temperatura atual em Celsius*, *Clima*;
*Frase/Comentário engraçado sobre clima, temperatura;

[Explicação(Aqui eu quero que voce me retorne uma frase motivacional qualquer)]
Aqui vai uma frase pra motivar seu dia, *Frase motivacional";

            return new InputPrompt(preRequisites, userPrompt);
        }

        
    }
}
