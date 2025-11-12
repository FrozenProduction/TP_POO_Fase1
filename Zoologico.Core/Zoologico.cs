/*
*	<copyright file="Zoologico.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* <author>diogo</author>
* <date>11/11/2025</date>
*	<description>Classe principal de gestão do zoológico. Gere animais e tarefas.</description>
**/

using System;
using System.Collections.Generic;

namespace Zoologico.Core
{
    /// <summary>
    /// Classe central que gere o Jardim Zoológico.
    /// Contém as estruturas de dados para animais e tarefas (keyword: "calendarios").
    /// </summary>
    public class Zoologico
    {
        #region Atributos Privados

        /// <summary>
        /// Estrutura de dados (Lista) que armazena todos os animais do zoo.
        /// </summary>
        private List<Animal> animais;

        /// <summary>
        /// Estrutura de dados (Lista) que funciona como o calendário de tarefas.
        /// </summary>
        private List<Tarefa> calendario;

        /// <summary>
        /// Atributo estático (de classe) para contar bilhetes (keyword: "bilhetes").
        /// Sendo 'static', o valor é partilhado por todas as instâncias de Zoologico.
        /// </summary>
        private static int totalBilhetesVendidos = 0;

        #endregion Atributos Privados

        #region Propriedades

        /// <summary>
        /// Obtém ou define o nome do zoológico.
        /// </summary>
        public string Nome { get; set; }

        #endregion Propriedades

        #region Construtores

        /// <summary>
        /// Cria uma nova instância de um Zoologico.
        /// Inicializa as listas (estruturas de dados).
        /// </summary>
        /// <param name="nome">O nome do zoológico.</param>
        public Zoologico(string nome)
        {
            this.Nome = nome;
            this.animais = new List<Animal>();
            this.calendario = new List<Tarefa>();
        }

        #endregion Construtores

        #region Métodos de Instância

        /// <summary>
        /// Adiciona um novo animal à lista de animais do zoo.
        /// </summary>
        /// <param name="a">O objeto <see cref="Animal"/> a adicionar.</param>
        /// <returns>True se o animal foi adicionado com sucesso.</returns>
        public bool AdicionarAnimal(Animal a)
        {
            // Futuramente: adicionar validação para não inserir animais duplicados
            animais.Add(a);
            return true;
        }

        /// <summary>
        /// Agenda uma nova tarefa no calendário do zoo.
        /// </summary>
        /// <param name="t">O objeto <see cref="Tarefa"/> a agendar.</param>
        /// <returns>True se a tarefa foi agendada com sucesso.</returns>
        public bool AgendarTarefa(Tarefa t)
        {
            calendario.Add(t);
            return true;
        }

        /// <summary>
        /// Itera sobre o calendário e executa todas as tarefas pendentes.
        /// Este método é a principal demonstração de POLIMORFISMO:
        /// Ele trata todos os objetos (Alimentacao, LimpezaJaula, etc.)
        /// da mesma forma, como uma <see cref="Tarefa"/> genérica.
        /// </summary>
        public void ExecutarTarefasPendentes()
        {
            Console.WriteLine($"--- Executando Tarefas do Zoo: {Nome} ---");

            foreach (Tarefa t in calendario)
            {
                if (!t.Concluida)
                {
                    // Polimorfismo em ação:
                    // O C# sabe qual método 'Executar()' específico chamar
                    // (seja de Alimentacao, LimpezaJaula, etc.)
                    t.Executar();
                }
            }
        }

        #endregion Métodos de Instância

        #region Métodos Estáticos (de Classe)

        /// <summary>
        /// Incrementa o contador global de bilhetes vendidos.
        /// Demonstra um Método de Classe (static).
        /// </summary>
        public static void VenderBilhete()
        {
            totalBilhetesVendidos++;
        }

        /// <summary>
        /// Obtém o número total de bilhetes vendidos.
        /// Demonstra um Método de Classe (static).
        /// </summary>
        /// <returns>O número total de bilhetes vendidos.</returns>
        public static int GetTotalBilhetesVendidos()
        {
            return totalBilhetesVendidos;
        }

        #endregion Métodos Estáticos (de Classe)
    }
}