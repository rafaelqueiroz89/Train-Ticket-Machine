using BusinessLayer.Entities;
using System.Collections.Generic;

namespace BusinessLayer
{
    /// <summary>
    /// Interface que determina os métodos que serão usados contra o banco de dados
    /// </summary>
    interface IStationRepository
    {
        /// <summary>
        /// Retorna todas as estações do banco de dados
        /// </summary>
        string[] GetAllStations();

        /// <summary>
        /// Retorna uma estação pelo  nome
        /// </summary>
        List<SearchStationResult> GetAllStartedWithName(string input);

        /// <summary>
        /// Retorna o próximo possível caractere com base no input do usuário
        /// </summary>
        char GetNextCharacter(string reference, string input);
    }
}
