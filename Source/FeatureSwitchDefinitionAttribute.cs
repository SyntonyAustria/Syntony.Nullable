// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="FeatureSwitchDefinitionAttribute.cs" company="Syntony">
//     Copyright © 2017 - 2024 by J.P.Hahnl® - All rights reserved.
// </copyright>
// <author>Ing. Josef Hahnl, MBA - hahnl</author>
// <email>syntony@aon.at</email>
// <date>20.11.2024 09:46:41</date>
// <information solution="J.P.Hahnl.Kernel.Nullable" project="J.P.Hahnl.Kernel.Nullable" framework=".NETStandard,Version=v2.0" kind="Windows (C# - csproj)">
//     <file type=".cs" created="20.11.2024 09:39:10" modified="20.11.2024 09:46:41" lastAccess="20.11.2024 09:46:41">
//         D:\J.P.Hahnl\Proj\Kernel\Source\J.P.Hahnl.Kernel.Nullable\Source\FeatureSwitchDefinitionAttribute.cs
//     </file>
//     <lineStatistics total="69" netLines="65" blankLines ="4" codeLines="59" codeRatio="85.51 %" allCommentLines="32" commentLines="1" headerLines="31" documentationLines="6"/>
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
//         <numberOfMethods>1</numberOfMethods>
//         <numberOfProperties>1</numberOfProperties>
//         <numberOfAttributes>2</numberOfAttributes>
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
    [AttributeUsage(AttributeTargets.Property, Inherited = false)]
#if !NULLABLE_ATTRIBUTES_INCLUDE_IN_CODE_COVERAGE
    [DebuggerNonUserCode]
#endif
    internal sealed partial class FeatureSwitchDefinitionAttribute : Attribute
    {
#if DEBUG
        /// <summary>Initializes a new instance of the <see cref="FeatureSwitchDefinitionAttribute"/> class with the specified feature switch name.</summary>
        /// <param name="switchName">The name of the feature switch that provides the value for the specified property.</param>
#endif
        public FeatureSwitchDefinitionAttribute(string switchName)
        {
            this.SwitchName = switchName;
        }

#if DEBUG
        /// <summary>The name of the feature switch that provides the value for the specified property.</summary>
#endif
        public string SwitchName { get; }
    }
}

#pragma warning restore
#nullable restore
#endif // NULLABLE_ATTRIBUTES_DISABLE
