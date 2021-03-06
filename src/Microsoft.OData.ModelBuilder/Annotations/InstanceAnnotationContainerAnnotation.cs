﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System.Reflection;
using Microsoft.OData.Edm;

namespace Microsoft.OData.ModelBuilder
{
    /// <summary>
    /// This annotation indicates the mapping from a <see cref="IEdmStructuredType"/> to a <see cref="PropertyInfo"/>.
    /// The <see cref="IEdmStructuredType"/> is a type of IODataInstanceAnnotationContainer and the <see cref="PropertyInfo"/> is the specific
    /// property which is used to save/retrieve the instance annotations.
    /// </summary>
    public class InstanceAnnotationContainerAnnotation
    {
        /// <summary>
        /// Initializes a new instance of <see cref="InstanceAnnotationContainerAnnotation"/> class.
        /// </summary>
        /// <param name="propertyInfo">The backing <see cref="PropertyInfo"/>.</param>
        public InstanceAnnotationContainerAnnotation(PropertyInfo propertyInfo)
        {
            if (propertyInfo == null)
            {
                throw Error.ArgumentNull(nameof(propertyInfo));
            }

            if (!typeof(IODataInstanceAnnotationContainer).IsAssignableFrom(propertyInfo.PropertyType))
            {
                throw Error.Argument("propertyInfo", SRResources.ArgumentMustBeOfType, "IODataInstanceAnnotationContainer");
            }

            PropertyInfo = propertyInfo;
        }

        /// <summary>
        /// Gets the <see cref="PropertyInfo"/> which backs the instance annotations of the clr type/resource etc.
        /// </summary>
        public PropertyInfo PropertyInfo { get; }
    }
}