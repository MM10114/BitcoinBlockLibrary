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

    public enum RpcMethods
    {
        //== Blockchain ==
        getbestblockhash,
        getblock,
        getblockchaininfo,
        getblockcount,
        getblockhash,
        getblockheader,
        getchaintips,
        getdifficulty,
        getmempoolinfo,
        getrawmempool,
        gettxout,
        gettxoutproof,
        gettxoutsetinfo,
        verifychain,
        verifytxoutproof,

        //== Control ==
        getinfo,
        help,
        stop,

        //== Generating ==
        generate,
        getgenerate,
        setgenerate,

        //== Mining ==
        getblocktemplate,
        getmininginfo,
        getnetworkhashps,
        prioritisetransaction,
        submitblock,

        //== Network ==
        addnode,
        clearbanned,
        disconnectnode,
        getaddednodeinfo,
        getconnectioncount,
        getnettotals,
        getnetworkinfo,
        getpeerinfo,
        listbanned,
        setban,

        //== Rawtransactions ==
        createrawtransaction,
        decoderawtransaction,
        decodescript,
        fundrawtransaction,
        getrawtransaction,
        sendrawtransaction,
        signrawtransaction,
        sighashtype,

        //== Util ==
        createmultisig,
        estimatefee,
        estimatepriority,
        estimatesmartfee,
        estimatesmartpriority,
        validateaddress,
        mirroraddress,
        verifymessage,

        //== Wallet ==
        abandontransaction,
        addmultisigaddress,
        addwitnessaddress,
        backupwallet,
        dumpprivkey,
        dumpwallet,
        getaccount,
        getaccountaddress,
        getaddressesbyaccount,
        getaddressesbylabel,
        getaddressinfo,
        getbalance,
        getnewaddress,
        getrawchangeaddress,
        getreceivedbyaccount,
        getreceivedbyaddress,
        getreceivedbylabel,
        gettransaction,
        getunconfirmedbalance,
        getwalletinfo,
        importaddress,
        importprivkey,
        importpubkey,
        importwallet,
        keypoolrefill,
        listaccounts,
        listaddressgroupings,
        listlabels,
        listlockunspent,
        listreceivedbyaccount,
        listreceivedbyaddress,
        listreceivedbylabel,
        listsinceblock,
        listtransactions,
        listmirrtransactions,
        listunspent,
        lockunspent,
        move,
        sendfrom,
        sendmany,
        sendtoaddress,
        setaccount,
        setlabel,
        settxfee,
        signmessage,
        walletlock,
        walletpassphrase,
        walletpassphrasechange
    }


}
