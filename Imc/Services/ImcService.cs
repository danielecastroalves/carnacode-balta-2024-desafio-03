using Imc.Models;

namespace Imc.Services
{
    public class ImcService
    {
        private readonly List<ImcResult> imcResults = [];

        public void AddResult(double imc)
        {
            var result = new ImcResult
            {
                IMC = imc,
                Date = DateTime.Now,
                Classification = ClassificarIMC(imc),
                Message = ObterMensagem(imc)
            };

            imcResults.Add(result);
        }

        public IReadOnlyList<ImcResult> GetResults()
        {
            return imcResults.AsReadOnly();
        }

        private static string ClassificarIMC(double imc)
        {
            if (imc < 18.5)
                return "Abaixo do peso ❗";
            else if (imc < 24.9)
                return "Peso ideal ✅";
            else if (imc < 29.9)
                return "Sobrepeso ❗";
            else if (imc < 34.9)
                return "Obesidade grau I ❗";
            else if (imc < 39.9)
                return "Obesidade grau II ❗";
            else
                return "Obesidade grau III ❗";
        }

        private static string ObterMensagem(double imc)
        {
            if (imc < 18.5)
                return "Você está abaixo do peso.";
            else if (imc < 24.9)
                return "Parabéns, você está no seu peso ideal!";
            else if (imc < 29.9)
                return "Cuidado, você está com sobrepeso!";
            else if (imc < 34.9)
                return "Atenção, você está com obesidade grau I.";
            else if (imc < 39.9)
                return "Cuidado, você está com obesidade grau II.";
            else
                return "Alerta! Você está com obesidade grau III (mórbida).";
        }
    }
}
