using System;
using System.Runtime.InteropServices;

namespace ESpeakWrapper
{
    struct ESpeakVoice
    {
        [MarshalAs(UnmanagedType.LPStr)]
        public string Name;

        [MarshalAs(UnmanagedType.LPStr)]
        public string Languages;

        [MarshalAs(UnmanagedType.LPStr)]
        public string Identifier;
        public char Gender;
        public char Age;
        public char Variant;
    };
}
