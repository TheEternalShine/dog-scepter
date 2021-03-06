﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DogScepterLib.Core.Models
{
    /// <summary>
    /// Contains name of a GameMaker audio group.
    /// </summary>
    public class GMAudioGroup : GMSerializable
    {
        public GMString Name;

        public void Serialize(GMDataWriter writer)
        {
            writer.WritePointerString(Name);
        }

        public void Unserialize(GMDataReader reader)
        {
            Name = reader.ReadStringPointerObject();
        }

        public override string ToString()
        {
            return $"Audio Group: \"{Name.Content}\"";
        }
    }
}
