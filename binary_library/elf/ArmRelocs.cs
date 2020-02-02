/* Copyright (C) 2016 by John Cronin
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:

 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.

 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace binary_library.elf
{
    partial class ElfFile
    {
        /* ARM relocations */
        public const int R_ARM_THM_CALL = 10;
        public const int R_ARM_THM_MOVW_ABS_NC = 47;
        public const int R_ARM_THM_MOVT_ABS = 48;

        public class Rel_Arm_Thm_Call : IRelocationType
        {
            public int Length
            {
                get { return 4; }
            }

            public ulong KeepMask
            {
                get { return 0xd000f000; }
            }

            public ulong SetMask
            {
                get { return 0x2fff0fff; }
            }

            public string Name
            {
                get { return "R_ARM_THM_CALL"; }
            }

            public int Type
            {
                get { return (int)R_ARM_THM_CALL; }
            }

            public long Evaluate(IRelocation reloc)
            {
                // 
                throw new NotImplementedException();
            }

            public long GetCurrentValue(IRelocation reloc)
            {
                throw new NotImplementedException();
            }

            public int BitLength
            { get { return 32; } }
            public bool IsSigned
            { get { return true; } }
            public int BitOffset
            { get { return 0; } }
        }

        public class Rel_Arm_Thm_Movw_Abs_Nc : IRelocationType
        {
            public int Length
            {
                get { return 4; }
            }

            public ulong KeepMask
            {
                get { return 0xffff0000; }
            }

            public ulong SetMask
            {
                get { return 0x0000ffff; }
            }

            public string Name
            {
                get { return "R_ARM_THM_MOVW_ABS_NC"; }
            }

            public int Type
            {
                get { return (int)R_ARM_THM_MOVW_ABS_NC; }
            }

            public long Evaluate(IRelocation reloc)
            {
                // 
                throw new NotImplementedException();
            }

            public long GetCurrentValue(IRelocation reloc)
            {
                throw new NotImplementedException();
            }

            public int BitLength
            { get { return 32; } }
            public bool IsSigned
            { get { return false; } }
            public int BitOffset
            { get { return 0; } }
        }

        public class Rel_Arm_Thm_Movt_Abs : IRelocationType
        {
            public int Length
            {
                get { return 4; }
            }

            public ulong KeepMask
            {
                get { return 0x0000ffff; }
            }

            public ulong SetMask
            {
                get { return 0xffff0000; }
            }

            public string Name
            {
                get { return "R_ARM_THM_MOV_tABS"; }
            }

            public int Type
            {
                get { return (int)R_ARM_THM_MOVT_ABS; }
            }

            public long Evaluate(IRelocation reloc)
            {
                // 
                throw new NotImplementedException();
            }

            public long GetCurrentValue(IRelocation reloc)
            {
                throw new NotImplementedException();
            }

            public int BitLength
            { get { return 32; } }
            public bool IsSigned
            { get { return false; } }
            public int BitOffset
            { get { return 0; } }
        }
    }
}
