# <center>Teoria e pratica de Orientação a Objetos com C# </center>

<p align="center">
  <img src="https://cdn.svgporn.com/logos/dotnet.svg" width="150" />
</p>

Olá, caro visitante!
Esse é um pequeno artigo sobre orientação a objeto na plataforma .NET 5, os exemplos são simples e direto. Em cada tópico possui o link do repositório. Toda a referência que utilizei está no fim desse README.

## Índice

1. [Objeto](#Objeto)
2. [Método](#Método)
3. [Third Example](#third-example)
4. [Modificadores de acesso](#Modificadores-de-acesso)
5. [Encapsulamento ](#Encapsulamento)
6. [Construtor](#Construtor)
7. [Propriedade Get e Set](#Propriedade-Get-e-Set)
8. [Palavra chave This](#Palavra-chave-This)
9. [Herança](#Herança)
10. [Polimorfismo](#Polimorfismo)
11. [Método e objeto estático](#Método-e-objeto-estático)
12. [Classe abstrata](#Classe-abstrata)
13. [Interface](#Interface)
14. [Referência ](#Referência)

## Objeto

Um objeto refere-se a uma instância de uma classe e pode ser armazenados em uma variável. Um objeto reserva espaço em memória para guardar seu estado.

```c#
 Pessoa p = new Pessoa();
 //p é um objeto de pessoa; a palavra reservada "new" é necessário
```

[Link do repositório](https://github.com/FerndsLuis/POO_em_Csharp/tree/main/01Conceitos)

## Método

Um método é um bloco de código que contém uma série de instruções. Os métodos são funções da classe. Precisam ter algum tipo de retorno. Podem ter parâmetros.

```c#
//Nome do método: apresentar
//Tipo de retorno: void (não retorna valor)
//Parâmetros: (não possui)
public void apresentar()
{
	Console.WriteLine("Olá");
}

/*------------------------------------------------*/

//Nome do método: apresentar
//Tipo de retorno: void (não retorna valor)
//Parâmetros: nome do tipo string
public void apresentar(string nome)
{
	Console.WriteLine("Olá, "  +  nome);
}

/*------------------------------------------------*/

//Nome do método: media
//Tipo de retorno: double (retorna valor do tipo double)
//Parâmetros: nome do tipo string
public double media()
{
	return (nota1  +  nota2) /  2;
}
```

[Link do repositório](https://github.com/FerndsLuis/POO_em_Csharp/tree/main/02Metodos)

## Modificadores de acesso

Os modificadores de acesso são palavras-chave usadas para especificar a acessibilidade declarada de um membro ou de um tipo.

> **Public** -> Atributos e métodos visíveis em qualquer classe <br> > **Private** -> Atributos e métodos visíveis apenas na classe onde são criados <br> > **Protected** -> Atributos e métodos visíveis em classes onde são criados ou herdados <br> > **Internal** -> O acesso é limitado ao código que faz parte da mesma compilação. <br>

```c#
public string nome; //tipo de acesso público
private double valor; //tipo de acesso privado
```

[Link do repositório](https://github.com/FerndsLuis/POO_em_Csharp/tree/main/05Acesso)

## Encapsulamento

Ocultar o estado interno e a funcionalidade de um objeto e permitir o acesso apenas por meio de um conjunto público de funções. O encapsulamento esconde detalhes de implementação do objeto.

```c#
//Calculo de média
//privados
private double nota1, nota2;

//média
private double media()
{
	return (nota1  +  nota2) /  2;
}

//O método público mensagem está "escondendo" toda a lógica da regra de negócio.
//E só ela será visivel quando instânciar o objeto dessa classe
public void mensagem()
{
	Console.WriteLine("Informe a primeira nota: ");
	nota1  =  Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Informe a segunda nota: ");
	nota2  =  Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("A media é "  +  media());
}
```

[Link do repositório](https://github.com/FerndsLuis/POO_em_Csharp/tree/main/06Encapsulamento)

## Construtor

Tem o mesmo nome da classe, é executado sempre que a classe é iniciada. Os construtores permitem que o programador defina valores padrão.

```c#
public class Pessoa
{
	//construtor sem parâmetro
	public Pessoa()
	{
		Console.WriteLine("Construtor executado");
	}

	//construtor com parâmetro
	public Pessoa(string nome)
	{
		Console.WriteLine("Olá "  +  nome);
	}
}
```

[Link do repositório](https://github.com/FerndsLuis/POO_em_Csharp/tree/main/07Construtor)

## Propriedade Get e Set

Um acessador de propriedade [get](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/get) é usado para retornar o valor da propriedade e um acessador de propriedade [set](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/set) é usado para atribuir um novo valor. Get é como o acesso somente leitura. Set é como o acesso somente gravação.

> **GET** -> retorna o valor da propriedade
> **SET** -> atribui um valor ao elemento da propriedade ou do elemento.

```c#
//atributo
private  string nome;
//get e set
public  string Nome
{
	get { return  nome; }
	set { nome  =  value; }
}
```

[Link do repositório](https://github.com/FerndsLuis/POO_em_Csharp/tree/main/08GetSet)

## Palavra chave This

A palavra-chave this é usada para acessar um membro da instância da própria classe. Ele faz referência ao atributo da classe. Por exemplo, se tiver o atributo da classe e um parâmetro de um método com mesmo nome ele faz referência somente ao atributo da classe e não ao atributo do método.

```c#
public class Pessoa
{
	//atributo da classe
	private string nome =  "Tati";

	//construtor e atributo do método construtor
	public Pessoa(string nome)
	{
		Console.WriteLine(nome); //faz referência ao atributo do método
		Console.WriteLine(this.nome); //faz refência ao atributo da classe
	}
}
```

[Link do repositório](https://github.com/FerndsLuis/POO_em_Csharp/tree/main/09This)

## Herança

Permite a criação de um classe com base em alguma já existente. A classe "principal" é chamada de superclasse e a classe que herda é chamada de subclasse. Na herança, os métodos e atributos da superclasse são compartilhados com a subclasse.

```c#
public class Pessoa //superclasse
{
	//atributos da classe
	protected  string nome;
	protected  int idade;

	//método da classe pessoa
	protected void mensagemPessoa()
	{
		Console.WriteLine("Nome: "  +  nome);
		Console.WriteLine("Idade: "  +  idade);
	}
}

/*------------------------------------------------*/

public  class  Colaborador : Pessoa
//para herdar uma classe com C# é preciso usar o ":" seguido do nome da classe
{
	//atributo da classe colaborador
	private  double salario;

	//construtor, sempre tem o memo nome da classe. Pode ter parâmentros
	public Colaborador(string nome, int idade, double salario)
	{
		this.nome  =  nome; //referência para classe pessoa, por isso o this
		this.idade  =  idade; //referência para classe pessoa, por isso o this
		this.salario  =  salario; //this.salario = referência ao atributo da classe.

		mensagemPessoa(); //método herdado
		mensagemColaborador();
	}

	//método
	protected  void  mensagemColaborador()
	{
		Console.WriteLine("Salario: "  +  salario);
	}
}
```

[Link do repositório](https://github.com/FerndsLuis/POO_em_Csharp/tree/main/10Heranca)

## Polimorfismo

Polimorfismo significa muitas formas, na orientação a objetos você pode enviar uma mesma mensagem para diferentes objetos e fazê-los responder da maneira correta. Poli = muitas, morphos = formas.

```c#
public class Imposto
{
	//palavra reservada "virtual" é obrigatório, pois esse método pode ser sobrescrito
	public virtual void valeAlimentacao(double salario)
	{
		Console.WriteLine("Desconto padrão do vale alimentação R$"  + (salario  *  0.1));
	}
}

/*------------------------------------------------*/

public class Gerente : Imposto //herda os métodos e atributos da classe imposto
{
	//Essa é a mágia. Ele está sobrescrevendo o método valeAlimentacao de Imposto
	//Palavra reservada "override" é obrigatória
	public override void valeAlimentacao(double salario)
	{
		Console.WriteLine("Desconto gerente do vale alimentação R$"  + (salario  *  0.15));
	}
}

/*------------------------------------------------*/

public  class  Estagiario : Imposto
{
	//poderia ter métodos e atributos de estagiario, para o exemplo não é necessário
	//Estamos herdado todos os métodos e atributos de imposto
	//é como se o método valeAlimentacao estivesse aqui.
}

/*------------------------------------------------*/

class  Program
{
	static  void  Main(string[] args)
	{
		//Instanciar gerente
		Imposto objetoG = new Gerente(); //Repara que Imposto recebe Gerente.
		objetoG.valeAlimentacao(5000); //saída: Desconto gerente do vale alimentação...

		//Instanciar estagiário
		Imposto objetoE =  new  Estagiario();  //Repara que Imposto recebe Estagiario.
		objetoE.valeAlimentacao(1000); //saída: Desconto padrão do vale alimentação...
	}
}
```

[Link do repositório](https://github.com/FerndsLuis/POO_em_Csharp/tree/main/11Polimorfismo)

## Método e objeto estático

O membro estático (por exemplo, método e objeto) pode ser chamado em uma outra classe, mesmo quando nenhuma instância da classe foi criada. O membro estático sempre é acessado pelo nome de classe, não pelo nome da instância.

```c#
public class Exemplo
{
	//atributo estático
	public static string nome =  "LUÍS";

	//método estático
	public static void soma(int n1, int n2)
	{
		Console.WriteLine(n1 + n2);
	}
}

/*------------------------------------------------*/

class Program
{
	static  void  Main(string[] args)
	{
		Exemplo.soma(5, 9); //Utilizamos o nome da classe e o método estático, mesmo s/ ter instanciado.
		Console.WriteLine(Exemplo.nome); //Utilizamos o nome da classe e o objeto estático.
	}
}
```

[Link do repositório](https://github.com/FerndsLuis/POO_em_Csharp/tree/main/12Estatico)

## Classe abstrata

Uma classe abstrata é uma classe que serve de modelo para outras classes. Ela sempre será uma superclasse genérica, e suas subclasses serão mais específicas. Não é possível instanciar uma classe abstrata. Cada classe pode herdar só uma classe abstrata.

```c#
public abstract class Padrao
{
	//pode ser público ou protegido - toda classe que herda deve implementar esse método.
	public abstract void  taxaEmprestimo(double valor);
}

/*------------------------------------------------*/

public class PessoaFisica : Padrao
{
	//método obrigatório devido a herança de uma classe abstrata
	public override void taxaEmprestimo(double valor)
	{
		Console.WriteLine("Taxa de emprestimo para pessoa física R$"  + (valor  *  0.1));
	}
}
```

[Link do repositório](https://github.com/FerndsLuis/POO_em_Csharp/tree/main/13Abstracao)

## Interface

Utilizada para criação de métodos obrigatórios para as classes que a herda. Os métodos não possuem implementação. Por padrão um método é abstrato e público.

```c#
interface IPadrao //por padrão utilizamos o "I" antes do nome
{
	void  somar(int n1, int n2);
}

/*------------------------------------------------*/

public class Calculo : IPadrao //herda interface IPadrao
{
	public void somar(int n1, int n2) //obrigatório implementar o método
	{
		Console.WriteLine("A some é: " + (n1 + n2));
	}
}
```

[Link do repositório](https://github.com/FerndsLuis/POO_em_Csharp/tree/main/14Interface)

# Referência

**Grande mestre Ralf Lima**
https://www.youtube.com/watch?v=6Rn3sI3GP50&list=PLWXw8Gu52TRKoaiSaZVIKOHaAoHMeuzu1

https://docs.microsoft.com/pt-br/dotnet/csharp/fundamentals/object-oriented/objects
https://docs.microsoft.com/pt-br/dotnet/csharp/methods
https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers
https://docs.microsoft.com/pt-br/dotnet/csharp/fundamentals/tutorials/oop
https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/constructors
https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/properties
https://social.msdn.microsoft.com/Forums/pt-BR/857bb747-2b7e-4e8e-86c9-fe82ab2b4be7/qual-a-necessida-do-quotthisquot-dentro-de-um-mtodo-em-c?forum=vscsharppt
https://br.ccm.net/contents/414-poo-heranca
http://www.macoratti.net/12/06/c_poli1.htm
https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members
https://pt.wikiversity.org/wiki/Conceitos_de_Orienta%C3%A7%C3%A3o_a_Objetos/Classe_Abstrata
https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/interface
