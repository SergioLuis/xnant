// NAnt - A .NET build tool
// Copyright (C) 2001 Gerry Shaw
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
//
// Gerry Shaw (gerry_shaw@yahoo.com)

namespace SourceForge.NAnt.Attributes {

    using System;
    using System.Reflection;

    /// <summary>Indicates that field should be able to be converted into a Boolean.</summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property	, Inherited=true)]
    public class BooleanValidatorAttribute : ValidatorAttribute {

        public BooleanValidatorAttribute() {
        }

        public override bool Validate(object value) {
            try {
                Convert.ToBoolean(value);
            } catch (Exception) {
                throw new ValidationException(String.Format("Cannot resolve to '{0}' to Boolean value.", value.ToString()));
            }
            return true;
        }
    }
}