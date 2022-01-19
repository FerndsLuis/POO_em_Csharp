# Teoria e pratica de Orientação a Objetos com C# utilizando .NET 5

Olá, caro visitante!
Esse é um pequeno artigo sobre orientação a objeto na plataforma .NET 5, os exemplos são simples e direto. Em cada tópico possui o link do repositório. Toda a referência que utilizei está no fim desse README.

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

> **Public** -> Atributos e métodos visíveis em qualquer classe
> **Private** -> Atributos e métodos visíveis apenas na classe onde são criados
> **Protected** -> Atributos e métodos visíveis em classes onde são criados ou herdados
> **Internal** -> O acesso é limitado ao código que faz parte da mesma compilação.

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

# Referência

**Grande mestre Ralf Lima**
https://www.youtube.com/watch?v=6Rn3sI3GP50&list=PLWXw8Gu52TRKoaiSaZVIKOHaAoHMeuzu1

https://docs.microsoft.com/pt-br/dotnet/csharp/fundamentals/object-oriented/objects

https://docs.microsoft.com/pt-br/dotnet/csharp/methods

https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers

https://docs.microsoft.com/pt-br/dotnet/csharp/fundamentals/tutorials/oop

https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/constructors
