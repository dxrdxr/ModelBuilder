﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

namespace Microsoft.OData.ModelBuilder.Tests.TestModels
{
    /// <summary>
    /// Tagging interface to assist comparing instances of these types.
    /// </summary>
    public interface INameAndIdContainer
    {
        string Name { get; set; }

        int Id { get; set; }
    }
}
