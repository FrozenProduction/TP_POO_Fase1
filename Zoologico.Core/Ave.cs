/*
*	<copyright file="Ave.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* <author>diogo</author>
* <date>11/11/2025</date>
*	<description>Classe que representa uma Ave, herdando de Animal.</description>
**/

using System;

namespace Zoologico.Core
{
    /// <summary>
    /// Representa um animal do tipo Ave.
    /// Demonstra o pilar da HERANÇA, herdando de <see cref="Animal"/>.
    /// </summary>
    public class Ave : Animal
    {
        #region Atributos Privados

        /// <summary>
        /// Indica se a ave pode voar.
        /// </summary>
        private bool voa;

        #endregion Atributos Privados

        #region Construtores

        /// <summary>
        /// Cria uma nova instância de uma Ave.
        /// </summary>
        /// <param name="nome">O nome da ave.</param>
        /// <param name="dataNascimento">A data de nascimento da ave.</param>
        /// <param name="voa">True se a ave voa, False caso contrário.</param>
        public Ave(string nome, DateTime dataNascimento, bool voa)
            : base(nome, dataNascimento) // Chama o construtor da classe base (Animal)
        {
            this.voa = voa;
        }

        #endregion Construtores

        #region Métodos Sobrescritos (Polimorfismo)

        /// <summary>
        /// Retorna as informações específicas da ave,
        /// implementando o método abstrato de <see cref="Animal"/>.
        /// </summary>
        /// <returns>String formatada com os detalhes da ave.</returns>
        public override string GetInformacao()
        {
            string infoVoo = voa ? "Voa" : "Não voa";
            return $"Ave: {Nome}, Idade: {Idade}, Info: {infoVoo}.";
        }

        /// <summary>
        /// Retorna o tipo de comida da ave,
        /// implementando o método abstrato de <see cref="Animal"/>.
        /// </summary>
        /// <returns>A dieta da ave.</returns>
        public override string GetTipoComida()
        {
            return "Sementes ou Insetos"; // Simplificado
        }

        #endregion Métodos Sobrescritos (Polimorfismo)
    }
}