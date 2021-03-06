﻿using System;
using NBitcoin;
using Stratis.SmartContracts.Core.State;
using Stratis.SmartContracts.Core.State.AccountAbstractionLayer;
using Xunit;

namespace Stratis.Bitcoin.Features.SmartContracts.Tests
{
    public class VinSerializerTests
    {
        [Fact]
        public void VinSerialization()
        {
            ContractUnspentOutput vin = new ContractUnspentOutput
            {
                Hash = new uint256((uint)new Random().Next(100000)),
                Nvout = (uint)new Random().Next(100000),
                Value = (ulong)new Random().Next(100000)
            };

            byte[] serialized = Serializers.VinSerializer.Serialize(vin);
            ContractUnspentOutput deserialized = Serializers.VinSerializer.Deserialize(serialized);
            Assert.Equal(vin.Hash, deserialized.Hash);
            Assert.Equal(vin.Nvout, deserialized.Nvout);
            Assert.Equal(vin.Value, deserialized.Value);
        }
    }
}