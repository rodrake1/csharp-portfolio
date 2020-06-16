using System;
using System.Collections.Generic;
using System.Globalization;

namespace my_first_project
{
  class Program
  {
    static void Main(string[] args)
    {
      // ==================================================
      // Exercício aula 18:
      // ==================================================

      // string produto1 = "Computador";
      // string produto2 = "Mesa de escritório";
      // byte idade = 30;
      // int codigo = 5290;
      // char genero = 'M';
      // double preco1 = 2100;
      // double preco2 = 650.50;
      // double medida = 53.234567;
      // Console.WriteLine("Prdoutos:");
      // Console.WriteLine($"{produto1}, cujo preço é $ {preco1:F2}");
      // Console.WriteLine($"{produto2}, cujo preço é $ {preco2:F2}");
      // Console.WriteLine();
      // Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
      // Console.WriteLine();
      // Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
      // Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
      // Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));

      // ==================================================
      // Exercício aula 23:
      // ==================================================

      // Console.Write("Entre com seu nome completo: ");
      // string nome = Console.ReadLine();
      // Console.Write("Quantos quartos tem na sua casa? ");
      // int quartos = int.Parse(Console.ReadLine());
      // Console.Write("Entre com o preço de um produto: ");
      // double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      // Console.Write("Entre seu último nome, idade e altura (mesma linha): ");
      // string[] dados = Console.ReadLine().Split(' ');
      // string ultimoNome = dados[0];
      // int idade = int.Parse(dados[1]);
      // double altura = double.Parse(dados[2], CultureInfo.InvariantCulture);
      // Console.WriteLine(nome);
      // Console.WriteLine(quartos);
      // Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
      // Console.WriteLine(ultimoNome);
      // Console.WriteLine(idade);
      // Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

      // ==================================================
      // Exercícios classes, objetos e atributos:
      // ==================================================

      // ==================================================
      // Exercício 1:
      // ==================================================

      // Pessoa pessoa1, pessoa2;
      // string pessoaMaisVelha;

      // pessoa1 = new Pessoa();
      // pessoa2 = new Pessoa();

      // Console.WriteLine("Dados da primeira pessoa: ");
      // Console.Write("Nome: ");
      // pessoa1.Nome = Console.ReadLine();
      // Console.Write("Idade: ");
      // pessoa1.Idade = int.Parse(Console.ReadLine());
      //
      // Console.WriteLine("Dados da segunda pessoa: ");
      // Console.Write("Nome: ");
      // pessoa2.Nome = Console.ReadLine();
      // Console.Write("Idade: ");
      // pessoa2.Idade = int.Parse(Console.ReadLine());
      //
      // pessoaMaisVelha = pessoa1.Idade > pessoa2.Idade ? pessoa1.Nome : pessoa2.Nome;
      // Console.WriteLine($"Pessoa mais velha: {pessoaMaisVelha}");

      // ==================================================
      // Exercício 2:
      // ==================================================

      // Funcionario funcionario1, funcionario2;
      // double salarioMedio;

      // funcionario1 = new Funcionario();
      // funcionario2 = new Funcionario();

      // Console.WriteLine("Dados do primeiro funcionário: ");
      // Console.Write("Nome: ");
      // funcionario1.Nome = Console.ReadLine();
      // Console.Write("Salário: ");
      // funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      // Console.WriteLine("Dados do segundo funcionário: ");
      // Console.Write("Nome: ");
      // funcionario2.Nome = Console.ReadLine();
      // Console.Write("Salário: ");
      // funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      // salarioMedio = (funcionario1.Salario + funcionario2.Salario) / 2;
      // Console.WriteLine("Salário médio = " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));

      // ==================================================
      // Exercício aula 45, 1:
      // ==================================================

      //   Retangulo ret = new Retangulo();

      //   Console.WriteLine("Entre a largura e altura do retângulo:");
      //   ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      //   ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      //   Console.WriteLine("ÁREA = " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
      //   Console.WriteLine("PERÍMETRO = " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
      //   Console.WriteLine("DIAGONAL = " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

      // ==================================================
      // Exercício aula 45, 2:
      // ==================================================

      // Funcionario funcionario = new Funcionario();
      // double porcentagem;

      // Console.Write("Nome: ");
      // funcionario.Nome = Console.ReadLine();
      // Console.Write("Salário bruto: ");
      // funcionario.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      // Console.Write("Imposto: ");
      // funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      // Console.WriteLine();

      // Console.WriteLine($"Funcionário: {funcionario}");
      // Console.WriteLine();

      // Console.Write("Digite a porcentagem para aumentar o salário: ");
      // porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      // funcionario.AumentarSalario(porcentagem);
      // Console.WriteLine();

      // Console.WriteLine($"Dados atualizados: {funcionario}");

      // ==================================================
      // Exercício aula 45, 3:
      // ==================================================

      // Aluno aluno = new Aluno();

      // Console.Write("Nome do aluno: ");
      // aluno.Nome = Console.ReadLine();

      // Console.WriteLine("Digite as três notas do aluno:");
      // aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      // aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      // aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      // Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

      // if (aluno.Aprovado())
      // {
      //   Console.WriteLine("APROVADO");
      // }
      // else
      // {
      //   Console.WriteLine("REPROVADO");
      //   Console.WriteLine("FALTARAM " + aluno.PontosFaltantes().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
      // }

      // ==================================================
      // Exercício aula 48:
      // ==================================================

      // double cotacao, dolares, reais;

      // Console.Write("Qual é a cotação do dolar? ");
      // cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      // Console.Write("Quantos dólares você vai comprar? ");
      // dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      // reais = ConversorDeMoeda.DolarParaReal(cotacao, dolares);
      // Console.WriteLine("Valor a ser pago em reais = " + reais.ToString("F2", CultureInfo.InvariantCulture));

      // ==================================================
      // Exercício aula 60:
      // ==================================================

      // Conta conta;
      // int numero;
      // string titular;
      // char temDepositoInicial;
      // double valor;

      // Console.Write("Entre o número da conta: ");
      // numero = int.Parse(Console.ReadLine());
      // Console.Write("Entre o titular da conta: ");
      // titular = Console.ReadLine();
      // Console.Write("Haverá depósito inicial (s/n)? ");
      // temDepositoInicial = char.Parse(Console.ReadLine());

      // if (temDepositoInicial == 's')
      // {
      //   Console.Write("Entre o valor de depósito inicial: ");
      //   valor = double.Parse(Console.ReadLine());
      //   conta = new Conta(numero, titular, valor);
      // }
      // else
      // {
      //   conta = new Conta(numero, titular);
      // }

      // Console.WriteLine();
      // Console.WriteLine("Dados da conta:");
      // Console.WriteLine(conta);
      // Console.WriteLine();

      // Console.Write("Entre um valor para depósito: ");
      // valor = double.Parse(Console.ReadLine());
      // conta.Deposito(valor);
      // Console.WriteLine("Dados da conta atualizados:");
      // Console.WriteLine(conta);
      // Console.WriteLine();

      // Console.Write("Entre um valor para saque: ");
      // valor = double.Parse(Console.ReadLine());
      // conta.Saque(valor);
      // Console.WriteLine("Dados da conta atualizados:");
      // Console.WriteLine(conta);

      // ==================================================
      // Exercício aula 71:
      // ==================================================

      // Student[] hostel = new Student[10];

      // Console.Write("How many rooms will be rented? ");
      // int rents = int.Parse(Console.ReadLine());

      // for (int rent = 1; rent <= rents; rent++)
      // {
      //   Console.WriteLine();
      //   Console.WriteLine($"Rent #{rent}:");
      //   Console.Write("Name: ");
      //   string name = Console.ReadLine();
      //   Console.Write("Email: ");
      //   string email = Console.ReadLine();
      //   Console.Write("Room: ");
      //   int room = int.Parse(Console.ReadLine());
      //   hostel[room] = new Student(name, email);
      // }

      // Console.WriteLine();
      // Console.WriteLine("Busy rooms:");
      // for (int room = 0; room < hostel.Length; room++)
      // {
      //   if (hostel[room] != null)
      //   {
      //     Console.WriteLine($"{room}: {hostel[room]}");
      //   }
      // }

      // ==================================================
      // Exercício aula 78:
      // ==================================================

      // List<Employee> employees = new List<Employee>();

      // Console.Write("How many employees will be registered? ");
      // int n = int.Parse(Console.ReadLine());

      // for (int i = 1; i <= n; i++)
      // {
      //   Console.WriteLine($"Employee #{i}:");
      //   Console.Write("Id: ");
      //   int id = int.Parse(Console.ReadLine());
      //   Console.Write("Name: ");
      //   string name = Console.ReadLine();
      //   Console.Write("Salary: ");
      //   double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      //   employees.Add(new Employee(id, name, salary));
      //   Console.WriteLine();
      // }

      // Console.Write("Enter the employee id that will have salary increase: ");
      // int salaryIncreaseId = int.Parse(Console.ReadLine());
      // Employee employee = employees.Find(employee => employee.Id == salaryIncreaseId);
      // if (employee == null)
      // {
      //   Console.WriteLine("This id does not exist!");
      // }
      // else
      // {
      //   Console.Write("Enter the percentage: ");
      //   double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      //   employee.IncreaseSalary(percentage);
      // }
      // Console.WriteLine();

      // Console.WriteLine("Updated list of employees:");
      // foreach (Employee obj in employees)
      // {
      //   Console.WriteLine(obj);
      // }

      // ==================================================
      // Exercício aula 81:
      // ==================================================

      string[] dimension = Console.ReadLine().Split(' ');
      int rows = int.Parse(dimension[0]);
      int cols = int.Parse(dimension[1]);
      int[,] array = new int[rows, cols];

      for (int n = 0; n < rows; n++)
      {
        string[] row = Console.ReadLine().Split(' ');
        for (int m = 0; m < cols; m++)
        {
          array[n, m] = int.Parse(row[m]);
        }
      }

      int x = int.Parse(Console.ReadLine());

      for (int n = 0; n < rows; n++)
      {
        for (int m = 0; m < cols; m++)
        {
          if (x == array[n, m])
          {
            Console.WriteLine();
            Console.WriteLine($"Position {n},{m}:");
            if (m > 0)
            {
              Console.WriteLine($"Left: {array[n, m - 1]}");
            }
            if (n > 0)
            {
              Console.WriteLine($"Up: {array[n - 1, m]}");
            }
            if (m < cols - 1)
            {
              Console.WriteLine($"Right: {array[n, m + 1]}");
            }
            if (n < rows - 1)
            {
              Console.WriteLine($"Down: {array[n + 1, m]}");
            }
          }
        }
      }
    }
  }
}
