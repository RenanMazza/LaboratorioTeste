using System;




public class Jogador
{   // CLASSE Jogador

    public int Energia;         //PROPRIEDADES DA CLASSE

    public string Nome;         //PROPRIEDADES DA CLASSE

    public int Idade;           //PROPRIEDADES DA CLASSE



    public Jogador(string nomeJogador, int idade, int energiacoletada) //CONSTRUTOR // TUDO ENTRE PARENTESES SÃO ATRIBUTOS 
    {                                                                          

        Energia = energiacoletada;
        Nome = nomeJogador;
        Idade = idade;

    }

}
class Program
{
    static void Main(string[] args) // METODO MAIN - ONDE DESENVOLVEMOS TODO NOSSO CODIGO
    {

        var idadeJogador = 21;
        var energiaMinima = 50;
         
       

        Jogador j1 = new Jogador("Renan", 19, 40);  //OBJETO DA CLASSE JOGADOR // INSTANCIA AS VARIAVEIS DO JOGADOR(ENERGIA E IDADE)
        
        
        if (j1.Idade >= idadeJogador && j1.Energia >= energiaMinima) // BOLEANO DE CONDIÇÕES DE EXECUÇÃO
        {
            Console.WriteLine($"Energia do {j1.Nome} é {j1.Energia} e sua idade é {j1.Idade}, Portanto ele é compativel"); //EXECUÇÃO "SE"
            
        }
            else
            Console.WriteLine($"Energia do {j1.Nome} é {j1.Energia} e sua idade é {j1.Idade}, Portanto não é compativel"); // EXECUÇÃO "SE NÃO"
            


    }
}
