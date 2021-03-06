﻿using DogScepterLib.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DogScepterLib.Core.Chunks
{
    public class GMChunkACRV : GMChunk
    {
        public GMPointerList<GMAnimCurve> List;
        public override void Serialize(GMDataWriter writer)
        {
            base.Serialize(writer);

            writer.Write(1);
            List.Serialize(writer);
        }

        public override void Unserialize(GMDataReader reader)
        {
            base.Unserialize(reader);

            int chunkVersion = reader.ReadInt32();
            if (chunkVersion != 1)
                reader.Warnings.Add(new GMWarning(string.Format("ACRV version is {0}, expected 1", chunkVersion)));

            List = new GMPointerList<GMAnimCurve>();
            List.Unserialize(reader);
        }
    }
}
