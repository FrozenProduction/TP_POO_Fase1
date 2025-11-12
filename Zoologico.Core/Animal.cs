/*
*	<copyright file="Animal.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* <author>diogo</author>
* <date>11/11/2025</date>
*	<description>Classe abstrata base para todos os animais do zoológico.</description>
**/

using System;

namespace Zoologico.Core
{
    /// <summary>
    /// Classe abstrata que serve como base para todos os animais.
    /// Define as propriedades e comportamentos comuns que um animal deve ter.
    /// Demonstra o pilar da ABSTRAÇÃO.
    /// </summary>
    public abstract class Animal
    {
        #region Atributos Privados

        /// <summary>
        /// O nome privado do animal.
        /// </summary>
        private string nome;

        /// <summary>
        /// A data de nascimento privada do animal.
        /// </summary>
        private DateTime dataNascimento;

        /// <summary>
        /// O identificador privado da jaula onde o animal se encontra.
        /// </summary>
        private string idJaula;

        #endregion Atributos Privados

        #region Propriedades (Encapsulamento)

        /// <summary>
        /// Obtém ou define o nome do animal.
        /// Demonstra o pilar do ENCAPSULAMENTO.
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Obtém a idade do animal, calculada com base na data de nascimento.
        /// Esta é uma propriedade "read-only".
        /// </summary>
        public int Idade
        {
            get
            {
                // Calcula a idade com base no ano atual
                return DateTime.Today.Year - dataNascimento.Year;
            }
        }

        /// <summary>
        /// Obtém ou define o ID da jaula associada a este animal.
        /// </summary>
        public string IdJaula
        {
            get { return idJaula; }
            set { idJaula = value; }
        }

        #endregion Propriedades (Encapsulamento)

        #region Construtores

        /// <summary>
        /// Construtor da classe Animal.
        /// </summary>
        /// <param name="nome">O nome do animal.</param>
        /// <param name="dataNascimento">A data de nascimento do animal.</param>
        public Animal(string nome, DateTime dataNascimento)
        {
            this.nome = nome;
            this.dataNascimento = dataNascimento;
        }

        #endregion Construtores

        #region Métodos Abstratos (Polimorfismo)

        /// <summary>
        /// Método abstrato que, quando implementado, deve retornar
        /// uma string com as informações específicas do animal.
        /// Demonstra o pilar do POLIMORFISMO.
        /// </summary>
        /// <returns>Uma string formatada com os detalhes do animal.</returns>
        public abstract string GetInformacao();

        /// <summary>
        /// Método abstrato que, quando implementado, deve retornar
        /// o tipo de comida principal do animal.
        /// </summary>
        /// <returns>Uma string que descreve a dieta.</returns>
        public abstract string GetTipoComida();

        #endregion Métodos Abstratos (Polimorfismo)
    }
}