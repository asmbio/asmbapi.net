﻿using System;
using System.Collections.Generic;
using System.Text;

namespace asmbapi.net.ATypes
{
    public class ATypes
    {


        // 补位后+1
        public static byte[] Addone(byte[] str)
        {
            if (str.Length > AConst.AddrLen)
            {
                throw new ArgumentException("addone 长度不对");
            }
            //	var c0 = new byte[AConst.AddrLen];
            byte[] c0 = new byte[AConst.AddrLen];

            Buffer.BlockCopy(str, 0, c0, 0, AConst.AddrLen);

            for (int i = c0.Length - 1; i >= 0; i--)
            {
                if (c0[i] == 255)
                {
                    c0[i] = 0;
                    continue;
                }
                c0[i] = (byte)(c0[i] + 1);
                break;
            }

            return c0;
        }

        // 补位后-1
        public static byte[] Subone(byte[] str)
        {
            if (str.Length > AConst.AddrLen)
            {
                throw new ArgumentException("addone 长度不对");
            }
            byte[] c0 = new byte[AConst.AddrLen];

            Buffer.BlockCopy(str, 0, c0, 0, AConst.AddrLen);

            for (int i = c0.Length - 1; i >= 0; i--)
            {
                if (c0[i] == 0)
                {
                    c0[i] = 255;
                    continue;
                }
                c0[i] = (byte)(c0[i] - 1);
                break;
            }
            return c0;
        }

    }

    // public struct Address { str string }





}

