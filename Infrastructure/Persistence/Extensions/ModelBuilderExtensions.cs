using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Infrastructure.Persistence.Extensions;

public static class ModelBuilderExtensions
{
    public static void UseSnakeCaseNames(this ModelBuilder modelBuilder)
    {
        foreach (var entity in modelBuilder.Model.GetEntityTypes())
        {
            // tabela
            entity.SetTableName(ToSnakeCase(entity.GetTableName()!));

            // colunas
            foreach (var property in entity.GetProperties())
            {
                property.SetColumnName(
                    ToSnakeCase(
                        property.GetColumnName(
                            StoreObjectIdentifier.Table(entity.GetTableName()!, entity.GetSchema())
                        )!
                    )
                );
            }

            // chaves
            foreach (var key in entity.GetKeys())
                key.SetName(ToSnakeCase(key.GetName()!));

            // índices
            foreach (var index in entity.GetIndexes())
                index.SetDatabaseName(ToSnakeCase(index.GetDatabaseName()!));

            // FKs
            foreach (var fk in entity.GetForeignKeys())
                fk.SetConstraintName(ToSnakeCase(fk.GetConstraintName()!));
        }
    }

    private static string ToSnakeCase(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        var sb = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            var c = input[i];
            if (char.IsUpper(c))
            {
                if (i > 0)
                    sb.Append('_');
                sb.Append(char.ToLowerInvariant(c));
            }
            else
            {
                sb.Append(c);
            }
        }
        return sb.ToString();
    }
}
