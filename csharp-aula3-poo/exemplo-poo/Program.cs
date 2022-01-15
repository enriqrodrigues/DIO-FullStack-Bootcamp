using exemplo_poo.Helper;

namespace exemplo_poo
{
    class Program
    {
        static void Main(string[] args)
        {       //MANIPULANDO ARQUIVOS
            var caminho = "C://Users/Henrique Rodrigues/Documents/VS Code/csharp-aula3-poo/files";

            var caminho1 = "C://Users/Henrique Rodrigues";
            
            var listaString = new List<string> {"Linha 1.", "Linha 2.", "Linha 3." };
            
            var listaString2 = new List<string> {"Linha 4.", "Linha 5.", "Linha 6." };


            FileHelper helper = new FileHelper();

            helper.listarPastas(caminho);

            helper.listarTodasPastas(caminho);

            helper.listarArquivos(caminho);

            helper.criarDiretorio(Path.Combine(caminho1, "pasta 3", "subpasta 3"));

            helper.criarArquivo(Path.Combine(caminho1, "arquivoteste.txt") , "Teste de escrita de arquivo.");

            helper.criarArquivoStream(Path.Combine(caminho1, "arquivoteste.txt"), listaString);
            
            helper.adicionarTextoStream(Path.Combine(caminho1, "arquivoteste.txt"), listaString2);
            
            helper.lerArquivoStream(Path.Combine(caminho1, "arquivoteste.txt"));
            
            helper.deletarArquivo(Path.Combine(caminho1, "arquivoteste.txt"));
        }
    }
}
