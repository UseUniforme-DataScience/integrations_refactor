using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Application.Dtos.Klaviyo;

public class KlaviyoPropertiesDto
{
    [JsonPropertyName("id")]
    [MinLength(24)]
    [MaxLength(28)]
    public string? Id { get; set; }

    [JsonPropertyName("nome")]
    [MinLength(2)]
    [MaxLength(150)]
    public string? Nome { get; set; }

    [JsonPropertyName("first_name")]
    public string? FirstName { get; set; }

    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }

    [JsonPropertyName("phone_number")]
    public string? PhoneNumber { get; set; }

    [JsonPropertyName("cpf")]
    [MinLength(5)]
    [MaxLength(14)]
    public string? Cpf { get; set; }

    [JsonPropertyName("email")]
    [MinLength(5)]
    [MaxLength(255)]
    public string? Email { get; set; }

    [JsonPropertyName("whats_valido")]
    public bool? WhatsValido { get; set; }

    [JsonPropertyName("razao_social")]
    [MinLength(2)]
    [MaxLength(255)]
    public string? RazaoSocial { get; set; }

    [JsonPropertyName("blacklist")]
    public bool? Blacklist { get; set; }

    [JsonPropertyName("customer_id")]
    public string? CustomerId { get; set; }

    [JsonPropertyName("classificacao_geral")]
    [MinLength(1)]
    [MaxLength(1)]
    public string? ClassificacaoGeral { get; set; }

    [JsonPropertyName("tipo_cliente")]
    [MinLength(2)]
    [MaxLength(50)]
    public string? TipoCliente { get; set; }

    [JsonPropertyName("categoria")]
    [MinLength(2)]
    [MaxLength(50)]
    public string? Categoria { get; set; }

    [JsonPropertyName("qtd_compras")]
    [Range(0, int.MaxValue)]
    public int? QtdCompras { get; set; }

    [JsonPropertyName("tipo_kit_adquirido")]
    [MinLength(2)]
    [MaxLength(50)]
    public string? TipoKitAdquirido { get; set; }

    [JsonPropertyName("valor")]
    [Range(0, double.MaxValue)]
    public double? Valor { get; set; }

    [JsonPropertyName("classificacao_saldo_material")]
    public string? ClassificacaoSaldoMaterial { get; set; }

    [JsonPropertyName("classificacao_saldo_uniforme")]
    public string? ClassificacaoSaldoUniforme { get; set; }

    [JsonPropertyName("classificacao_saldo_total")]
    public string? ClassificacaoSaldoTotal { get; set; }

    [JsonPropertyName("tipo_saldo_material")]
    public string? TipoSaldoMaterial { get; set; }

    [JsonPropertyName("tipo_saldo_uniforme")]
    public string? TipoSaldoUniforme { get; set; }

    [JsonPropertyName("compra_2021")]
    public bool? Compra2021 { get; set; }

    [JsonPropertyName("compra_2022")]
    public bool? Compra2022 { get; set; }

    [JsonPropertyName("compra_2023")]
    public bool? Compra2023 { get; set; }

    [JsonPropertyName("compra_2024")]
    public bool? Compra2024 { get; set; }

    [JsonPropertyName("compra_2025")]
    public bool? Compra2025 { get; set; }

    [JsonPropertyName("compra_2026")]
    public bool? Compra2026 { get; set; }

    [JsonPropertyName("data_pesquisa")]
    [MinLength(10)]
    [MaxLength(50)]
    public string? DataPesquisa { get; set; }

    [JsonPropertyName("data_ultima_compra")]
    [MinLength(10)]
    [MaxLength(50)]
    public string? DataUltimaCompra { get; set; }

    [JsonPropertyName("beneficio_avaliado")]
    public string? BeneficioAvaliado { get; set; }

    [JsonPropertyName("saldo_restante")]
    public double? SaldoRestante { get; set; }

    [JsonPropertyName("aceita_receber_email")]
    public bool? AceitaReceberEmail { get; set; }

    [JsonPropertyName("aceita_receber_sms")]
    public bool? AceitaReceberSms { get; set; }

    [JsonPropertyName("checkout_url")]
    public string? CheckoutUrl { get; set; }

    [JsonPropertyName("line_items")]
    public string? LineItems { get; set; }

    [JsonPropertyName("cart_id")]
    public string? CartId { get; set; }

    [JsonPropertyName("valor_reserva")]
    public double? ValorReserva { get; set; }

    [JsonPropertyName("data_reserva")]
    public string? DataReserva { get; set; }

    [JsonPropertyName("last_active")]
    public string? LastActive { get; set; }

    [JsonPropertyName("last_open")]
    public string? LastOpen { get; set; }

    [JsonPropertyName("last_click")]
    public string? LastClick { get; set; }

    [JsonPropertyName("email_suppressions")]
    public string? EmailSuppressions { get; set; }

    [JsonPropertyName("email_list_suppressions_reasons")]
    public string? EmailListSuppressionsReasons { get; set; }

    [JsonPropertyName("bercario")]
    public int? Bercario { get; set; }

    [JsonPropertyName("mini_grupo")]
    public int? MiniGrupo { get; set; }

    [JsonPropertyName("infantil")]
    public int? Infantil { get; set; }

    [JsonPropertyName("alfabetizacao")]
    public int? Alfabetizacao { get; set; }

    [JsonPropertyName("interdiciplinar")]
    public int? Interdiciplinar { get; set; }

    [JsonPropertyName("autoral")]
    public int? Autoral { get; set; }

    [JsonPropertyName("med")]
    public int? Med { get; set; }

    [JsonPropertyName("eja_mova")]
    public int? EjaMova { get; set; }

    [JsonPropertyName("order_id")]
    public int? OrderId { get; set; }

    [JsonPropertyName("nfe_key")]
    public string? NfeKey { get; set; }

    [JsonPropertyName("nfe_number")]
    public int? NfeNumber { get; set; }

    [JsonPropertyName("nfe_serie")]
    public int? NfeSerie { get; set; }

    [JsonPropertyName("lake_origin_tracking_id")]
    public string? LakeOriginTrackingId { get; set; }

    [JsonPropertyName("ssot_id")]
    public string? SsotId { get; set; }

    [JsonPropertyName("tracking_code")]
    public string? TrackingCode { get; set; }

    [JsonPropertyName("name")]
    [MinLength(2)]
    [MaxLength(500)]
    public string? Name { get; set; }

    [JsonPropertyName("description")]
    [MaxLength(500)]
    public string? Description { get; set; }

    [JsonPropertyName("days_to_tracking_status")]
    [Range(0, int.MaxValue)]
    public int? DaysToTrackingStatus { get; set; }

    [JsonPropertyName("timestamp")]
    [MinLength(10)]
    [MaxLength(50)]
    public string? Timestamp { get; set; }
}
