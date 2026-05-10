using System.Text.Json.Serialization;

namespace Infrastructure.ExternalServices.Inegi.Dtos;
public class InegiRestaurantDto
{
    [JsonPropertyName("CLEE")]
    public string? Clee { get; set; }

    [JsonPropertyName("Id")]
    public string? Id { get; set; }

    [JsonPropertyName("Nombre")]
    public string? Nombre { get; set; }

    [JsonPropertyName("Razon_social")]
    public string? RazonSocial { get; set; }

    [JsonPropertyName("Clase_actividad")]
    public string? ClaseActividad { get; set; }

    [JsonPropertyName("Estrato")]
    public string? Estrato { get; set; }

    [JsonPropertyName("Tipo_vialidad")]
    public string? TipoVialidad { get; set; }

    [JsonPropertyName("Calle")]
    public string? Calle { get; set; }

    [JsonPropertyName("Num_Exterior")]
    public string? NumExterior { get; set; }

    [JsonPropertyName("Num_Interior")]
    public string? NumInterior { get; set; }

    [JsonPropertyName("Colonia")]
    public string? Colonia { get; set; }

    [JsonPropertyName("CP")]
    public string? Cp { get; set; }

    [JsonPropertyName("Ubicacion")]
    public string? Ubicacion { get; set; }

    [JsonPropertyName("Telefono")]
    public string? Telefono { get; set; }

    [JsonPropertyName("Correo_e")]
    public string? CorreoE { get; set; }

    [JsonPropertyName("Sitio_internet")]
    public string? SitioInternet { get; set; }

    [JsonPropertyName("Tipo")]
    public string? Tipo { get; set; }

    [JsonPropertyName("Longitud")]
    public string? Longitud { get; set; }

    [JsonPropertyName("Latitud")]
    public string?Latitud { get; set; }

    [JsonPropertyName("CentroComercial")]
    public string? CentroComercial { get; set; }

    [JsonPropertyName("TipoCentroComercial")]
    public string? TipoCentroComercial { get; set; }

    [JsonPropertyName("NumLocal")]
    public string? NumLocal { get; set; }
}
