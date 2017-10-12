﻿using System;
using System.Runtime.InteropServices;

//These are not entirely necessary, but here for my own sanity (temporary).
using RedValue = System.IntPtr;
using RedUnset = System.IntPtr;
using RedDatatype = System.IntPtr;
using RedNone = System.IntPtr;
using RedLogic = System.IntPtr;
using RedInteger = System.IntPtr;
using RedFloat = System.IntPtr;
using RedPair = System.IntPtr;
using RedTuple = System.IntPtr;
using RedBinary = System.IntPtr;
using RedImage = System.IntPtr;
using RedString = System.IntPtr;
using RedWord = System.IntPtr;
using RedBlock = System.IntPtr;
using RedPath = System.IntPtr;
using RedSeries = System.IntPtr;
using RedError = System.IntPtr;

namespace Red
{
    public class Red
    {
        //Initialize/Destruct Red Runtime
        [DllImport("libRed.dll", CharSet = CharSet.Ansi,CallingConvention =CallingConvention.Cdecl)]
        public static extern void redOpen();
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void redClose();

        //Do / Call
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedValue redDo([MarshalAs(UnmanagedType.LPStr)] string source);
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedValue redDoFile([MarshalAs(UnmanagedType.LPStr)] string file);
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedValue redDoBlock(RedValue code);
        //Todo: redCall, redRoutine

        // C -> Red Types
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern long redSymbol([MarshalAs(UnmanagedType.LPStr)] string word);
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedUnset redUnset();
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedNone redNone();
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedLogic redLogic(long logic);
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedDatatype redDatatype(long type);
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedInteger redInteger(long number);
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedFloat redFloat(double number);
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedPair redPair(long x, long y);
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedTuple redTuple(long r, long g, long b);
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedTuple redTuple4(long r, long g, long b, long a);
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedBinary redBinary([MarshalAs(UnmanagedType.LPStr)] string buffer, long bytes);
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedImage redImage(long width, long height, IntPtr buffer, long format);
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedString redString([MarshalAs(UnmanagedType.LPStr)] string str);
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedWord redWord([MarshalAs(UnmanagedType.LPStr)] string word);
        //todo: redBlock --- public static extern RedBlock
        //todo: redPath ---public static extern RedPath
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedPath redLoadPath([MarshalAs(UnmanagedType.LPStr)] string path);
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedValue redMakeSeries(ulong type, ulong slots);

        //Red -> C
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern long redCInt32(RedInteger number);
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern double redCDouble(RedFloat number);
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern string redCString(RedString str); //todo check output
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern long redTypeOf(RedValue value);

        //Red Actions

        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedValue redAppend(RedSeries series, RedValue value);
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedValue redChange(RedSeries series, RedValue value);
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedValue redClear(RedSeries series);
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedValue redCopy(RedValue value);
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedValue redFind(RedSeries series, RedValue value);
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedValue redIndex(RedSeries series);
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedValue redLength(RedSeries series);
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedValue redMake(RedValue proto, RedValue spec);
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedValue redMold(RedValue value);
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedValue redPick(RedSeries series, RedValue value);
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedValue redPoke(RedSeries series, RedValue index, RedValue value);
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedValue redPut(RedSeries series, RedValue index, RedValue value);
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedValue redRemove(RedSeries series);
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedValue redSelect(RedSeries series, RedValue value);
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedValue redSkip(RedSeries series, RedInteger offset);
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedValue redTo(RedValue proto, RedValue spec);

        //Access to Global Word
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedValue redSet(long id, RedValue value);
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedValue redGet(long id);

        // Access to a Red path
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedValue redSetPath(RedPath path, RedValue value);
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedValue redGetPath(RedPath path);

        // Access to a Red object/map/struct field 
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedValue redSetField(RedValue obj, long field, RedValue value);
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedValue redGetField(RedValue obj, long field);

        // Debugging
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void redPrint(RedValue value);
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedValue redProbe(RedValue value);
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern RedValue redHasError();
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern string redFormError();
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int redOpenLogWindow();
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int redCloseLogWindow();
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void redOpenLogFile([MarshalAs(UnmanagedType.LPStr)] string name);
        [DllImport("libRed.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void redCloseLogFile();

        enum ImageFormat
        {
            RGB,
            ARGB
        }
        enum Type
        {
            Value,
            Datatype,
            Unset,
            None,
            Logic,
            Block,
            Paren,
            String,
            File,
            Url,
            Char,
            Integer,
            Float,
            Symbol,
            Context,
            Word,
            SetWord,
            LitWord,
            GetWord,
            Refinement,
            Issue,
            Native,
            Action,
            Op,
            Function,
            Path,
            LitPath,
            SetPath,
            GetPath,
            Routine,
            Bitset,
            Point,
            Object,
            Typeset,
            Error,
            Vector,
            Hash,
            Pair,
            Percent,
            Tuple,
            Map,
            Binary,
            Series,
            Time,
            Tag,
            Email,
            Image,
            Event,
            Date,
            Closure,
            Port
        }



    }
}