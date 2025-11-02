// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="FeatureGuardAttribute.cs" company="Syntony">
//     Copyright © 2017 - 2024 by J.P.Hahnl® - All rights reserved.
// </copyright>
// <author>Ing. Josef Hahnl, MBA - hahnl</author>
// <email>syntony@aon.at</email>
// <date>20.11.2024 09:53:28</date>
// <information solution="J.P.Hahnl.Kernel.Nullable" project="J.P.Hahnl.Kernel.Nullable" framework=".NETStandard,Version=v2.0" kind="Windows (C# - csproj)">
//     <file type=".cs" created="20.11.2024 09:49:36" modified="20.11.2024 09:53:28" lastAccess="20.11.2024 09:53:28">
//         D:\J.P.Hahnl\Proj\Kernel\Source\J.P.Hahnl.Kernel.Nullable\Source\FeatureGuardAttribute.cs
//     </file>
//     <lineStatistics total="69" netLines="65" blankLines ="4" codeLines="59" codeRatio="85.51 %" allCommentLines="32" commentLines="1" headerLines="31" documentationLines="6"/>
//     <language>C#</language>
//     <namespace>System.Diagnostics.CodeAnalysis</namespace>
//     <class>FeatureGuardAttribute</class>
//     <identifiers>
//         <Namespace>System.Diagnostics.CodeAnalysis</Namespace>
//         <Class>FeatureGuardAttribute</Class>
//         <Record>FeatureGuardAttribute</Record>
//     </identifiers>
//     <codeMetric>
//         <numberOfUsings>1</numberOfUsings>
//         <numberOfMethods>1</numberOfMethods>
//         <numberOfProperties>1</numberOfProperties>
//         <numberOfAttributes>2</numberOfAttributes>
//     </codeMetric>
// </information>
// <summary>
//     Indicates that the specified public static boolean get-only property guards access to the specified feature.
// </summary>
// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
#if !NULLABLE_ATTRIBUTES_DISABLE
#nullable enable
#pragma warning disable

namespace System.Diagnostics.CodeAnalysis
{
    using global::System;

#if DEBUG
    /// <summary>Indicates that the specified public static boolean get-only property guards access to the specified feature.</summary>
    /// <remarks>Analyzers can use this to prevent warnings on calls to code that is annotated as requiring that feature, when the callsite is guarded by a call to the property.</remarks>
    /// <devdoc><a href="https://github.com/dotnet/runtime/blob/main/src/libraries/System.Private.CoreLib/src/System/Diagnostics/CodeAnalysis/FeatureGuardAttribute.cs"/></devdoc>
#endif
    [AttributeUsage(AttributeTargets.Property, Inherited = false)]
#if !NULLABLE_ATTRIBUTES_INCLUDE_IN_CODE_COVERAGE
    [DebuggerNonUserCode]
#endif
    internal sealed partial class FeatureGuardAttribute : Attribute
    {
#if DEBUG
        /// <summary>Initializes a new instance of the <see cref="FeatureGuardAttribute"/> class with the specified feature type.</summary>
        /// <param name="featureType">The type that represents the feature guarded by the property.</param>
#endif
        public FeatureGuardAttribute(Type featureType)
        {
            FeatureType = featureType;
        }

#if DEBUG
        /// <summary>The type that represents the feature guarded by the property.</summary>
#endif
        public Type FeatureType { get; }
    }
}

#pragma warning restore
#nullable restore
#endif // NULLABLE_ATTRIBUTES_DISABLE
