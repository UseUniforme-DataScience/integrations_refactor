using System.Text.Json.Serialization;

namespace Application.Dtos.Pipedrive;

public class PipedriveDealCustomFieldsDto
{
    // Campos customizados do DEAL_CUSTOM_FIELDS
    [JsonPropertyName("a338be75b7a00bdd9ff34382b394c98ef46b49f9")]
    public string? ClientClassification { get; set; }

    [JsonPropertyName("b19eff6d327ae0c47b8a0b2075cbe9b1e440867a")]
    public string? LeadQualification { get; set; }

    [JsonPropertyName("5d31f719e070f8d1ca81be8e23f059cfc95ac78c")]
    public string? LabelKlaviyo { get; set; }

    [JsonPropertyName("282fafbe9a80299d62370fd2496535430d3ac667")]
    public string? TotalBalanceLetter { get; set; }

    [JsonPropertyName("1db97da38aacedce59d19324d7ce15c39a6b7827")]
    public string? UniformBalanceLetter { get; set; }

    [JsonPropertyName("0838c804a7c102b6dea03cddc6425ce3fb0329d0")]
    public string? MaterialBalanceLetter { get; set; }

    [JsonPropertyName("148394d29aeb05fee5938069dc432353e9d653ee")]
    public PipedriveMoneyValueDto? TotalBalance { get; set; }

    [JsonPropertyName("a98020622308a9bbff8bb5f71522b5ded304bd55")]
    public PipedriveMoneyValueDto? UniformBalance { get; set; }

    [JsonPropertyName("6ffab9a10893db85dec5fa5ff578a6fa3303393b")]
    public PipedriveMoneyValueDto? MaterialBalance { get; set; }

    [JsonPropertyName("1dfa6a875393bb6af4d9393fcec6dcceac48f045")]
    public int? CategoryUniformBalance { get; set; }

    [JsonPropertyName("037d597ba1bc5280cfb806b08adf91c47318f4da")]
    public int? CategoryMaterialBalance { get; set; }

    [JsonPropertyName("c5585bfbfdf3fe248cf469e62d153a272c5a2c69")]
    public string? AlteradoViaIntegracao { get; set; }

    [JsonPropertyName("c35f7506a72f579a923b28f81d989d4727f5dc95")]
    public string? BenefitType { get; set; }

    [JsonPropertyName("c190a671ce7588e392ec9cf7ace1c30908e1f6a6")]
    public string? OrderId { get; set; }

    [JsonPropertyName("c88312ceda2291f9a9895a9ea6165d94a8ac8350")]
    public string? OrderNumber { get; set; }

    [JsonPropertyName("9bc91320d4c2839041e2356a0b1694d9203e901b")]
    public string? TipoDeVenda { get; set; }
}

public class PipedriveMoneyValueDto
{
    [JsonPropertyName("value")]
    public double? Value { get; set; }

    [JsonPropertyName("currency")]
    public string? Currency { get; set; }
}
