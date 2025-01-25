using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quasar.Common.Messages
{
    [ProtoContract]
    public class DoChat : IMessage
    {
        [ProtoMember(1)]
        public string PacketDms { get; set; }
    }
}
