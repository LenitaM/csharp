internal class Program
{
    private static void Main(string[] args)
    {
        double nA, nG, res;
        nA = nG = res = 0;
        bool repetir = true;
        while (repetir == true)
        {
            Console.WriteLine("Bem-vindo(a)! Programa de comparação de preços entre Álcool e Gasolina");
            Console.WriteLine("Digite o preço atual do Álcool: ");
            nA = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço atual da gasolina: ");
            nG = double.Parse(Console.ReadLine());
            res = (nA / nG);
            if (res >= 0.7)
            {
                Console.WriteLine("Compensa abastecer com gasolina");
            }
            else if (res < 0.7)
            {
                Console.WriteLine("Compensa abastecer com álcool");
            }
            else
            {
                Console.WriteLine("Compensa abastecer com álcool ou gasolina");
            }
            Console.WriteLine("deseja executar novamente? sim ou não");
            string entrada = Console.ReadLine();
            if (entrada == "sim")
            {
                repetir = true;
            }
            else if (entrada == "não")
            {
                repetir = false;
                Console.WriteLine("Fim da sessão. Obrigada!");
            }
        }
    }
}
