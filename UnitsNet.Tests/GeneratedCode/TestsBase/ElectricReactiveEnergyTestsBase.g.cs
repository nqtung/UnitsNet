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
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using UnitsNet.Tests.Helpers;
using UnitsNet.Tests.TestsBase;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of ElectricReactiveEnergy.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ElectricReactiveEnergyTestsBase : QuantityTestsBase
    {
        protected abstract double KilovoltampereReactiveHoursInOneVoltampereReactiveHour { get; }
        protected abstract double MegavoltampereReactiveHoursInOneVoltampereReactiveHour { get; }
        protected abstract double VoltampereReactiveHoursInOneVoltampereReactiveHour { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double KilovoltampereReactiveHoursTolerance { get { return 1e-5; } }
        protected virtual double MegavoltampereReactiveHoursTolerance { get { return 1e-5; } }
        protected virtual double VoltampereReactiveHoursTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(ElectricReactiveEnergyUnit unit)
        {
            return unit switch
            {
                ElectricReactiveEnergyUnit.KilovoltampereReactiveHour => (KilovoltampereReactiveHoursInOneVoltampereReactiveHour, KilovoltampereReactiveHoursTolerance),
                ElectricReactiveEnergyUnit.MegavoltampereReactiveHour => (MegavoltampereReactiveHoursInOneVoltampereReactiveHour, MegavoltampereReactiveHoursTolerance),
                ElectricReactiveEnergyUnit.VoltampereReactiveHour => (VoltampereReactiveHoursInOneVoltampereReactiveHour, VoltampereReactiveHoursTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { ElectricReactiveEnergyUnit.KilovoltampereReactiveHour },
            new object[] { ElectricReactiveEnergyUnit.MegavoltampereReactiveHour },
            new object[] { ElectricReactiveEnergyUnit.VoltampereReactiveHour },
        };

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new ElectricReactiveEnergy();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(ElectricReactiveEnergyUnit.VoltampereReactiveHour, quantity.Unit);
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ElectricReactiveEnergy(double.PositiveInfinity, ElectricReactiveEnergyUnit.VoltampereReactiveHour));
            Assert.Throws<ArgumentException>(() => new ElectricReactiveEnergy(double.NegativeInfinity, ElectricReactiveEnergyUnit.VoltampereReactiveHour));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ElectricReactiveEnergy(double.NaN, ElectricReactiveEnergyUnit.VoltampereReactiveHour));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new ElectricReactiveEnergy(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new ElectricReactiveEnergy(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (ElectricReactiveEnergy) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void ElectricReactiveEnergy_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new ElectricReactiveEnergy(1, ElectricReactiveEnergyUnit.VoltampereReactiveHour);

            QuantityInfo<ElectricReactiveEnergyUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(ElectricReactiveEnergy.Zero, quantityInfo.Zero);
            Assert.Equal("ElectricReactiveEnergy", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<ElectricReactiveEnergyUnit>().OrderBy(x => x.ToString()).ToArray();
            var unitNames = units.Select(x => x.ToString());
        }

        [Fact]
        public void VoltampereReactiveHourToElectricReactiveEnergyUnits()
        {
            ElectricReactiveEnergy voltamperereactivehour = ElectricReactiveEnergy.FromVoltampereReactiveHours(1);
            AssertEx.EqualTolerance(KilovoltampereReactiveHoursInOneVoltampereReactiveHour, voltamperereactivehour.KilovoltampereReactiveHours, KilovoltampereReactiveHoursTolerance);
            AssertEx.EqualTolerance(MegavoltampereReactiveHoursInOneVoltampereReactiveHour, voltamperereactivehour.MegavoltampereReactiveHours, MegavoltampereReactiveHoursTolerance);
            AssertEx.EqualTolerance(VoltampereReactiveHoursInOneVoltampereReactiveHour, voltamperereactivehour.VoltampereReactiveHours, VoltampereReactiveHoursTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = ElectricReactiveEnergy.From(1, ElectricReactiveEnergyUnit.KilovoltampereReactiveHour);
            AssertEx.EqualTolerance(1, quantity00.KilovoltampereReactiveHours, KilovoltampereReactiveHoursTolerance);
            Assert.Equal(ElectricReactiveEnergyUnit.KilovoltampereReactiveHour, quantity00.Unit);

            var quantity01 = ElectricReactiveEnergy.From(1, ElectricReactiveEnergyUnit.MegavoltampereReactiveHour);
            AssertEx.EqualTolerance(1, quantity01.MegavoltampereReactiveHours, MegavoltampereReactiveHoursTolerance);
            Assert.Equal(ElectricReactiveEnergyUnit.MegavoltampereReactiveHour, quantity01.Unit);

            var quantity02 = ElectricReactiveEnergy.From(1, ElectricReactiveEnergyUnit.VoltampereReactiveHour);
            AssertEx.EqualTolerance(1, quantity02.VoltampereReactiveHours, VoltampereReactiveHoursTolerance);
            Assert.Equal(ElectricReactiveEnergyUnit.VoltampereReactiveHour, quantity02.Unit);

        }

        [Fact]
        public void FromVoltampereReactiveHours_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ElectricReactiveEnergy.FromVoltampereReactiveHours(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => ElectricReactiveEnergy.FromVoltampereReactiveHours(double.NegativeInfinity));
        }

        [Fact]
        public void FromVoltampereReactiveHours_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ElectricReactiveEnergy.FromVoltampereReactiveHours(double.NaN));
        }

        [Fact]
        public void As()
        {
            var voltamperereactivehour = ElectricReactiveEnergy.FromVoltampereReactiveHours(1);
            AssertEx.EqualTolerance(KilovoltampereReactiveHoursInOneVoltampereReactiveHour, voltamperereactivehour.As(ElectricReactiveEnergyUnit.KilovoltampereReactiveHour), KilovoltampereReactiveHoursTolerance);
            AssertEx.EqualTolerance(MegavoltampereReactiveHoursInOneVoltampereReactiveHour, voltamperereactivehour.As(ElectricReactiveEnergyUnit.MegavoltampereReactiveHour), MegavoltampereReactiveHoursTolerance);
            AssertEx.EqualTolerance(VoltampereReactiveHoursInOneVoltampereReactiveHour, voltamperereactivehour.As(ElectricReactiveEnergyUnit.VoltampereReactiveHour), VoltampereReactiveHoursTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new ElectricReactiveEnergy(value: 1, unit: ElectricReactiveEnergy.BaseUnit);
            Func<object> AsWithSIUnitSystem = () => quantity.As(UnitSystem.SI);

            if (SupportsSIUnitSystem)
            {
                var value = Convert.ToDouble(AsWithSIUnitSystem());
                Assert.Equal(1, value);
            }
            else
            {
                Assert.Throws<ArgumentException>(AsWithSIUnitSystem);
            }
        }

        [Fact]
        public void Parse()
        {
            try
            {
                var parsed = ElectricReactiveEnergy.Parse("1 kvarh", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.KilovoltampereReactiveHours, KilovoltampereReactiveHoursTolerance);
                Assert.Equal(ElectricReactiveEnergyUnit.KilovoltampereReactiveHour, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = ElectricReactiveEnergy.Parse("1 Mvarh", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.MegavoltampereReactiveHours, MegavoltampereReactiveHoursTolerance);
                Assert.Equal(ElectricReactiveEnergyUnit.MegavoltampereReactiveHour, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsed = ElectricReactiveEnergy.Parse("1 varh", CultureInfo.GetCultureInfo("en-US"));
                AssertEx.EqualTolerance(1, parsed.VoltampereReactiveHours, VoltampereReactiveHoursTolerance);
                Assert.Equal(ElectricReactiveEnergyUnit.VoltampereReactiveHour, parsed.Unit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParse()
        {
            {
                Assert.True(ElectricReactiveEnergy.TryParse("1 kvarh", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.KilovoltampereReactiveHours, KilovoltampereReactiveHoursTolerance);
                Assert.Equal(ElectricReactiveEnergyUnit.KilovoltampereReactiveHour, parsed.Unit);
            }

            {
                Assert.True(ElectricReactiveEnergy.TryParse("1 Mvarh", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.MegavoltampereReactiveHours, MegavoltampereReactiveHoursTolerance);
                Assert.Equal(ElectricReactiveEnergyUnit.MegavoltampereReactiveHour, parsed.Unit);
            }

            {
                Assert.True(ElectricReactiveEnergy.TryParse("1 varh", CultureInfo.GetCultureInfo("en-US"), out var parsed));
                AssertEx.EqualTolerance(1, parsed.VoltampereReactiveHours, VoltampereReactiveHoursTolerance);
                Assert.Equal(ElectricReactiveEnergyUnit.VoltampereReactiveHour, parsed.Unit);
            }

        }

        [Fact]
        public void ParseUnit()
        {
            try
            {
                var parsedUnit = ElectricReactiveEnergy.ParseUnit("kvarh", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ElectricReactiveEnergyUnit.KilovoltampereReactiveHour, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = ElectricReactiveEnergy.ParseUnit("Mvarh", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ElectricReactiveEnergyUnit.MegavoltampereReactiveHour, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

            try
            {
                var parsedUnit = ElectricReactiveEnergy.ParseUnit("varh", CultureInfo.GetCultureInfo("en-US"));
                Assert.Equal(ElectricReactiveEnergyUnit.VoltampereReactiveHour, parsedUnit);
            } catch (AmbiguousUnitParseException) { /* Some units have the same abbreviations */ }

        }

        [Fact]
        public void TryParseUnit()
        {
            {
                Assert.True(ElectricReactiveEnergy.TryParseUnit("kvarh", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(ElectricReactiveEnergyUnit.KilovoltampereReactiveHour, parsedUnit);
            }

            {
                Assert.True(ElectricReactiveEnergy.TryParseUnit("Mvarh", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(ElectricReactiveEnergyUnit.MegavoltampereReactiveHour, parsedUnit);
            }

            {
                Assert.True(ElectricReactiveEnergy.TryParseUnit("varh", CultureInfo.GetCultureInfo("en-US"), out var parsedUnit));
                Assert.Equal(ElectricReactiveEnergyUnit.VoltampereReactiveHour, parsedUnit);
            }

        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit(ElectricReactiveEnergyUnit unit)
        {
            var inBaseUnits = ElectricReactiveEnergy.From(1.0, ElectricReactiveEnergy.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(ElectricReactiveEnergyUnit unit)
        {
            var quantity = ElectricReactiveEnergy.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(ElectricReactiveEnergyUnit unit)
        {
            // See if there is a unit available that is not the base unit, fallback to base unit if it has only a single unit.
            var fromUnit = ElectricReactiveEnergy.Units.First(u => u != ElectricReactiveEnergy.BaseUnit);

            var quantity = ElectricReactiveEnergy.From(3.0, fromUnit);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public virtual void ToUnit_FromDefaultQuantity_ReturnsQuantityWithGivenUnit(ElectricReactiveEnergyUnit unit)
        {
            var quantity = default(ElectricReactiveEnergy);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ElectricReactiveEnergy voltamperereactivehour = ElectricReactiveEnergy.FromVoltampereReactiveHours(1);
            AssertEx.EqualTolerance(1, ElectricReactiveEnergy.FromKilovoltampereReactiveHours(voltamperereactivehour.KilovoltampereReactiveHours).VoltampereReactiveHours, KilovoltampereReactiveHoursTolerance);
            AssertEx.EqualTolerance(1, ElectricReactiveEnergy.FromMegavoltampereReactiveHours(voltamperereactivehour.MegavoltampereReactiveHours).VoltampereReactiveHours, MegavoltampereReactiveHoursTolerance);
            AssertEx.EqualTolerance(1, ElectricReactiveEnergy.FromVoltampereReactiveHours(voltamperereactivehour.VoltampereReactiveHours).VoltampereReactiveHours, VoltampereReactiveHoursTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ElectricReactiveEnergy v = ElectricReactiveEnergy.FromVoltampereReactiveHours(1);
            AssertEx.EqualTolerance(-1, -v.VoltampereReactiveHours, VoltampereReactiveHoursTolerance);
            AssertEx.EqualTolerance(2, (ElectricReactiveEnergy.FromVoltampereReactiveHours(3)-v).VoltampereReactiveHours, VoltampereReactiveHoursTolerance);
            AssertEx.EqualTolerance(2, (v + v).VoltampereReactiveHours, VoltampereReactiveHoursTolerance);
            AssertEx.EqualTolerance(10, (v*10).VoltampereReactiveHours, VoltampereReactiveHoursTolerance);
            AssertEx.EqualTolerance(10, (10*v).VoltampereReactiveHours, VoltampereReactiveHoursTolerance);
            AssertEx.EqualTolerance(2, (ElectricReactiveEnergy.FromVoltampereReactiveHours(10)/5).VoltampereReactiveHours, VoltampereReactiveHoursTolerance);
            AssertEx.EqualTolerance(2, ElectricReactiveEnergy.FromVoltampereReactiveHours(10)/ElectricReactiveEnergy.FromVoltampereReactiveHours(5), VoltampereReactiveHoursTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ElectricReactiveEnergy oneVoltampereReactiveHour = ElectricReactiveEnergy.FromVoltampereReactiveHours(1);
            ElectricReactiveEnergy twoVoltampereReactiveHours = ElectricReactiveEnergy.FromVoltampereReactiveHours(2);

            Assert.True(oneVoltampereReactiveHour < twoVoltampereReactiveHours);
            Assert.True(oneVoltampereReactiveHour <= twoVoltampereReactiveHours);
            Assert.True(twoVoltampereReactiveHours > oneVoltampereReactiveHour);
            Assert.True(twoVoltampereReactiveHours >= oneVoltampereReactiveHour);

            Assert.False(oneVoltampereReactiveHour > twoVoltampereReactiveHours);
            Assert.False(oneVoltampereReactiveHour >= twoVoltampereReactiveHours);
            Assert.False(twoVoltampereReactiveHours < oneVoltampereReactiveHour);
            Assert.False(twoVoltampereReactiveHours <= oneVoltampereReactiveHour);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ElectricReactiveEnergy voltamperereactivehour = ElectricReactiveEnergy.FromVoltampereReactiveHours(1);
            Assert.Equal(0, voltamperereactivehour.CompareTo(voltamperereactivehour));
            Assert.True(voltamperereactivehour.CompareTo(ElectricReactiveEnergy.Zero) > 0);
            Assert.True(ElectricReactiveEnergy.Zero.CompareTo(voltamperereactivehour) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ElectricReactiveEnergy voltamperereactivehour = ElectricReactiveEnergy.FromVoltampereReactiveHours(1);
            Assert.Throws<ArgumentException>(() => voltamperereactivehour.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ElectricReactiveEnergy voltamperereactivehour = ElectricReactiveEnergy.FromVoltampereReactiveHours(1);
            Assert.Throws<ArgumentNullException>(() => voltamperereactivehour.CompareTo(null));
        }

        [Theory]
        [InlineData(1, ElectricReactiveEnergyUnit.VoltampereReactiveHour, 1, ElectricReactiveEnergyUnit.VoltampereReactiveHour, true)]  // Same value and unit.
        [InlineData(1, ElectricReactiveEnergyUnit.VoltampereReactiveHour, 2, ElectricReactiveEnergyUnit.VoltampereReactiveHour, false)] // Different value.
        [InlineData(2, ElectricReactiveEnergyUnit.VoltampereReactiveHour, 1, ElectricReactiveEnergyUnit.KilovoltampereReactiveHour, false)] // Different value and unit.
        [InlineData(1, ElectricReactiveEnergyUnit.VoltampereReactiveHour, 1, ElectricReactiveEnergyUnit.KilovoltampereReactiveHour, false)] // Different unit.
        public void Equals_ReturnsTrue_IfValueAndUnitAreEqual(double valueA, ElectricReactiveEnergyUnit unitA, double valueB, ElectricReactiveEnergyUnit unitB, bool expectEqual)
        {
            var a = new ElectricReactiveEnergy(valueA, unitA);
            var b = new ElectricReactiveEnergy(valueB, unitB);

            // Operator overloads.
            Assert.Equal(expectEqual, a == b);
            Assert.Equal(expectEqual, b == a);
            Assert.Equal(!expectEqual, a != b);
            Assert.Equal(!expectEqual, b != a);

            // IEquatable<T>
            Assert.Equal(expectEqual, a.Equals(b));
            Assert.Equal(expectEqual, b.Equals(a));

            // IEquatable
            Assert.Equal(expectEqual, a.Equals((object)b));
            Assert.Equal(expectEqual, b.Equals((object)a));
        }

        [Fact]
        public void Equals_Null_ReturnsFalse()
        {
            var a = ElectricReactiveEnergy.Zero;

            Assert.False(a.Equals((object)null));

            // "The result of the expression is always 'false'..."
            #pragma warning disable CS8073
            Assert.False(a == null);
            Assert.False(null == a);
            Assert.True(a != null);
            Assert.True(null != a);
            #pragma warning restore CS8073
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = ElectricReactiveEnergy.FromVoltampereReactiveHours(1);
            Assert.True(v.Equals(ElectricReactiveEnergy.FromVoltampereReactiveHours(1), VoltampereReactiveHoursTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(ElectricReactiveEnergy.Zero, VoltampereReactiveHoursTolerance, ComparisonType.Relative));
            Assert.True(ElectricReactiveEnergy.FromVoltampereReactiveHours(100).Equals(ElectricReactiveEnergy.FromVoltampereReactiveHours(120), (double)0.3m, ComparisonType.Relative));
            Assert.False(ElectricReactiveEnergy.FromVoltampereReactiveHours(100).Equals(ElectricReactiveEnergy.FromVoltampereReactiveHours(120), (double)0.1m, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = ElectricReactiveEnergy.FromVoltampereReactiveHours(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(ElectricReactiveEnergy.FromVoltampereReactiveHours(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ElectricReactiveEnergy voltamperereactivehour = ElectricReactiveEnergy.FromVoltampereReactiveHours(1);
            Assert.False(voltamperereactivehour.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ElectricReactiveEnergy voltamperereactivehour = ElectricReactiveEnergy.FromVoltampereReactiveHours(1);
            Assert.False(voltamperereactivehour.Equals(null));
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(ElectricReactiveEnergyUnit)).Cast<ElectricReactiveEnergyUnit>();
            foreach (var unit in units)
            {
                var defaultAbbreviation = UnitsNetSetup.Default.UnitAbbreviations.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(ElectricReactiveEnergy.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            using var _ = new CultureScope("en-US");
            Assert.Equal("1 kvarh", new ElectricReactiveEnergy(1, ElectricReactiveEnergyUnit.KilovoltampereReactiveHour).ToString());
            Assert.Equal("1 Mvarh", new ElectricReactiveEnergy(1, ElectricReactiveEnergyUnit.MegavoltampereReactiveHour).ToString());
            Assert.Equal("1 varh", new ElectricReactiveEnergy(1, ElectricReactiveEnergyUnit.VoltampereReactiveHour).ToString());
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 kvarh", new ElectricReactiveEnergy(1, ElectricReactiveEnergyUnit.KilovoltampereReactiveHour).ToString(swedishCulture));
            Assert.Equal("1 Mvarh", new ElectricReactiveEnergy(1, ElectricReactiveEnergyUnit.MegavoltampereReactiveHour).ToString(swedishCulture));
            Assert.Equal("1 varh", new ElectricReactiveEnergy(1, ElectricReactiveEnergyUnit.VoltampereReactiveHour).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var _ = new CultureScope(CultureInfo.InvariantCulture);
            Assert.Equal("0.1 varh", new ElectricReactiveEnergy(0.123456, ElectricReactiveEnergyUnit.VoltampereReactiveHour).ToString("s1"));
            Assert.Equal("0.12 varh", new ElectricReactiveEnergy(0.123456, ElectricReactiveEnergyUnit.VoltampereReactiveHour).ToString("s2"));
            Assert.Equal("0.123 varh", new ElectricReactiveEnergy(0.123456, ElectricReactiveEnergyUnit.VoltampereReactiveHour).ToString("s3"));
            Assert.Equal("0.1235 varh", new ElectricReactiveEnergy(0.123456, ElectricReactiveEnergyUnit.VoltampereReactiveHour).ToString("s4"));
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 varh", new ElectricReactiveEnergy(0.123456, ElectricReactiveEnergyUnit.VoltampereReactiveHour).ToString("s1", culture));
            Assert.Equal("0.12 varh", new ElectricReactiveEnergy(0.123456, ElectricReactiveEnergyUnit.VoltampereReactiveHour).ToString("s2", culture));
            Assert.Equal("0.123 varh", new ElectricReactiveEnergy(0.123456, ElectricReactiveEnergyUnit.VoltampereReactiveHour).ToString("s3", culture));
            Assert.Equal("0.1235 varh", new ElectricReactiveEnergy(0.123456, ElectricReactiveEnergyUnit.VoltampereReactiveHour).ToString("s4", culture));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("en-US")]
        public void ToString_NullFormat_DefaultsToGeneralFormat(string cultureName)
        {
            var quantity = ElectricReactiveEnergy.FromVoltampereReactiveHours(1.0);
            CultureInfo formatProvider = cultureName == null
                ? null
                : CultureInfo.GetCultureInfo(cultureName);

            Assert.Equal(quantity.ToString("g", formatProvider), quantity.ToString(null, formatProvider));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("g")]
        public void ToString_NullProvider_EqualsCurrentCulture(string format)
        {
            var quantity = ElectricReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Equal(quantity.ToString(format, CultureInfo.CurrentCulture), quantity.ToString(format, null));
        }

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = ElectricReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = ElectricReactiveEnergy.FromVoltampereReactiveHours(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = ElectricReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = ElectricReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = ElectricReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = ElectricReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = ElectricReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = ElectricReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = ElectricReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = ElectricReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = ElectricReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = ElectricReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = ElectricReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = ElectricReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = ElectricReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = ElectricReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(ElectricReactiveEnergy)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = ElectricReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(ElectricReactiveEnergyUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = ElectricReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Equal(ElectricReactiveEnergy.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = ElectricReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Equal(ElectricReactiveEnergy.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = ElectricReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = ElectricReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Equal(new {ElectricReactiveEnergy.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = ElectricReactiveEnergy.FromVoltampereReactiveHours(value);
            Assert.Equal(ElectricReactiveEnergy.FromVoltampereReactiveHours(-value), -quantity);
        }
    }
}
