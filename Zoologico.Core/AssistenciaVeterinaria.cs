/*
*	<copyright file="AssistenciaVeterinaria.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* <author>diogo</author>
* <date>11/11/2025</date>
*	<description>Classe para a tarefa de Assistência Veterinária.</description>
**/

using System;

namespace Zoologico.Core
{
    /// <summary>
    /// Representa uma tarefa de assistência veterinária (keyword: "assistencia veterinaria").
    /// Demonstra HERANÇA, herdando de <see cref="Tarefa"/>.
    /// </summary>
    public class AssistenciaVeterinaria : Tarefa
    {
        #region Propriedades

        /// <summary>
        /// Obtém ou define o identificador do animal que recebe assistência.
        /// </summary>
        public string IdAnimal { get; set; }

        /// <summary>
        /// Obtém ou define o motivo da consulta veterinária.
        /// </summary>
        public string Motivo { get; set; }

        #endregion Propriedades

        #region Construtores

        /// <summary>
        /// Cria uma nova instância da tarefa de Assistência Veterinária.
        /// </summary>
        /// <param name="dataHora">A data e hora da assistência.</param>
        /// <param name="idAnimal">O nome ou ID do animal.</param>
        /// <param name="motivo">A razão para a assistência.</param>
        public AssistenciaVeterinaria(DateTime dataHora, string idAnimal, string motivo)
            : base(dataHora) // Chama o construtor da classe base (Tarefa)
        {
            this.IdAnimal = idAnimal;
            this.Motivo = motivo;
        }

        #endregion Construtores

        #region Métodos Sobrescritos (Polimorfismo)

        /// <summary>
        /// Executa a tarefa de assistência veterinária.
        /// Sobrescreve o método base <see cref="Tarefa.Executar"/>.
        /// </summary>
        public override void Executar()
        {
            base.Executar(); // Executa a lógica da classe base (marca como concluída)
            Console.WriteLine($"EXECUTADO: Assistência vet. ao animal {IdAnimal}. Motivo: {Motivo}.");
        }

        #endregion Métodos Sobrescritos (Polimorfismo)
    }
}