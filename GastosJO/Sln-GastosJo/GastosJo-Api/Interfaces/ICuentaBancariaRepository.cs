﻿using GastosJo_Api.Models.Helpers;
using GastosJo_Api.Models;
using GastosJo_Api.Models.Dto;

namespace GastosJo_Api.Interfaces
{
    public interface ICuentaBancariaRepository
    {
        Task<List<CuentaBancariaResponse>?> GetCuentasBancaria(Paginado paginado, int elementosParaOmitir, bool[] estados);

        Task<CuentaBancariaResponse?> GetCuentaBancaria(int id, bool[] estados);

        Task<CuentaBancaria> AddCuentaBancaria(CuentaBancaria CuentaBancariaNuevo);

        Task<CuentaBancaria> UpdateCuentaBancaria(CuentaBancaria CuentaBancariaActual, CuentaBancaria CuentaBancariaModificado);

        Task DeleteCuentaBancaria(CuentaBancaria CuentaBancariaActual);

        Task<List<CuentaBancaria>> ListarCuentasBancariaPorCodigoNombre(int id, string codigo, string nombre);
    }
}