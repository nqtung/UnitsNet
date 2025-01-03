//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;

#if NET7_0_OR_GREATER
using System.Numerics;
#endif

#nullable enable

namespace UnitsNet.NumberExtensions.NumberToElectricResistance
{
    /// <summary>
    /// A number to ElectricResistance Extensions
    /// </summary>
    public static class NumberToElectricResistanceExtensions
    {
        /// <inheritdoc cref="ElectricResistance.FromGigaohms(UnitsNet.QuantityValue)" />
        public static ElectricResistance Gigaohms<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricResistance.FromGigaohms(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricResistance.FromKiloohms(UnitsNet.QuantityValue)" />
        public static ElectricResistance Kiloohms<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricResistance.FromKiloohms(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricResistance.FromMegaohms(UnitsNet.QuantityValue)" />
        public static ElectricResistance Megaohms<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricResistance.FromMegaohms(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricResistance.FromMicroohms(UnitsNet.QuantityValue)" />
        public static ElectricResistance Microohms<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricResistance.FromMicroohms(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricResistance.FromMilliohms(UnitsNet.QuantityValue)" />
        public static ElectricResistance Milliohms<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricResistance.FromMilliohms(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricResistance.FromNanoohms(UnitsNet.QuantityValue)" />
        public static ElectricResistance Nanoohms<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricResistance.FromNanoohms(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricResistance.FromOhms(UnitsNet.QuantityValue)" />
        public static ElectricResistance Ohms<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricResistance.FromOhms(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricResistance.FromTeraohms(UnitsNet.QuantityValue)" />
        public static ElectricResistance Teraohms<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricResistance.FromTeraohms(Convert.ToDouble(value));

    }
}
