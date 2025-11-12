/*
*	<copyright file="Tarefa.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* <author>diogo</author>
* <date>11/11/2025</date>
*	<description>Classe abstrata base para todas as tarefas agendáveis no zoológico.</description>
**/

using System;

namespace Zoologico.Core
{
    /// <summary>
    /// Classe abstrata que serve como base para todas as tarefas do zoológico.
    /// Define propriedades e comportamentos comuns a qualquer tarefa.
    /// Demonstra o pilar da ABSTRAÇÃO.
    /// </summary>
    public abstract class Tarefa
    {
        #region Atributos Privados

        /// <summary>
        /// A data e hora para a qual a tarefa está agendada.
        /// </summary>
        private DateTime dataHoraAgendada;

        /// <summary>
        /// O estado de conclusão da tarefa.
        /// </summary>
        private bool concluida;

        #endregion Atributos Privados

        #region Propriedades (Encapsulamento)

        /// <summary>
        /// Obtém ou define a data e hora agendada para a tarefa.
        /// </summary>
        public DateTime DataHoraAgendada
        {
            get { return dataHoraAgendada; }
            set { dataHoraAgendada = value; }
        }

        /// <summary>
        /// Obtém um valor que indica se a tarefa foi concluída.
        /// Esta é uma propriedade "read-only" (apenas get).
        /// </summary>
        public bool Concluida
        { get { return concluida; } }

        #endregion Propriedades (Encapsulamento)

        #region Construtores

        /// <summary>
        /// Construtor da classe Tarefa.
        /// </summary>
        /// <param name="dataHora">A data e hora em que a tarefa deve ser executada.</param>
        public Tarefa(DateTime dataHora)
        {
            this.dataHoraAgendada = dataHora;
            this.concluida = false; // Todas as tarefas começam como não concluídas
        }

        #endregion Construtores

        #region Métodos Virtuais (Polimorfismo)

        /// <summary>
        /// Executa a tarefa. Marca a tarefa como concluída e imprime uma mensagem base.
        /// Este método é 'virtual', permitindo que classes filhas o reescrevam (override).
        /// Demonstra o pilar do POLIMORFISMO.
        /// </summary>
        public virtual void Executar()
        {
            this.concluida = true;
            Console.WriteLine($"A tarefa genérica agendada para {dataHoraAgendada} foi executada.");
        }

        #endregion Métodos Virtuais (Polimorfismo)
    }
}