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

    public interface ICoinService : IRpcService, IRpcExtenderService, ICoinParameters
    {
    }

    public partial class CoinService
    {
        public CoinParameters Parameters { get; }

        public class CoinParameters
        {

        }
    }

    public interface ICoinParameters
    {
        CoinService.CoinParameters Parameters { get; }
    }

    public partial class CoinService : ICoinService
    {
        protected readonly IRpcConnector _rpcConnector;

        
        
        public void BackupWallet(string destination)
        {
            _rpcConnector.MakeRequest<string>(RpcMethods.backupwallet, destination);
        }


        public string CreateRawTransaction(CreateRawTransactionRequest rawTransaction)
        {
            return _rpcConnector.MakeRequest<string>(RpcMethods.createrawtransaction, rawTransaction.Inputs, rawTransaction.Outputs);
        }


        public string GetAccount(string bitcoinAddress)
        {
            return _rpcConnector.MakeRequest<string>(RpcMethods.getaccount, bitcoinAddress);
        }

        public string GetAccountAddress(string account)
        {
            return _rpcConnector.MakeRequest<string>(RpcMethods.getaccountaddress, account);
        }

        
        public List<string> GetAddressesByAccount(string account)
        {
            return _rpcConnector.MakeRequest<List<string>>(RpcMethods.getaddressesbyaccount, account);
        }
        

        public decimal GetBalance(string account, int minConf, bool? includeWatchonly)
        {
            return includeWatchonly == null
                ? _rpcConnector.MakeRequest<decimal>(RpcMethods.getbalance, (string.IsNullOrWhiteSpace(account) ? "*" : account), minConf)
                : _rpcConnector.MakeRequest<decimal>(RpcMethods.getbalance, (string.IsNullOrWhiteSpace(account) ? "*" : account), minConf, includeWatchonly);
        }

        public string GetBestBlockHash()
        {
            return _rpcConnector.MakeRequest<string>(RpcMethods.getbestblockhash);
        }

        

        public uint GetBlockCount()
        {
            return _rpcConnector.MakeRequest<uint>(RpcMethods.getblockcount);
        }

        public string GetBlockHash(long index)
        {
            return _rpcConnector.MakeRequest<string>(RpcMethods.getblockhash, index);
        }

        

        public string GetNewAddress(string account)
        {
            return string.IsNullOrWhiteSpace(account)
                ? _rpcConnector.MakeRequest<string>(RpcMethods.getnewaddress)
                : _rpcConnector.MakeRequest<string>(RpcMethods.getnewaddress, account);
        }

        

        public void ImportAddress(string address, string label, bool rescan)
        {
            _rpcConnector.MakeRequest<string>(RpcMethods.importaddress, address, label, rescan);
        }

        public string ImportPrivKey(string privateKey, string label, bool rescan)
        {
            return _rpcConnector.MakeRequest<string>(RpcMethods.importprivkey, privateKey, label, rescan);
        }

        public void ImportWallet(string filename)
        {
            _rpcConnector.MakeRequest<string>(RpcMethods.importwallet, filename);
        }

        

        public string SendFrom(string fromAccount, string toBitcoinAddress, decimal amount, int minConf, string comment, string commentTo)
        {
            return _rpcConnector.MakeRequest<string>(RpcMethods.sendfrom, fromAccount, toBitcoinAddress, amount, minConf, comment, commentTo);
        }

        

        public string SendRawTransaction(string rawTransactionHexString, bool? allowHighFees)
        {
            return allowHighFees == null
                ? _rpcConnector.MakeRequest<string>(RpcMethods.sendrawtransaction, rawTransactionHexString)
                : _rpcConnector.MakeRequest<string>(RpcMethods.sendrawtransaction, rawTransactionHexString, allowHighFees);
        }

        public string SendToAddress(string bitcoinAddress, decimal amount, string comment, string commentTo, bool subtractFeeFromAmount)
        {
            return _rpcConnector.MakeRequest<string>(RpcMethods.sendtoaddress, bitcoinAddress, amount, comment, commentTo, subtractFeeFromAmount);
        }

        

        public string SignMessage(string bitcoinAddress, string message)
        {
            return _rpcConnector.MakeRequest<string>(RpcMethods.signmessage, bitcoinAddress, message);
        }
        
        
    }



    public interface IRpcConnector
    {
        T MakeRequest<T>(RpcMethods method, params object[] parameters);
    }


    public interface IRpcExtenderService
    {
        
    }


    public interface IRpcService
    {
        
        //  abandontransaction
        string GetAccount(string bitcoinAddress);
        decimal GetBalance(string account = null, int minConf = 1, bool? includeWatchonly = null);
        string GetNewAddress(string account = "");
        string SendFrom(string fromAccount, string toBitcoinAddress, decimal amount, int minConf = 1, string comment = null, string commentTo = null);
        string SendToAddress(string bitcoinAddress, decimal amount, string comment = null, string commentTo = null, bool subtractFeeFromAmount = false);
        string SignMessage(string bitcoinAddress, string message);
        
    }


}