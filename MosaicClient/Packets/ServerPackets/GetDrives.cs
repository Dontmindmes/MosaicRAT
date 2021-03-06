﻿using Client.Controllers;
using ZeroFormatter;

namespace Client.Packets.ServerPackets
{
    [ZeroFormattable]
    public class GetDrives : IPackets
    {
        public override TypePackets Type
        {
            get
            {
                return TypePackets.GetDrives;
            }
        }
        public GetDrives()
        {
        }

        public void Execute(ClientMosaic client)
        {
            client.send(this);
        }
    }
}
