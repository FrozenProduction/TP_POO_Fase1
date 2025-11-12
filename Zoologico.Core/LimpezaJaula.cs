/*
*	<copyright file="LimpezaJaula.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* <author>diogo</author>
* <date>11/11/2025</date>
*	<description>Classe para a tarefa de Limpeza de uma jaula.</description>
**/

using System;

namespace Zoologico.Core
{
    /// <summary>
    /// Representa uma tarefa de limpeza de jaula (keyword: "limpeza de jaulas").
    /// Demonstra HERANÇA, herdando de <see cref="Tarefa"/>.
    /// </summary>
    public class LimpezaJaula : Tarefa
    {
        #region Propriedades

        /// <summary>
        /// Obtém ou define o identificador da jaula a ser limpa.
        /// </summary>
        public string IdJaula { get; set; }

        #endregion Propriedades

        #region Construtores

        /// <summary>
        /// Cria uma nova instância da tarefa de Limpeza de Jaula.
        /// </summary>
        /// <param name="dataHora">A data e hora da limpeza.</param>
        /// <param name="idJaula">O nome ou ID da jaula.</param>
        public LimpezaJaula(DateTime dataHora, string idJaula)
            : base(dataHora) // Chama o construtor da classe base (Tarefa)
        {
            this.IdJaula = idJaula;
        }

        #endregion Construtores

        #region Métodos Sobrescritos (Polimorfismo)

        /// <summary>
        /// Executa a tarefa de limpeza da jaula.
        /// Sobrescreve o método base <see cref="Tarefa.Executar"/>.
        /// </summary>
        public override void Executar()
        {
            base.Executar(); // Executa a lógica da classe base (marca como concluída)
            Console.WriteLine($"EXECUTADO: Limpeza da jaula {IdJaula}.");
        }

        #endregion Métodos Sobrescritos (Polimorfismo)
    }
}