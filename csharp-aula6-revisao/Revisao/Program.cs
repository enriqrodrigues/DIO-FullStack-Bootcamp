// See https://aka.ms/new-console-template for more information
using Revisao;

Aluno[] listaAlunos = new Aluno[5];

string opcaoUsuario = ExibirMenu();
var indiceAlunos = 0;

while(opcaoUsuario.ToUpper() != "X") {
    switch (opcaoUsuario)
    {
        case "1":
            Aluno aluno = new Aluno();
            
            System.Console.WriteLine("Informe o nome do aluno:");
            aluno.Nome = Console.ReadLine();
            
            System.Console.WriteLine("Informe a Nota do aluno:");
            // aluno.Nota = decimal.Parse(Console.ReadLine());
            if (decimal.TryParse(Console.ReadLine(), out decimal nota)) {
                aluno.Nota = nota;
            } else {
                throw new ArgumentOutOfRangeException("Valor da Nota deve ser decimal.");
            }

            listaAlunos[indiceAlunos] = aluno;
            indiceAlunos++;

            break;

        case "2":
            foreach (var a in listaAlunos)
            {
                if (!string.IsNullOrEmpty(a.Nome)) 
                {
                    Console.WriteLine($"Aluno: {a.Nome}- Nota: {a.Nota}");
                }
            }

            break;
        case "3":
            decimal notaTotal = 0;
            var numAlunos = 0;

            for (int i = 0; i < listaAlunos.Length; i++)
            {
                if (!string.IsNullOrEmpty(listaAlunos[i].Nome)) {
                    notaTotal += listaAlunos[i].Nota;
                    numAlunos++;
                }
            }

            var mediaGeral = notaTotal / numAlunos;
            Console.WriteLine($"Média geral: {mediaGeral}");

            break;
        default:
            throw new ArgumentOutOfRangeException();
    }

    opcaoUsuario = ExibirMenu();
}

static string ExibirMenu()
{
    Console.WriteLine();
    Console.WriteLine("Informe a opção desejada: ");
    Console.WriteLine("1 - Inserir aluno.");
    Console.WriteLine("2 - Listar alunos.");
    Console.WriteLine("3 - Calcular Média Geral.");
    Console.WriteLine("X - Sair.");
    Console.WriteLine();

    var a = Console.ReadLine();
    return a;
}

