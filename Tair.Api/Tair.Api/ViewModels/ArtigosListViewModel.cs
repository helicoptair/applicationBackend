﻿using System;
using System.Text.Json.Serialization;
using Tair.Domain.Enums;

namespace Tair.Api.ViewModels
{
    public class ArtigosListViewModel
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("titulo")]
        public string Titulo { get; set; }

        [JsonPropertyName("resumo")]
        public string Resumo { get; set; }

        [JsonPropertyName("escrito_por")]
        public string EscritoPor { get; set; }

        [JsonPropertyName("html")]
        public string Html { get; set; }

        [JsonPropertyName("foto_capa")]
        public string FotoCapa { get; set; }

        [JsonPropertyName("url_artigo")]
        public string UrlArtigo { get; set; }
    }
}
