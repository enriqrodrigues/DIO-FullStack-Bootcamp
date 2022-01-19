namespace collections.Helper
{
    public class OperacoesArray
    {
        public void OrdenarBubbleSort(ref int[] array) {
            //quando trabalhamos com referência (ref) alteramos o array criado sem criar um novo.
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if(array[j] > array[j+1])
                    {
                        temp = array[j+1];
                        array[j+1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        public void ImprimirArray(int[] array) {
            //Convertemos o array numa string com os elementos separados por vírgula.
            var linha = string.Join(", ", array);
            System.Console.WriteLine(linha);
        }

        //Ordenando com a classe Array
        public void Ordenar(ref int[] array) {
            Array.Sort(array);
        }

        public void Copiar(ref int[] arr1, ref int[] arr2) {
            //Copy recebe os arrays e o número de elementos a copiar.
            Array.Copy(arr1, arr2, arr1.Length);
        }

        public bool Existe(int[] array, int valor) {
            return Array.Exists(array, e => e == valor);
            //"e" representa cada elemento do array e compara-o com "valor"
        }

        public bool VerifcaTodos(int[] array, int valor) {
            return Array.TrueForAll(array, e => e >= valor);
            //"e" representa cada elemento do array e compara-o com "valor"
        }

        public int ObterValor(int[] array, int valor) {
            return Array.Find(array, e => e == valor);
            //Se o valor existir, ele retorna o próprio elemento
            //Se não existir, ele retorna zero.
        }

        public int ObterPosicao(int[] array, int valor) {
            return Array.IndexOf(array, valor);
        //Caso não encontre o valor no array, retorna -1.
        }

        public void alterarArray(ref int[] array, int novoTamanho) {
            Array.Resize(ref array, novoTamanho);
        }

        public string[] ConverterArrayParaString(int[] array) {
            return Array.ConvertAll(array, e => e.ToString());
            //cada elemento é convertido para string.
        }
    }

}