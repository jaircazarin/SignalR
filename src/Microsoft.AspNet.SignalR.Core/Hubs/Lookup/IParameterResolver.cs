﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.md in the project root for license information.

using Newtonsoft.Json.Linq;

namespace Microsoft.AspNet.SignalR.Hubs
{
    /// <summary>
    /// Describes a parameter resolver for resolving parameter-matching values based on provided information.
    /// </summary>
    public interface IParameterResolver
    {
        /// <summary>
        /// Resolves method parameter values based on provided objects.
        /// </summary>
        /// <param name="method">Method descriptor.</param>
        /// <param name="values">List of values to resolve parameter values from.</param>
        /// <returns>Array of parameter values.</returns>
        object[] ResolveMethodParameters(MethodDescriptor method, params IJsonValue[] values);
    }
}
