using System;
using System.Text.Json.Serialization;

namespace Curso_RestWithASP_NET5.Data.VO
{
    public class PersonVO
    {
        [JsonPropertyName("Codigo")]
        public long Id { get; set; }

        [JsonPropertyName("NomeCompleto")]
        public string FullName { get; set; }

        [JsonIgnore]
        public string Address { get; set; }

        [JsonPropertyName("Sexo")]
        public string Gender { get; set; }
    }
}
