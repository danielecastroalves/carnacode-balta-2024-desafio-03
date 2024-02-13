namespace Imc.Models
{
    public class ImcResult
    {
        public double IMC { get; set; }
        public DateTime Date { get; set; }
        public string Classification { get; set; } = null!;
        public string Message { get; set; } = null!;
    }
}
