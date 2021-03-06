﻿// 
// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// 
namespace DotNetNuke.ExtensionPoints
{
    public interface IMenuItemExtensionPoint : IExtensionPoint
    {
        string Value { get; }

        string CssClass { get; }
    }
}
