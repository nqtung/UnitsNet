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

namespace UnitsNet.NumberExtensions.NumberToElectricAdmittance
{
    /// <summary>
    /// A number to ElectricAdmittance Extensions
    /// </summary>
    [Obsolete("Admittance is a complex number, which is not currently supported by UnitsNet. Please use either ElectricConductance or ElectricSusceptance instead.")]
    public static class NumberToElectricAdmittanceExtensions
    {
        /// <inheritdoc cref="ElectricAdmittance.FromGigamhos(UnitsNet.QuantityValue)" />
        [Obsolete("Admittance is a complex number, which is not currently supported by UnitsNet. Please use either ElectricConductance or ElectricSusceptance instead.")]
        public static ElectricAdmittance Gigamhos<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricAdmittance.FromGigamhos(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricAdmittance.FromGigasiemens(UnitsNet.QuantityValue)" />
        [Obsolete("Admittance is a complex number, which is not currently supported by UnitsNet. Please use either ElectricConductance or ElectricSusceptance instead.")]
        public static ElectricAdmittance Gigasiemens<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricAdmittance.FromGigasiemens(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricAdmittance.FromKilomhos(UnitsNet.QuantityValue)" />
        [Obsolete("Admittance is a complex number, which is not currently supported by UnitsNet. Please use either ElectricConductance or ElectricSusceptance instead.")]
        public static ElectricAdmittance Kilomhos<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricAdmittance.FromKilomhos(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricAdmittance.FromKilosiemens(UnitsNet.QuantityValue)" />
        [Obsolete("Admittance is a complex number, which is not currently supported by UnitsNet. Please use either ElectricConductance or ElectricSusceptance instead.")]
        public static ElectricAdmittance Kilosiemens<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricAdmittance.FromKilosiemens(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricAdmittance.FromMegamhos(UnitsNet.QuantityValue)" />
        [Obsolete("Admittance is a complex number, which is not currently supported by UnitsNet. Please use either ElectricConductance or ElectricSusceptance instead.")]
        public static ElectricAdmittance Megamhos<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricAdmittance.FromMegamhos(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricAdmittance.FromMegasiemens(UnitsNet.QuantityValue)" />
        [Obsolete("Admittance is a complex number, which is not currently supported by UnitsNet. Please use either ElectricConductance or ElectricSusceptance instead.")]
        public static ElectricAdmittance Megasiemens<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricAdmittance.FromMegasiemens(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricAdmittance.FromMhos(UnitsNet.QuantityValue)" />
        [Obsolete("Admittance is a complex number, which is not currently supported by UnitsNet. Please use either ElectricConductance or ElectricSusceptance instead.")]
        public static ElectricAdmittance Mhos<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricAdmittance.FromMhos(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricAdmittance.FromMicromhos(UnitsNet.QuantityValue)" />
        [Obsolete("Admittance is a complex number, which is not currently supported by UnitsNet. Please use either ElectricConductance or ElectricSusceptance instead.")]
        public static ElectricAdmittance Micromhos<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricAdmittance.FromMicromhos(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricAdmittance.FromMicrosiemens(UnitsNet.QuantityValue)" />
        [Obsolete("Admittance is a complex number, which is not currently supported by UnitsNet. Please use either ElectricConductance or ElectricSusceptance instead.")]
        public static ElectricAdmittance Microsiemens<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricAdmittance.FromMicrosiemens(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricAdmittance.FromMillimhos(UnitsNet.QuantityValue)" />
        [Obsolete("Admittance is a complex number, which is not currently supported by UnitsNet. Please use either ElectricConductance or ElectricSusceptance instead.")]
        public static ElectricAdmittance Millimhos<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricAdmittance.FromMillimhos(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricAdmittance.FromMillisiemens(UnitsNet.QuantityValue)" />
        [Obsolete("Admittance is a complex number, which is not currently supported by UnitsNet. Please use either ElectricConductance or ElectricSusceptance instead.")]
        public static ElectricAdmittance Millisiemens<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricAdmittance.FromMillisiemens(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricAdmittance.FromNanomhos(UnitsNet.QuantityValue)" />
        [Obsolete("Admittance is a complex number, which is not currently supported by UnitsNet. Please use either ElectricConductance or ElectricSusceptance instead.")]
        public static ElectricAdmittance Nanomhos<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricAdmittance.FromNanomhos(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricAdmittance.FromNanosiemens(UnitsNet.QuantityValue)" />
        [Obsolete("Admittance is a complex number, which is not currently supported by UnitsNet. Please use either ElectricConductance or ElectricSusceptance instead.")]
        public static ElectricAdmittance Nanosiemens<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricAdmittance.FromNanosiemens(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricAdmittance.FromSiemens(UnitsNet.QuantityValue)" />
        [Obsolete("Admittance is a complex number, which is not currently supported by UnitsNet. Please use either ElectricConductance or ElectricSusceptance instead.")]
        public static ElectricAdmittance Siemens<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricAdmittance.FromSiemens(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricAdmittance.FromTeramhos(UnitsNet.QuantityValue)" />
        [Obsolete("Admittance is a complex number, which is not currently supported by UnitsNet. Please use either ElectricConductance or ElectricSusceptance instead.")]
        public static ElectricAdmittance Teramhos<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricAdmittance.FromTeramhos(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricAdmittance.FromTerasiemens(UnitsNet.QuantityValue)" />
        [Obsolete("Admittance is a complex number, which is not currently supported by UnitsNet. Please use either ElectricConductance or ElectricSusceptance instead.")]
        public static ElectricAdmittance Terasiemens<T>(this T value)
            where T : notnull
#if NET7_0_OR_GREATER
            , INumber<T>
#endif
            => ElectricAdmittance.FromTerasiemens(Convert.ToDouble(value));

    }
}
