﻿namespace EstudoRepositories.Models.DTOs
{
    public class MultadosDTO
    {
        public long Id { get; set; }
        public long VeiculoId { get; set; }
        public string NomeCompleto { get; set; }
        public string CPF { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
    }
}