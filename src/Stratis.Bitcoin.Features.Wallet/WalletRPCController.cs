﻿using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NBitcoin;
using Stratis.Bitcoin.Controllers;
using Stratis.Bitcoin.Features.RPC;
using Stratis.Bitcoin.Features.RPC.Exceptions;
using Stratis.Bitcoin.Features.Wallet.Interfaces;

namespace Stratis.Bitcoin.Features.Wallet
{
    public class WalletRPCController : FeatureController
    {
        public WalletRPCController(IServiceProvider serviceProvider, IWalletManager walletManager)
        {
            this.WalletManager = walletManager;
            this.serviceProvider = serviceProvider;
        }

        internal IServiceProvider serviceProvider;

        public IWalletManager WalletManager { get; set; }

        [ActionName("sendtoaddress")]
        [ActionDescription("Sends money to a bitcoin address.")]
        public uint256 SendToAddress(BitcoinAddress bitcoinAddress, Money amount)
        {
            WalletAccountReference account = this.GetAccount();
            return uint256.Zero;
        }

        private WalletAccountReference GetAccount()
        {
            //TODO: Support multi wallet like core by mapping passed RPC credentials to a wallet/account
            string w = this.WalletManager.GetWalletsNames().FirstOrDefault();
            if (w == null)
                throw new RPCServerException(RPCErrorCode.RPC_INVALID_REQUEST, "No wallet found");
            HdAccount account = this.WalletManager.GetAccounts(w).FirstOrDefault();
            return new WalletAccountReference(w, account.Name);
        }
    }
}