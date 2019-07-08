﻿namespace SecureCodingWorkshop.HybridWithIntegrity
{
    public class EncryptedPacket
    {
        public byte[] EncryptedSessionKey;
        public byte[] EncryptedData;
        public byte[] Iv;
        public byte[] Hmac;
    }
}