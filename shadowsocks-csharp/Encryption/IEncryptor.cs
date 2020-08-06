﻿using System;

namespace Shadowsocks.Encryption
{
    public interface IEncryptor
    {
        /* length == -1 means not used */
        int AddressBufferLength { set; get; }
        int Encrypt(ReadOnlySpan<byte> plain, Span<byte> cipher);
        int Decrypt(Span<byte> plain, ReadOnlySpan<byte> cipher);
        int EncryptUDP(ReadOnlySpan<byte> plain, Span<byte> cipher);
        int DecryptUDP(Span<byte> plain, ReadOnlySpan<byte> cipher);
    }
}
