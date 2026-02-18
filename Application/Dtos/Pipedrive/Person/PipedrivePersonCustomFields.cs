using System.Text.Json.Serialization;

namespace Application.Dtos.Pipedrive.Person;

/// <summary>
/// Campos customizados de Person no Pipedrive.
/// Para os campos enum, use as constantes em <see cref="Constants.Pipedrive.PipedrivePersonCustomFieldEnums"/> (IDs das opções).
/// </summary>
public class PipedrivePersonCustomFieldsDto
{
    [JsonPropertyName("b66177615267108eb82868056db73d3b61eab4fb")]
    public string? TotalBalance { get; set; }

    [JsonPropertyName("89eb74af766278ee929cce77efa4014b4ff8a45a")]
    public string? ClientClassification { get; set; }

    [JsonPropertyName("43d752b65d7283fe30dae543901bb056a15805b5")]
    public string? BenefitAssessed { get; set; }

    [JsonPropertyName("ed0ebdc9c3c41d229310768e4bb5bd1b917f715d")]
    public int? WhatsIsValid { get; set; }

    [JsonPropertyName("00b1954f80f3d0d292471b6e73a6e434397f5835")]
    public string? EstimatedNumberOfChildren { get; set; }

    [JsonPropertyName("98ce86c82139d2266aa89daffe899496b644b391")]
    public string? Cpf { get; set; }

    [JsonPropertyName("ef576091b5f9adb0153bc09fb3967fcadc2a9614")]
    public string? AddressStreet { get; set; }

    [JsonPropertyName("bee974991c70ecc9bafc623d8df06c1b34c12121")]
    public string? AddressNumber { get; set; }

    [JsonPropertyName("27b3e90692df731e310e80f0a722f34b9f270a7a")]
    public string? AddressComplement { get; set; }

    [JsonPropertyName("a3962d103aeb26150963fa38e5494ba0912acd6c")]
    public string? AddressNeighborhood { get; set; }

    [JsonPropertyName("5f23cdd0fdf20e1d865ca069a091c5b88c4b46e8")]
    public string? AddressCity { get; set; }

    [JsonPropertyName("569ebed8311ad052f7c3774f593f492853e68693")]
    public string? AddressState { get; set; }

    [JsonPropertyName("766f8c550466b5d33e60fcf9ffc0abbec9a26425")]
    public string? AddressZipcode { get; set; }

    [JsonPropertyName("a765f57721c75ec2bb8204848255b0c4019b754a")]
    public string? DatabaseValidation { get; set; }

    [JsonPropertyName("af454b072f96eebdf8ef69d50f1929f2f6ce1b63")]
    public string? PurchaseCategory { get; set; }

    [JsonPropertyName("3931975ce1de0d9e0ed6bfb3198eef9131cf0d4d")]
    public string? IsRecurring { get; set; }

    [JsonPropertyName("f0e02a32169fcd8f7ffbb28e24c582def189ce97")]
    public string? LastPurchaseDate { get; set; }

    [JsonPropertyName("96c4e4d34effdfc26d48a473a8302594d348ba2a")]
    public string? PurchasedIn25 { get; set; }

    [JsonPropertyName("e3bd0a2d187786b8b9f169e92ef31618e007b629")]
    public string? PurchasedIn24 { get; set; }

    [JsonPropertyName("725ddc94fa4170c1086120ba2dc1d2a4b3d2e309")]
    public string? PurchasedIn23 { get; set; }

    [JsonPropertyName("0c9402210fcaf32d526cf5d22ea5bcc32ea4398c")]
    public string? PurchasedIn22 { get; set; }

    [JsonPropertyName("e5680746af357de14aace66a00cd455919d686c1")]
    public string? PurchasedIn21 { get; set; }

    [JsonPropertyName("1940f33dd6954735493fae0a79377faf4d17d748")]
    public string? AcceptMarketingEmail { get; set; }

    [JsonPropertyName("1abe9d195e5860f78a387946dcdbc774bfb2ecc2")]
    public string? AcceptMarketingSms { get; set; }

    [JsonPropertyName("6e989288233779d80c59f6c12c67792de0d817da")]
    public string? BaseId { get; set; }

    [JsonPropertyName("8eceedb5e8899e8007869a9ab4289f3f6b5fbb2d")]
    public string? Tickets { get; set; }

    [JsonPropertyName("2c698f7f7286b696efeb8a2f2a814d0d14539165")]
    public int? Blacklist { get; set; }

    [JsonPropertyName("68b4b23c270c2529f841f339cc41f44894e47825")]
    public string? LastActivationDate { get; set; }

    [JsonPropertyName("bb5f5ab6842b9539ee1cff0669334e8d3c879f7c")]
    public double? InitialContactsMade { get; set; }

    [JsonPropertyName("f30216769331bb76f1290ab8703718c2fc23562d")]
    public double? NumOfActivitiesForFirstResponse { get; set; }

    [JsonPropertyName("f65e81c9f2e4117cd124bb7cb0353e4148e8becb")]
    public int? AlreadyResponded { get; set; }

    [JsonPropertyName("66aa5a6746dd9cbc0aa6e2b63c4faf377e6a09f6")]
    public double? NumBlocks { get; set; }

    [JsonPropertyName("c428a82bc8029d25dd5016418549a4a003dea09c")]
    public double? DaysForWon { get; set; }

    [JsonPropertyName("d68545cc05f00a735f5f0d22f8641df612ecc990")]
    public double? MaterialBalance { get; set; }

    [JsonPropertyName("31f7f9fb52aba67b19f0f97fd1427882ff3d5259")]
    public double? UniformBalance { get; set; }

    [JsonPropertyName("ab084f6c3663f471411e19fda0fad95bb144b5ae")]
    public int? BoughtUniform { get; set; }

    [JsonPropertyName("d910d3f92b1b835dec0b11f313e23eaf6b624d5e")]
    public string? ReserveDate { get; set; }

    [JsonPropertyName("4140a536250101e426afc18b7b0f4837bb71326a")]
    public string? ReserveBenefit { get; set; }

    [JsonPropertyName("13e289879977294c64148324ff75874960f97917")]
    public string? SellerCode { get; set; }

    [JsonPropertyName("15c56bd85f8cf368363bb3cfd55eb78d1b4be4d2")]
    public string? ReserveSeller2026 { get; set; }

    [JsonPropertyName("51ba66e8649dd7ab928794cbe0e4c701bd6338dd")]
    public string? MaterialUrl { get; set; }

    [JsonPropertyName("58e2e3501ed71b7d2a7b563cfd72e792d838d968")]
    public string? UniformUrl { get; set; }

    [JsonPropertyName("b9e7713b4deae6389641adc08605160bea0e0395")]
    public double? TotalRemainingBalance { get; set; }

    [JsonPropertyName("113a0d66489b33aa6aa2957f56d7aae142afe268")]
    public string? UniformBalanceClassification { get; set; }

    [JsonPropertyName("e274bdd9690e5fb0a02237d3e9943ba927f46bac")]
    public string? MaterialBalanceClassification { get; set; }

    [JsonPropertyName("ca7a20186d146e75d9a63f7b216a2994a873fe02")]
    public string? PurchasedIn26 { get; set; }

    [JsonPropertyName("3aa60dbff27850f9b48ae6ba9d5ac4db8cb3721b")]
    public string? AcquiredBenefits { get; set; }

    [JsonPropertyName("20783be4c34f789fe01ba576acad4b2905dec6c3")]
    public string? LastUniformPurchaseDate { get; set; }

    [JsonPropertyName("ecaf968ee1d8cf8f683ab997ab58d13e3ea064b7")]
    public string? LastMaterialPurchaseDate { get; set; }

    [JsonPropertyName("a5cff8c8e5a17d3f6bac2e516bc5afab68242925")]
    public int? BoughtMaterial { get; set; }

    [JsonPropertyName("b9cc07e925c228ca4cac05c8bac5be86d3d4c195")]
    public string? LastPurchaseSeller { get; set; }

    [JsonPropertyName("e54f9ef8fdd648eaf3c6d78f3890713aa57cff50")]
    public string? CompanyClient { get; set; }

    [JsonPropertyName("e5bf4d1c0d06862fc0debc591185cb1d9cf19352")]
    public string? ClientType { get; set; }

    [JsonPropertyName("b76622736295c690c1d1df47168788e104bf162e")]
    public double? NumPurchases { get; set; }

    [JsonPropertyName("8c0e36013a663fed32f06ddeccad03aa8c1b2076")]
    public string? HasEverReserved { get; set; }

    [JsonPropertyName("a878f1cc91a12c0785b152cefe446e96758c7dfc")]
    public string? AppProblem { get; set; }

    [JsonPropertyName("2dd4b885d772d905cd2222600438e3584f83b95b")]
    public string? AddressCountry { get; set; }

    [JsonPropertyName("44384128c09fb79ff10bfcf8b803af265456a981")]
    public string? TemporaryDisqualification { get; set; }

    [JsonPropertyName("36bc4010f94a598d344d01e6322b88325c15bef9")]
    public string? PermanentDisqualification { get; set; }

    [JsonPropertyName("81ba70f4cb6a476fd7bc4ce21a829a7b7ca37436")]
    public string? ListIdentification { get; set; }

    [JsonPropertyName("3c39e13b8dc24691070bd6685d11753109f43962")]
    public string? NewDealsCreationTrigger { get; set; }

    [JsonPropertyName("5dfed2d4a499b5ec1fce67d0f4657ee3a8f5c50e")]
    public string? PurchaseStatusUse { get; set; }

    [JsonPropertyName("d15ea60c734e24e816d2cd7d4e2f3a309257acee")]
    public string? PipedriveDealsStatus { get; set; }

    [JsonPropertyName("2adbbe9f452e37e3691afe6c8523df0143c5bcc1")]
    public string? BackpackWaiting { get; set; }
}
