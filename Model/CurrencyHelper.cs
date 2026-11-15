using System.Globalization;

namespace BlazingPizza;

/// <summary>
/// Formats every price in the app as South African Rand (ZAR), e.g. "R12.50".
/// The "R" is written explicitly so no other currency symbol can appear,
/// regardless of the machine's culture or globalization settings.
/// </summary>
public static class CurrencyHelper
{
    public static string Format(decimal amount) =>
        "R" + amount.ToString("N2", CultureInfo.InvariantCulture);
}
