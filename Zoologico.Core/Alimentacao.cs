/*
*	<copyright file="Alimentacao.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* <author>diogo</author>
* <date>11/11/2025</date>
*	<description>Classe para a tarefa de Alimentação de um animal.</description>
**/

using System;

namespace Zoologico.Core
{
    /// <summary>
    /// Representa uma tarefa de alimentação (keyword: "alimentacao", "tipos de comida").
    /// Demonstra HERANÇA, herdando de <see cref="Tarefa"/>.
    /// </summary>
    public class Alimentacao : Tarefa
    {
        #region Propriedades

        /// <summary>
        /// Obtém ou define o identificador do animal a ser alimentado.
        /// </summary>
        public string IdAnimal { get; set; }

        /// <summary>
        /// Obtém ou define o tipo de comida a ser dada ao animal.
        /// </summary>
        public string TipoComida { get; set; }

        #endregion Propriedades

        #region Construtores

        /// <summary>
        /// Cria uma nova instância da tarefa de Alimentação.
        /// </summary>
        /// <param name="dataHora">A data e hora da alimentação.</param>
        /// <param name="idAnimal">O nome ou ID do animal.</param>
        /// <param name="tipoComida">O tipo de comida a fornecer.</param>
        public Alimentacao(DateTime dataHora, string idAnimal, string tipoComida)
            : base(dataHora) // Chama o construtor da classe base (Tarefa)
        {
            this.IdAnimal = idAnimal;
            this.TipoComida = tipoComida;
        }

        #endregion Construtores

        #region Métodos Sobrescritos (Polimorfismo)

        /// <summary>
        /// Executa a tarefa de alimentação.
        /// Sobrescreve o método base <see cref="Tarefa.Executar"/>.
        /// </summary>
        public override void Executar()
        {
            base.Executar(); // Executa a lógica da classe base (marca como concluída)
            Console.WriteLine($"EXECUTADO: Alimentar o animal {IdAnimal} com {TipoComida}.");
        }

        #endregion Métodos Sobrescritos (Polimorfismo)
    }
}