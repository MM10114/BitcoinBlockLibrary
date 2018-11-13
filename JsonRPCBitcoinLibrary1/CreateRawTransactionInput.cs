using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JsonRPCBitcoinLibrary1
{

    /// <summary>
    /// This requesting the response from Bitcoin
    /// Credit to: GeorgeKimionis & BitcoinLib
    /// </summary>

    
    public class CreateRawTransactionInput
    {
        [JsonProperty("txid")]
        public string TxId { get; set; }

        [JsonProperty("vout")]
        public int Vout { get; set; }
    }
}


}
