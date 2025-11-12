/*
*	<copyright file="Program.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* <author>diogo</author>
* <date>11/11/2025</date>
*	<description>Aplicação de consola para demonstrar a biblioteca Zoologico.Core.</description>
**/

using System;
using Zoologico.Core; // Importa a biblioteca de classes (DLL)
using Zoo = Zoologico.Core.Zoologico; // "Apelido" para evitar conflito de nome

namespace Zoologico.App
{
    /// <summary>
    /// Classe principal da aplicação de consola.
    /// Serve como "Aplicação demonstradora" dos serviços da Fase 1.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Ponto de entrada (Main) da aplicação.
        /// </summary>
        /// <param name="args">Argumentos de linha de comandos (não utilizados).</param>
        private static void Main(string[] args)
        {
            Console.WriteLine("--- A configurar o Zoo ---");

            // 1. Criar o Zoo (usando o apelido 'Zoo')
            Zoo meuZoo = new Zoo("Zoo de Barcelos");

            // 2. Criar Animais (Demonstra Herança)
            Animal leao = new Mamifero("Simba", new DateTime(2020, 5, 1), 110);
            Animal aguia = new Ave("Asas", new DateTime(2022, 1, 10), true);

            meuZoo.AdicionarAnimal(leao);
            meuZoo.AdicionarAnimal(aguia);

            // 3. Agendar Tarefas (Demonstra Polimorfismo)
            Tarefa t1 = new Alimentacao(DateTime.Today.AddHours(10), leao.Nome, "Carne");
            Tarefa t2 = new LimpezaJaula(DateTime.Today.AddHours(11), "Jaula01");
            Tarefa t3 = new Alimentacao(DateTime.Today.AddHours(12), aguia.Nome, "Sementes");
            Tarefa t4 = new AssistenciaVeterinaria(DateTime.Today.AddHours(14), leao.Nome, "Check-up anual");
            Tarefa t5 = new Espetaculo(DateTime.Today.AddHours(15), "Show das Águias", 30);

            meuZoo.AgendarTarefa(t1);
            meuZoo.AgendarTarefa(t2);
            meuZoo.AgendarTarefa(t3);
            meuZoo.AgendarTarefa(t4);
            meuZoo.AgendarTarefa(t5);

            // 4. Executar todas as tarefas pendentes
            meuZoo.ExecutarTarefasPendentes();

            // 5. Mostrar Informações (Demonstra Abstração)
            Console.WriteLine("\n--- Informações dos Animais ---");
            Console.WriteLine(leao.GetInformacao());
            Console.WriteLine(aguia.GetInformacao());

            // 6. Testar Métodos Estáticos (de Classe)
            Console.WriteLine("\n--- Bilhetes ---");
            Zoo.VenderBilhete();
            Zoo.VenderBilhete();
            Console.WriteLine($"Total de bilhetes vendidos hoje: {Zoo.GetTotalBilhetesVendidos()}");

            Console.ReadKey();
        }
    }
}