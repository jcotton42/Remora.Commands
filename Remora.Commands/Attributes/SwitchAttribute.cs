//
//  SwitchAttribute.cs
//
//  Author:
//       Jarl Gullberg <jarl.gullberg@gmail.com>
//
//  Copyright (c) 2017 Jarl Gullberg
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

using System;
using JetBrains.Annotations;

namespace Remora.Commands.Attributes;

/// <summary>
/// Marks a parameter as being a boolean switch.
/// </summary>
[AttributeUsage(AttributeTargets.Parameter)]
[PublicAPI]
public class SwitchAttribute : OptionAttribute
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SwitchAttribute"/> class.
    /// </summary>
    /// <param name="shortName">The short name of the option.</param>
    /// <param name="longName">The long name of the option.</param>
    public SwitchAttribute(char shortName, string longName)
        : base(shortName, longName)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SwitchAttribute"/> class.
    /// </summary>
    /// <param name="shortName">The short name of the option.</param>
    public SwitchAttribute(char shortName)
        : base(shortName)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SwitchAttribute"/> class.
    /// </summary>
    /// <param name="longName">The long name of the option.</param>
    public SwitchAttribute(string longName)
        : base(longName)
    {
    }
}
