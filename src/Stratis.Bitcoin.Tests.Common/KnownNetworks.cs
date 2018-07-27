﻿using NBitcoin;
using NBitcoin.Networks;
using Stratis.Bitcoin.Networks;

namespace Stratis.Bitcoin.Tests.Common
{
    public static class KnownNetworks
    {
        public static Network Main => NetworkRegistration.GetNetwork("Main") ?? NetworkRegistration.Register(new BitcoinMain());

        public static Network TestNet => NetworkRegistration.GetNetwork("TestNet") ?? NetworkRegistration.Register(new BitcoinTest());

        public static Network RegTest => NetworkRegistration.GetNetwork("RegTest") ?? NetworkRegistration.Register(new BitcoinRegTest());

        public static Network StratisMain => NetworkRegistration.GetNetwork("StratisMain") ?? NetworkRegistration.Register(new StratisMain());

        public static Network StratisTest => NetworkRegistration.GetNetwork("StratisTest") ?? NetworkRegistration.Register(new StratisTest());

        public static Network StratisRegTest => NetworkRegistration.GetNetwork("StratisRegTest") ?? NetworkRegistration.Register(new StratisRegTest());

        public static Network x42Main => NetworkRegistration.GetNetwork("x42Main") ?? NetworkRegistration.Register(new x42Main());
    }
}