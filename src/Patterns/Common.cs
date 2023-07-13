// Copyright (c) Arctium.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Arctium.WoW.Launcher.Patterns
{
    static class Common
    {
        public static short[] ConnectToModulus = { 0x91, 0xD5, 0x9B, 0xB7, 0xD4, 0xE1, 0x83, 0xA5 };
        public static short[] SignatureModulus = { 0x35, 0xFF, 0x17, 0xE7, 0x33, 0xC4, 0xD3, 0xD4 };
        public static short[] ChangeProtocolModulus = { 0x71, 0xFD, 0xFA, 0x60, 0x14, 0x0D, 0xF2, 0x05 };

        public static short[] CertBundle = "{\"Created\":".ToPattern();
        public static short[] VersionUrl = "%s.patch.battle.net:1119/%s/versions".ToPattern();
        public static short[] Portal = ".actual.battle.net\0".ToPattern();
        public static short[] CommandLineHelp = "World of Warcraft usage".ToPattern();
    }
}
