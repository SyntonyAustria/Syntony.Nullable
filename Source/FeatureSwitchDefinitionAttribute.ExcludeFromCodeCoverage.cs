// -------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="FeatureSwitchDefinitionAttribute.ExcludeFromCodeCoverage.cs" company="J.P.Hahnl">
//     Copyright © 2017 - 2025 by Syntony® / Ing. Josef Hahnl, MBA - SyntonyAustria@outlook.com - All rights reserved.
// </copyright>
// <author>Hahnl - hahnl</author>
// <email>j.p.hahnl@outlook.com</email>
// <date>12.11.2025 09:33:16</date>
// <information solution="Syntony.Nullable" project="Syntony.Nullable" framework=".NETStandard,Version=v2.0" kind="Windows (C# - csproj)">
//     <file type=".cs" created="02.11.2025 09:51:16" modified="12.11.2025 09:33:16" lastAccess="12.11.2025 09:33:16">
//         D:\Syntony\Proj\Nullable\Source\Syntony.Nullable\Source\FeatureSwitchDefinitionAttribute.ExcludeFromCodeCoverage.cs
//     </file>
//     <lineStatistics total="52" contentLines="49" blankLines ="3" codeLines="17" codeRatio="32.69 %" allCommentLines="30" commentLines="30" headerLines="29"/>
//     <language>C#</language>
//     <namespace>System.Diagnostics.CodeAnalysis</namespace>
//     <class>FeatureSwitchDefinitionAttribute</class>
//     <identifiers>
//         <Namespace>System.Diagnostics.CodeAnalysis</Namespace>
//         <Class>FeatureSwitchDefinitionAttribute</Class>
//         <Record>FeatureSwitchDefinitionAttribute</Record>
//     </identifiers>
//     <codeMetric>
//         <numberOfUsings>1</numberOfUsings>
//         <numberOfAttributes>1</numberOfAttributes>
//     </codeMetric>
// </information>
// <summary>
//     Indicates that the specified public static boolean get-only property corresponds to the feature switch specified by name.
// </summary>
// -------------------------------------------------------------------------------------------------------------------------------------------------------------
#if !NULLABLE_ATTRIBUTES_DISABLE
#nullable enable
#pragma warning disable

namespace System.Diagnostics.CodeAnalysis
{
    using global::System;

#if DEBUG
    /// <summary>Indicates that the specified public static boolean get-only property corresponds to the feature switch specified by name.</summary>
    /// <remarks>IL rewriters and compilers can use this to substitute the return value of the specified property with the value of the feature switch.</remarks>
    /// <devdoc><a href="https://github.com/dotnet/runtime/blob/main/src/libraries/System.Private.CoreLib/src/System/Diagnostics/CodeAnalysis/FeatureSwitchDefinitionAttribute.cs"/></devdoc>
#endif
#if !NULLABLE_ATTRIBUTES_INCLUDE_IN_CODE_COVERAGE
    [ExcludeFromCodeCoverage]
#endif
    internal sealed partial class FeatureSwitchDefinitionAttribute : Attribute
    { }
}

#pragma warning restore
#nullable restore
#endif // NULLABLE_ATTRIBUTES_DISABLE
