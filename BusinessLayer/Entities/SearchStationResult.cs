namespace BusinessLayer.Entities
{
    /// <summary>
    /// Nessa classe temos os resultados da busca em um objeto
    /// </summary>
    public class SearchStationResult
    {
        /// <summary>
        /// Estação
        /// </summary>
        public string station { get; set; }

        /// <summary>
        /// Possível próximo caractere para o usuário digitar
        /// </summary>
        public char nextCharacter { get; set; }
    }
}
