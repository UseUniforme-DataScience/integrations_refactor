using System.Text.Json;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Persistence.Converters;

public sealed class JsonElementValueConverter : ValueConverter<JsonElement?, string?>
{
    public JsonElementValueConverter()
        : base(
            v => v.HasValue ? v.Value.GetRawText() : null,
            v =>
                v != null
                    ? JsonSerializer.Deserialize<JsonElement>(v, (JsonSerializerOptions?)null)
                    : null
        ) { }
}
