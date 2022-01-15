using System.IO;

namespace exemplo_poo.Helper
{
    public class FileHelper
    {
        public void listarPastas(string caminho) { 
            //Método para listar pastas
            var retornoCaminho = Directory.GetDirectories(caminho);
                                    //retorna um array
            foreach (var retorno in retornoCaminho) {
                System.Console.WriteLine(retorno);
            }
        }
        public void listarTodasPastas(string caminho) {
            //Método para listar pastas e subpasta
            var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);
            foreach (var retorno in retornoCaminho) {
                System.Console.WriteLine(retorno);
            }
        }
        public void listarArquivos(string caminho) {
            //Método para listar arquivos
            var retornoCaminho = Directory.GetFiles(caminho, "*", SearchOption.AllDirectories);
            foreach (var retorno in retornoCaminho) {
                System.Console.WriteLine(retorno);
            }
        }
        public void criarDiretorio(string caminho){
            var retorno = Directory.CreateDirectory(caminho);
            System.Console.WriteLine(retorno.FullName);
            //Apenas para feedback 
        }
        public void apagarDiretorio(string caminho, bool apagarTudo) {
            Directory.Delete(caminho, apagarTudo);
        }    
        public void criarArquivo(string caminho, string conteudo){
            if(!File.Exists(caminho)){
                File.WriteAllText(caminho, conteudo);
            }
        }
        public void criarArquivoStream(string caminho, List<string> conteudo){
            using (var stream = File.CreateText(caminho)){
                foreach (var linha in conteudo) {
                    stream.WriteLine(linha);
                } 
            }
        }
        public void adicionarTexto(string caminho, string conteudo){
            File.AppendAllText(caminho, conteudo);
        }
        public void adicionarTextoStream(string caminho, List<string> conteudo){
            using (var stream = File.AppendText(caminho)){
                foreach (var linha in conteudo) {
                    stream.WriteLine(linha);
                } 
            }
        }
        public void lerArquivo(string caminho){
            var conteudo = File.ReadAllLines(caminho);
            foreach (var linha in conteudo) {
                System.Console.WriteLine(linha);
            }
        }
        public void lerArquivoStream(string caminho){
            string linha = string.Empty;
            using (var stream = File.OpenText(caminho)) {
                while((linha = stream.ReadLine()) != null) {
                    System.Console.WriteLine(linha);
                }
            }
        }
        public void moverArquivo(string caminho, string novoCaminho, bool sobreescrever){
            File.Move(caminho, novoCaminho, sobreescrever);
        }
        public void copiarArquivo(string caminho, string novoCaminho, bool sobreescrever){
            File.Copy(caminho, novoCaminho, sobreescrever);
        }
        public void deletarArquivo(string caminho){
            File.Delete(caminho);
        }
    }
}
