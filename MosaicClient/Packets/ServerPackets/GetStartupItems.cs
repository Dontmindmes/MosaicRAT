﻿using Client.Controllers;
using ZeroFormatter;

namespace Client.Packets.ServerPackets
{
    [ZeroFormattable]
    public class GetStartupItems : IPackets
    {
        public override TypePackets Type
        {
            get
            {
                return TypePackets.GetStartupItems;
            }
        }

        public GetStartupItems()
        {
        }

        public void Execute(ClientMosaic client)
        {
            client.send(this);
        }
    }
}
