using BusinessLayer.Entities;
using BusinessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    /// <summary>
    /// Essa classe tem os métodos necessários para as operações no repositório de dados
    /// </summary>
    public class StationRepository : IStationRepository
    {
        /// <summary>
        /// Método que retorna o possível próximo caractere de uma string input dada pelo usuário
        /// </summary>
        /// <param name="reference">É a referência de uma possível estação</param>  
        /// <param name="input">Input do usuário na máquina</param>  
        public char GetNextCharacter(string reference, string input)
        {
            try
            {
                return reference.Replace(input, String.Empty).ToCharArray().ToList()[0];
            }

            catch
            {
                return (char)0;
            }
        }

        /// <summary>
        /// Retorna todas as estações começadas com um certo nome e ainda retorna os possíveis próximos caracteres
        /// </summary>
        /// <param name="input">Input do usuário na máquina</param>  
        public List<SearchStationResult> GetAllStartedWithName(string input)
        {
            try
            {
                string[] arraystations = GetAllStations();
                List<SearchStationResult> searchResultList = new List<SearchStationResult>();

                //para fazer a busca usei arrays e o 'for' que são mais rápidos em runtime do que List e Foreach
                for (int i = 0; i < StationsArray.stations.Length; i++)
                {
                    if (arraystations[i].StartsWith(input))
                    {
                        searchResultList.Add(new SearchStationResult
                        {
                            station = arraystations[i],
                            nextCharacter = GetNextCharacter(arraystations[i], input)
                        });
                    }
                }

                return searchResultList;
            }

            catch
            {
                return Enumerable.Empty<SearchStationResult>().ToList();
            }
        }

        /// <summary>
        /// Retorna o array de estações
        /// </summary>
        public string[] GetAllStations()
        {
            return StationsArray.stations;
        }
    }
}