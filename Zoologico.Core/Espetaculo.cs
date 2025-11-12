/*
*	<copyright file="Espetaculo.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* <author>diogo</author>
* <date>11/11/2025</date>
*	<description>Classe para a tarefa de um Espetáculo.</description>
**/

using System;

namespace Zoologico.Core
{
    /// <summary>
    /// Representa uma tarefa do tipo Espetáculo (keyword: "espetaculos").
    /// Demonstra HERANÇA, herdando de <see cref="Tarefa"/>.
    /// </summary>
    public class Espetaculo : Tarefa
    {
        #region Propriedades

        /// <summary>
        /// Obtém ou define o nome oficial do espetáculo.
        /// </summary>
        public string NomeEspetaculo { get; set; }

        /// <summary>
        /// Obtém ou define a duração do espetáculo em minutos.
        /// </summary>
        public int DuracaoMinutos { get; set; }

        #endregion Propriedades

        #region Construtores

        /// <summary>
        /// Cria uma nova instância da tarefa Espetáculo.
        /// </summary>
        /// <param name="dataHora">A data e hora de início do espetáculo.</param>
        /// <param name="nome">O nome do espetáculo.</param>
        /// <param name="duracao">A duração em minutos.</param>
        public Espetaculo(DateTime dataHora, string nome, int duracao)
            : base(dataHora) // Chama o construtor da classe base (Tarefa)
        {
            this.NomeEspetaculo = nome;
            this.DuracaoMinutos = duracao;
        }

        #endregion Construtores

        #region Métodos Sobrescritos (Polimorfismo)

        /// <summary>
        /// Executa a tarefa do espetáculo.
        /// Sobrescreve o método base <see cref="Tarefa.Executar"/>.
        /// </summary>
        public override void Executar()
        {
            base.Executar(); // Executa a lógica da classe base (marca como concluída)
            Console.WriteLine($"EXECUTADO: Início do espetáculo '{NomeEspetaculo}' com duração de {DuracaoMinutos} min.");
        }

        #endregion Métodos Sobrescritos (Polimorfismo)
    }
}