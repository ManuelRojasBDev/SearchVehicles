
/*
 * File: ErrorSearchVehicle.cs
 * Creatio Date: March 08, 2023
 * Created By: Ing. Manuel Rojas | marojas@pichincha.com
 *
 * Copyright (c) 2024 Browser Travel Solutions
 */

namespace SearchVehicles.Domain.DTO.SearchVehicles.Output
{
    public class ErrorSearchVehicle
    {
        public string ErrorMessage { get; set; } = string.Empty;
        public string ErrorCode { get; set; } = string.Empty;
        public string Resource { get; set; } = string.Empty;
    }
}
