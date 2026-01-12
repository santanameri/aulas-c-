    static void Main()
    {
       
        int numeroDigitado = -1; 

        Console.WriteLine("Adivinhe o número para encerrar o programa.");

        
        while (numeroDigitado != 0)
        {
            Console.Write("Digite um número: ");
            
            
            if (int.TryParse(Console.ReadLine(), out numeroDigitado))
            {
                
                if (numeroDigitado != 0)
                {
                    Console.WriteLine("Você errou! Tente novamente.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, digite um número válido.");
                numeroDigitado = -1; 
            }
        }

 
        Console.WriteLine("Parabéns, você acertou o número!");
		  }