// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="FeatureSwitchDefinitionAttribute.ExcludeFromCodeCoverage.cs" company="Syntony">
//     Copyright © 2017 - 2024 by J.P.Hahnl® - All rights reserved.
// </copyright>
// <author>Ing. Josef Hahnl, MBA - hahnl</author>
// <email>syntony@aon.at</email>
// <date>20.11.2024 09:47:12</date>
// <information solution="J.P.Hahnl.Kernel.Nullable" project="J.P.Hahnl.Kernel.Nullable" framework=".NETStandard,Version=v2.0" kind="Windows (C# - csproj)">
//     <file type=".cs" created="20.11.2024 09:39:13" modified="20.11.2024 09:47:12" lastAccess="20.11.2024 09:47:12">
//         D:\J.P.Hahnl\Proj\Kernel\Source\J.P.Hahnl.Kernel.Nullable\Source\FeatureSwitchDefinitionAttribute.ExcludeFromCodeCoverage.cs
//     </file>
//     <lineStatistics total="52" netLines="49" blankLines ="3" codeLines="46" codeRatio="88.46 %" allCommentLines="30" commentLines="1" headerLines="29" documentationLines="3"/>
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
// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
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
