/*
*	<copyright file="Mamifero.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* <author>diogo</author>
* <date>11/11/2025</date>
*	<description>Classe que representa um Mamífero, herdando de Animal.</description>
**/

using System;

namespace Zoologico.Core
{
    /// <summary>
    /// Representa um animal do tipo Mamífero.
    /// Demonstra o pilar da HERANÇA, herdando de <see cref="Animal"/>.
    /// </summary>
    public class Mamifero : Animal
    {
        #region Atributos Privados

        /// <summary>
        /// Tempo de gestação do mamífero, em dias.
        /// </summary>
        private int tempoGestacao;

        #endregion Atributos Privados

        #region Construtores

        /// <summary>
        /// Cria uma nova instância de um Mamífero.
        /// </summary>
        /// <param name="nome">O nome do mamífero.</param>
        /// <param name="dataNascimento">A data de nascimento do mamífero.</param>
        /// <param name="tempoGestacao">O tempo de gestação em dias.</param>
        public Mamifero(string nome, DateTime dataNascimento, int tempoGestacao)
            : base(nome, dataNascimento) // Chama o construtor da classe base (Animal)
        {
            this.tempoGestacao = tempoGestacao;
        }

        #endregion Construtores

        #region Métodos Sobrescritos (Polimorfismo)

        /// <summary>
        /// Retorna as informações específicas do mamífero,
        /// implementando o método abstrato de <see cref="Animal"/>.
        /// </summary>
        /// <returns>String formatada com os detalhes do mamífero.</returns>
        public override string GetInformacao()
        {
            return $"Mamífero: {Nome}, Idade: {Idade}, Gestação: {tempoGestacao} dias.";
        }

        /// <summary>
        /// Retorna o tipo de comida do mamífero,
        /// implementando o método abstrato de <see cref="Animal"/>.
        /// </summary>
        /// <returns>A dieta do mamífero.</returns>
        public override string GetTipoComida()
        {
            return "Carne ou Herbívoros";
        }

        #endregion Métodos Sobrescritos (Polimorfismo)
    }
}