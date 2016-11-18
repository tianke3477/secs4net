﻿using Cim.Eap.Tx;
using Secs4Net;
namespace Cim.Eap {
    partial class Driver {
        void EQP_CarrierIDRead(SecsMessage msg) {
            var portNo = msg.SecsItem.Items[2].Items[0].Items[1].Items[0].GetValue<byte>();
            var carrierId = msg.SecsItem.Items[2].Items[0].Items[1].Items[1].GetString().Trim();
            EAP.Report(new CarrierIDReport {
                LoadPortId = GetPortID(portNo),
                CarrierId = carrierId
            });
        }
    }
}