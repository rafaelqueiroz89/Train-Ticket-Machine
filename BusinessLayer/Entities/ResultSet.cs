using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.Entities
{
    /// <summary>
    /// Nessa classe temos os resultados da busca em um objeto
    /// </summary>
    public class ResultSet
    {
        /// <summary>
        /// Lista de estações que o usuário recebe depois de digitar o input
        /// </summary>
        public List<string> stations { get; set; }

        /// <summary>
        /// Lista de todos os possíveis inputs de caracteres que o usuário pode ter depois do primeiro input
        /// </summary>
        public List<char> allNextCharacters { get; set; }

        /// <summary>
        /// Construtor da classe ResultSet, ele trata a lista de resultados da busca
        /// </summary>
        public ResultSet(List<SearchStationResult> searchResults)
        {
            stations = new List<string>();
            allNextCharacters = new List<char>();

            foreach (SearchStationResult s in searchResults)
            {
                stations.Add(s.station);
                allNextCharacters.Add(s.nextCharacter);
            }

            allNextCharacters.Remove(allNextCharacters.Where(c => c == (char)0).FirstOrDefault());
        }
    }
}
