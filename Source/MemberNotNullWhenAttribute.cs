// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="MemberNotNullWhenAttribute.cs" company="Syntony">
//     Copyright © 2017 - 2024 by J.P.Hahnl® - All rights reserved.
// </copyright>
// <author>Ing. Josef Hahnl, MBA - hahnl</author>
// <email>syntony@aon.at</email>
// <date>20.11.2024 09:46:10</date>
// <information solution="J.P.Hahnl.Kernel.Nullable" project="J.P.Hahnl.Kernel.Nullable" framework=".NETStandard,Version=v2.0" kind="Windows (C# - csproj)">
//     <file type=".cs" created="15.11.2024 14:08:45" modified="20.11.2024 09:46:10" lastAccess="20.11.2024 09:46:10">
//         D:\J.P.Hahnl\Proj\Kernel\Source\J.P.Hahnl.Kernel.Nullable\Source\MemberNotNullWhenAttribute.cs
//     </file>
//     <lineStatistics total="89" netLines="83" blankLines ="6" codeLines="70" codeRatio="78.65 %" allCommentLines="32" commentLines="1" headerLines="31" documentationLines="13"/>
//     <language>C#</language>
//     <namespace>System.Diagnostics.CodeAnalysis</namespace>
//     <class>MemberNotNullWhenAttribute</class>
//     <identifiers>
//         <Namespace>System.Diagnostics.CodeAnalysis</Namespace>
//         <Class>MemberNotNullWhenAttribute</Class>
//         <Record>MemberNotNullWhenAttribute</Record>
//     </identifiers>
//     <codeMetric>
//         <numberOfUsings>1</numberOfUsings>
//         <numberOfMethods>2</numberOfMethods>
//         <numberOfProperties>2</numberOfProperties>
//         <numberOfAttributes>2</numberOfAttributes>
//     </codeMetric>
// </information>
// <summary>
//     Specifies that the method or property will ensure that the listed field and property members have non-<see langword="null" /> values when returning with the specified return value condition.
// </summary>
// --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
#if !NULLABLE_ATTRIBUTES_DISABLE
#nullable enable
#pragma warning disable

namespace System.Diagnostics.CodeAnalysis
{
    using global::System;

#if DEBUG
    /// <summary>Specifies that the method or property will ensure that the listed field and property members have non-<see langword="null" /> values when returning with the specified return value condition.</summary>
    /// <seealso cref="System.Attribute" />
    /// <devdoc><a href="https://github.com/dotnet/aspnetcore/blob/main/src/Shared/Nullable/NullableAttributes.cs" /></devdoc>
    /// <devdoc><a href="https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.membernotnullwhenattribute?view=net-8.0"/></devdoc>
#endif
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
#if !NULLABLE_ATTRIBUTES_INCLUDE_IN_CODE_COVERAGE
    [DebuggerNonUserCode]
#endif
    internal sealed partial class MemberNotNullWhenAttribute : Attribute
    {
#if DEBUG
        /// <summary>Gets the return value condition.</summary>
#endif
        public bool ReturnValue { get; }

#if DEBUG
        /// <summary>Gets field or property member names.</summary>
#endif
        public string[] Members { get; }

#if DEBUG
        /// <summary>Initializes the attribute with the specified return value condition and a field or property member.</summary>
        /// <param name="returnValue">The return value condition. If the method returns this value,
        /// the associated parameter will not be <see langword="null" />.</param>
        /// <param name="member">The field or property member that is promised to be not-<see langword="null" />.</param>
#endif
        public MemberNotNullWhenAttribute(bool returnValue, string member)
        {
            ReturnValue = returnValue;
            Members = new[] { member };
        }

#if DEBUG
        /// <summary>Initializes the attribute with the specified return value condition and list of field and property members.</summary>
        /// <param name="returnValue">The return value condition. If the method returns this value, the associated parameter will not be <see langword="null" />.</param>
        /// <param name="members">The list of field and property members that are promised to be not-null.</param>
#endif
        public MemberNotNullWhenAttribute(bool returnValue, params string[] members)
        {
            ReturnValue = returnValue;
            Members = members;
        }
    }
}

#pragma warning restore
#nullable restore
#endif // NULLABLE_ATTRIBUTES_DISABLE
