﻿using System;
using AutoStep.Tracing;
using FormatWith;
using Xunit.Abstractions;

namespace AutoStep.Tests.Utils
{
    public class TestTracer : ITracer
    {
        private readonly ITestOutputHelper outputHelper;

        public TestTracer(ITestOutputHelper outputHelper)
        {
            this.outputHelper = outputHelper;
        }

        public void TraceError(Exception ex, string msg, object data)
        {
            outputHelper.WriteLine("ERROR: " + msg.FormatWith(data) + $"\n{ex.ToString()}");
        }

        public void TraceInfo(string msg, object data)
        {
            outputHelper.WriteLine("INFO: " + msg.FormatWith(data));
        }

        public void TraceWarn(string msg, object data)
        {
            outputHelper.WriteLine("WARN: " + msg.FormatWith(data));
        }
    }
}
