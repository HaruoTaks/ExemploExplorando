using ExemploExplorando.Models;
using Newtonsoft.Json;
using System.Globalization;
using System.Reflection;


//Deserializando
string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " +
                      $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}

//-------------------------------------------------------------------------
// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de escritório", 25.00M,dataAtual);
// Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);

// Console.WriteLine(serializado);

//---------------------------------------------------------------------------

// int numero = 20;

// bool ehPar = false;

// // IF Ternário - somente é utilizado em casos com if e else, se tiver mais IFs não é possível utilizar 
// ehPar = numero % 2 == 0;

// Console.WriteLine($"O número {numero} é " + (ehPar ? "par": "ímpar"));

// IF tradicional
// if (numero % 2 == 0)
// {
//     Console.WriteLine($"O número {numero} é par");
// }
// else
// {
//     Console.WriteLine($"O número {numero} é impar");
// }

//-----------------------------------------------------------------------

// Desconstrutor
// Pessoa p1 = new Pessoa("Rodrigo", "Takahashi");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");

//------------------------------------------------------------------

//Descartes - coloca o _ no lugar onde quer descartar a informação
// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if(sucesso)
// {
//     //Console.WriteLine("Quantidade linhas do arquivo:" + quantidadedeLinhas);
//     foreach (string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possível ler o arquivo");
// }

// //Tupla
// //Maneira mais usual de se usar a tupla, tem a vantagem de poder nomear os dados
// (int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Rodrigo", "Takahashi", 1.88M);

// // Maneiras válidas de se usar tupla, porem não usuais
// //1
// //ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Rodrigo", "Takahashi", 1.88M);
// //2
// //var outroExemploTuplaCreate = Tuple.Create(1, "Rodrigo", "Takahashi", 1.88M);

// Console.WriteLine($"Id: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Sobrenome: {tupla.Item3}");
// Console.WriteLine($"Altura: {tupla.Item4}");


// // dictionary - chave tem que ter valores únicos, senão irá apresentar exceção
// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");

// // Exibe somente o valor do dictionary
// Console.WriteLine(estados["MG"]);

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// Console.WriteLine("------------------------");

// //Remove elemento passando a chave
// estados.Remove("BA");
// Console.WriteLine("Valor removido");
// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// Console.WriteLine("------------------------");

// //Alterando o valor do dictionary
// estados["SP"] = "São Paulo - valor alterado";

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// Console.WriteLine("------------------------");
// Console.WriteLine("------------------------");

// //Verificando elemento
// string chave = "BA";
// Console.WriteLine($"Verificando o elemento: {chave}");

// // ContainsKey - o método verifica se uma chave foi adicionada ou não
// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }

// //As Pilhas(Stack) seguem a regra LIFO(Last in First Out)
// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// pilha.Push(20);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// A fila(Queue) obedece a regra FIFO(First in First out)
// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

// fila.Enqueue(10);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

//new ExemploExcecao().Metodo1();



// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// } 
// catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
// }
// catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui");
// }



// // formatando datetime
// DateTime data = DateTime.Now;

// Console.WriteLine("Formatando DateTime");
// Console.WriteLine(data.ToString("dd-MM-yyyy HH:mm"));
// Console.WriteLine(data.ToShortDateString());
// Console.WriteLine(data.ToShortTimeString());

// //Parse
// DateTime data1 = DateTime.Parse("05/01/2024 12:00");

// Console.WriteLine("Formatando DateTime Parse");
// Console.WriteLine(data1);

// //TryParse
// string dataString = "2022-04-17 18:00";

// DateTime.TryParseExact(dataString,
//                         "yyyy-MM-dd HH:mm", 
//                         CultureInfo.InvariantCulture, 
//                         DateTimeStyles.None, 
//                         out DateTime data2);

// Console.WriteLine("Formatando DateTime TryParse");
// Console.WriteLine(data2);

// //TryParse com if
// string dataString1 = "2022-04-17 18:00";

// bool sucesso = DateTime.TryParseExact(dataString1,
//                         "yyyy-MM-dd HH:mm", 
//                         CultureInfo.InvariantCulture, 
//                         DateTimeStyles.None, 
//                         out DateTime data3);

// Console.WriteLine("Formatando DateTime TryParse com if");
// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data3}");
// }
// else
// {
//     Console.WriteLine($"{dataString1} não é uma data válida");
// }








// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR")
// ;
// decimal valorMonetario = 1582.40M;

// //Console.WriteLine($"{valorMonetario:C}");
// //Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
// Console.WriteLine(valorMonetario.ToString("N2"));

// double porcentagem = .3421;
// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));


// int numero1 = 10;
// string numero2 = "20";

// // se tiver uma string entre os valores o sinal de + juntara os valores e não somará
// string resultado = numero1 + numero2;

// // resultado será 1020 e não 30
// Console.WriteLine(resultado);




// Pessoa p1 = new Pessoa(nome: "Rodrigo",sobrenome: "Takahashi");

// Pessoa p2 = new Pessoa(nome: "Guilherme",sobrenome: "Takahashi");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();







//----------------------------------------------------------------------------------
// Pessoa p1 = new Pessoa();
// p1.Nome = "Rodrigo";
// p1.Sobrenome = "Takahashi";
// p1.Idade = 31;
// p1.Apresentar();