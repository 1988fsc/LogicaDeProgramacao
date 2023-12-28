//Casting - TryParse
/*
string a = "25f";
int.TryParse(a, out int b);
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine("Conversão realizada");*/

            //Operadores Condicionais

            //if else - Confirma quantidade estoque
            /*int quantidadeEmEstoque = 2;
            int quantidadeCompra = 0;
            bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= 
            quantidadeCompra;

            Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
            Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
            Console.WriteLine($"Possível Venda? {possivelVenda}");
            if (quantidadeCompra == 0)
            {
                Console.WriteLine ("Venda inválida");
            }
            else if(possivelVenda)
            {
                Console.WriteLine($"Venda realizada.");
            }
            else
            {
                Console.WriteLine($"Desculpe, estoque insuficiente.");
            }*/

            //switch case - Verificar se é vogal
            /*Console.WriteLine("Digite uma Letra");
            string letra = Console.ReadLine();

            switch(letra)
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    Console.WriteLine ("Vogal");
                    break;
                default:
                    Console.WriteLine ("Não é uma vogal");
                    break;
            }*/

            //Or - true||false
            /*bool maiorIdade = false;
            bool autorizadoMenor = false;

            if(maiorIdade || autorizadoMenor)
            {
                Console.WriteLine("liberado");
            }
            else
            {
                Console.WriteLine("Não liberado");
            }*/

            //And - &&
            /*bool presenca = true;
            double media = 9;

            if(presenca && media>= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }*/

            //Not
            /*bool choveu = false;
            bool estaTarde = false;

            if (!choveu && !estaTarde)
            {
                Console.WriteLine("Vou Pedalar");
            }
            else
            {
                Console.WriteLine("Pedalar outro dia");
            }*/


//Class Math

//Pow
/*public void Potencia (int x, int y)
    {
        double pot = Math.Pow(x,y);
        Console.WriteLine($"{x}^{y} = {pot}");
    }*/

// Sin Cos Tan
/*public void Seno (double angulo)
    {
        double radiano = angulo * Math.PI / 180;
        double seno = Math.Sin(radiano);
        Console.WriteLine($"Seno de {angulo} graus = {Math.Round(seno,4)}");
    }
    public void Coseno (double angulo)
    {
        double radiano = angulo * Math.PI / 180;
        double coseno = Math.Cos(radiano);
        Console.WriteLine($"Coseno de {angulo} graus = {Math.Round(coseno,4)}");
    }
    public void Tangente (double angulo)
    {
        double radiano = angulo * Math.PI / 180;
        double tangente = Math.Tan(radiano);
        Console.WriteLine($"Seno de {angulo} graus = {Math.Round(tangente,4)}");
    }*/

// Square root
/*public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz de {x} = {raiz}");
        }*/

//Laço de repetição

//For
/*int numero = 5;

for(int contador = 1; contador <=10; contador++)
{
Console.WriteLine($"{numero}x{contador} = {numero * contador}");
}*/

//While
/*int numero =5;
int contador = 1;

while(contador <=10)
{
    Console.WriteLine($"{contador } Execução: {numero} x {contador} = {numero * contador}");
    contador++;
}*/

