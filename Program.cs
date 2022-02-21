// See https://aka.ms/new-console-template for more information
using System;

namespace revisao{
    class Program{
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            int indice = 0;
            string opUsuario = obterOpUsuario();

            while (opUsuario.ToUpper() != "X")
            {

                switch (opUsuario)
                {
                    case "1":
                        //Adicionar aluno
                        Console.WriteLine("Escreva o nome do aluno:");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();
                        Console.WriteLine("Escreva a nota do aluno:");

                        if(decimal.TryParse(Console.ReadLine(), out decimal nota)){
                        aluno.Nota = nota;
                        }else{
                            throw new ArgumentException("O valaor da nota deve ser Decimal.");
                        }
                        alunos[indice] = aluno;
                        indice++;
                        break;
                    case "2":
                        //Listar aluno
                        foreach(var a in alunos){
                            if(!string.IsNullOrEmpty(a.Nome)){
                            Console.WriteLine($"Aluno: {a.Nome} Nota: {a.Nota}");
                            }
                        }
                        
                        break;
                    case "3":
                        //calcular media geral
                        decimal notaTotal = 0;
                        var tAlunos = 0;
                        for(int i=0; i < alunos.Length; i++){
                            if(!string.IsNullOrEmpty(alunos[i].Nome)){
                                notaTotal = notaTotal + alunos[i].Nota;
                                tAlunos++; 
                            }    
                            
                        }

                        var mediaTotal = notaTotal/tAlunos;
                        if(mediaTotal<= 3){
                            Console.WriteLine("E");
                        }else if(mediaTotal > 3 && mediaTotal < 6){
                            Console.WriteLine("D");
                        }else if(mediaTotal > 5 && mediaTotal < 8){
                            Console.WriteLine("C");
                        }else if(mediaTotal > 7 && mediaTotal < 10){
                            Console.WriteLine("B");
                        }else{
                            Console.WriteLine("A");
                        }

                            Console.WriteLine($"Media Geral: {mediaTotal}");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opUsuario = obterOpUsuario();
            }
            

        }

        private static string obterOpUsuario()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("-------------------------");
            Console.WriteLine("1- Insira um novo aluno.");
            Console.WriteLine("2- Listar alunos.");
            Console.WriteLine("3- Calcular media geral.");
            Console.WriteLine("X- Sair.");
            Console.WriteLine("-------------------------");

            String opUsuario = Console.ReadLine();
             Console.WriteLine("-------------------------");
            return opUsuario;
        }
    }
}

