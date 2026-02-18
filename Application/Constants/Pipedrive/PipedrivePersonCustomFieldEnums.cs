namespace Application.Constants.Pipedrive;

/// <summary>
/// IDs das opções dos campos customizados do tipo enum/set em Person (personCustomFields.json).
/// Use ao definir ou comparar valores de <see cref="Application.Dtos.Pipedrive.PipedrivePersonCustomFieldsDto"/>.
/// </summary>
public static class PipedrivePersonCustomFieldEnums
{
    /// <summary>Telefone possui whatsapp? (ed0ebdc9...)</summary>
    public static class WhatsApp
    {
        public const int True = 325;
        public const int False = 326;
    }

    /// <summary>Já comprou uniforme? (ab084f6c...)</summary>
    public static class BoughtUniform
    {
        public const int True = 413;
        public const int False = 414;
    }

    /// <summary>Já comprou material? (a5cff8c8...)</summary>
    public static class BoughtMaterial
    {
        public const int True = 411;
        public const int False = 412;
    }

    /// <summary>Compra 2026 (ca7a2018...)</summary>
    public static class PurchasedIn26
    {
        public const int True = 448;
        public const int False = 449;
    }

    /// <summary>PROBLEMA NO APLICATICO (a878f1cc...)</summary>
    public static class AppProblem
    {
        public const int EsqueceuASenha = 442;
        public const int SemRg = 443;
        public const int TelefoneNaoCompativel = 444;
        public const int Instabilidade = 445;
        public const int FotoCadastroIncompativel = 446;
        public const int BeneficioZerado = 447;
    }

    /// <summary>BlackList (2c698f7f...)</summary>
    public static class Blacklist
    {
        public const int NaoDesejaMaisContato = 314;
    }

    /// <summary>Cliente já respondeu (f65e81c9...)</summary>
    public static class AlreadyResponded
    {
        public const int Sim = 416;
    }

    /// <summary>Criação de novos negócios &lt;&gt; Gatilho Automação (3c39e13b...) - set</summary>
    public static class NewDealsCreationTrigger
    {
        public const int CriarNegocio = 415;
    }

    /// <summary>STATUS DE NEGÓCIOS PIPEDRIVE (d15ea60c...)</summary>
    public static class PipedriveDealsStatus
    {
        public const int ClienteSendoTrabalhado = 330;
    }
}
