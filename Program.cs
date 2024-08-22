// char 
char resp = ' ';
while (resp != 'N')
{
	Console.Clear(); //limpar monitor 

	Console.Write("Entre com a nota da Prova 1 (P1): "); 
	float notap1=float.Parse(Console.ReadLine()); // pode declarar as variáveis depois ou antes igua o consumo

	 
	Console.Write("Entre com o peso da Prova 1 (P1): ");
	float pesop1 = float.Parse(Console.ReadLine());

	Console.Write("Entre com o nota Prova 2 (Projeto): ");
	float notap2 = float.Parse(Console.ReadLine());

	Console.Write("Entre com o peso da Prova 2 (Projeto): ");
	float pesop2 = float.Parse(Console.ReadLine());

	Console.Write("Entre com a nota de quiz : ");
	float notaquiz = float.Parse(Console.ReadLine());

	Console.Write("Entre com o peso do quiz: ");
	float pesoquiz = float.Parse(Console.ReadLine());

	float media = ((notap1 * pesop1) + (notap2 * pesop2) + (notaquiz * pesoquiz)) / (pesop1 + pesop2 + pesoquiz); 

	Console.WriteLine(String.Format("A média final é {0:F2}", media));  //formatar - no lugar do zero imprimir a média na tela

	while (true)
	{
		Console.Write("\n\n\t\t\tDigite 'S' para SIM ou 'N' para NÃO ");  // \n\ salta linha - \t\ cai a coluna
		String input = Console.ReadLine().ToUpper();  // pode fazer sem string - método ToUpper converte p maiúsculo as letras (não minúsculo)
		if (input.Length == 1 && (input[0] == 'S' || input[0] == 'N')) // se dgitor um caracter // length = tamanho (um caracter) 
		{
			resp = input[0];
			break;  // interrupção do laço
		}
		else //entrada inválida se a pessoa digitou algo com mais de um caracter ou algo que não seja S ou N 
		{
			Console.WriteLine("Entrada Inválida! Por favor apenas digite S ou N"); 
		} //CHAVE DO ELSE 
	}// CHAVE DO WHILE(TRUE) 
} // Essa chave fecha o while(resp!='N')