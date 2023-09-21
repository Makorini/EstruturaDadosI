using System.Collections;

//criar hash table (tabela hash)  //new serve pra instancia // openWIth nome da regra// sintatica (tipo de variavel- depois biblioteca para usar o hash table(nome)-new serve para instancoiar (metodo contrutor tem que ter o mesmo nome da variavel)
Hashtable openWith = new Hashtable();

try
{
    openWith.Add("txt","notepad.exe"); //par  key calug primeiro a chave depois o valor
    openWith.Add("bmp","paint.exe");
    openWith.Add("did","paint.exe");
    openWith.Add("rtf","wordpad.exe");

    openWith.Add("txt","notepad++.exe");//toda vez que  tiver uma instruçao de repeticao usar o bloco try para executar um por um para verificar a pilha de erro 
}
/*catch (ArgumentException aex)

    Console.WriteLine("oops, vc rentou add uma chave que ja foi adicionada")//que ja existe //acessando o comteudo da tebela hush
  Console.WriteLine($"Detalhes:{aex.Message}");
}*/
catch(ArgumentException aex) {
    Console.WriteLine("Oops. Invalid key.");
    Console.WriteLine($"Detalhes: {aex.Message}"); // $ = usar varíavel de uma forma mais fácil
}

catch(Exception ex) {
    Console.WriteLine("Error.");
    throw ex;
}

// openWith.Add("dib", "paint.exe");///////// intervalo

// acessando o conteúdo na tabela hash
Console.WriteLine(
    "Na \\ chave = \"rtf\" é {0}"
    , openWith["rtf"]
);

//testar se chave existe na tabela hash
if(openWith.ContainsKey("ht"))
{
    openWith.Add("ht", "hypertrm.exe");
    Console.WriteLine("chave ht adicionada.");
}
//percorrendo hash com foreach
//Console.WriteLine("Program still loading.");
Console.WriteLine();
foreach( DictionaryEntry de in openWith )
{
    Console.WriteLine("key = {0} - Value = {1}"
        , de.Key
        , de.Value
    );
}

// obtendo apenas os valores do hash
ICollection valueCol = openWith.Values;//interface diferente de tela de usuario//gui-gude User interface-View//gui ou vi qaundo quiser falar de tela de usuario//quando falar de interface esta falando de contrato da clase 
//quando cria uma clase cria um tipo diferente de dados//interface e uma espece de coringa//
Console.WriteLine();
foreach(string s in valueCol)
{
    Console.WriteLine("value = {0}", s);
}
// obtendo apenas as chaves do  hash
ICollection keyCol = openWith.keyCol;//interface diferente de tela de usuario//gui-gude User interface-View//gui ou vi qaundo quiser falar de tela de usuario//quando falar de interface esta falando de contrato da clase 
//quando cria uma clase cria um tipo diferente de dados//interface e uma espece de coringa//
Console.WriteLine();
foreach(string s in keyCol)
{
    Console.WriteLine("key = {0}", s);
}
//remove regidtro do 
    Console.WriteLine("Removendo (\"doc\")");
openWith.Remove("doc");
if(!openWkith.Containskey("doc"))
{
    Console.WriteLine(
        "Chave \"doc\"foi removida."
    );
}