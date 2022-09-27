public class Program
{
    public static void Main()
    {
        System.Console.WriteLine("Digite um número por favor:");
        int num = int.Parse(System.Console.ReadLine()); // Conversão de inteiro para string
        int contador = 0;
        while (num > 1) 
        {

            contador++;
            if (num % 2 == 0)
            {
                num = num / 2;
                System.Console.WriteLine(num);
            }
            else
            {

                num = (num * 3) + 1;
            }
            Console.WriteLine("Número de voltas da sequência {0}. Atual número da hipótese {1}", contador, num);
        }

    }
}
