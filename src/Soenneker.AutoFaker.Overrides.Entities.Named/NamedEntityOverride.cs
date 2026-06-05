using Soenneker.Entities.Named;
using Soenneker.Utils.AutoBogus.Context;
using Soenneker.Utils.AutoBogus.Override;

namespace Soenneker.AutoFaker.Overrides.Entities.Named;

/// <summary>
/// An AutoFaker (AutoBogus) override for NamedEntity object
/// </summary>
public class NamedEntityOverride : AutoFakerOverride<NamedEntity>
{
    /// <summary>
    /// Executes the can override operation.
    /// </summary>
    /// <param name="context">The context.</param>
    /// <returns>A value indicating whether the operation succeeded.</returns>
    public override bool CanOverride(AutoFakerContext context)
    {
        return context.GenerateType.IsSubclassOf(typeof(NamedEntity));
    }

    /// <summary>
    /// Executes the generate operation.
    /// </summary>
    /// <param name="context">The context.</param>
    public override void Generate(AutoFakerOverrideContext context)
    {
        var target = (context.Instance as NamedEntity)!;
        target.Name = context.Faker.Commerce.ProductName();
        target.Id = context.Faker.Random.Guid().ToString();
    }
}