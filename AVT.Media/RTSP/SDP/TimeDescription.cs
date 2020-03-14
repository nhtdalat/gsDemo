﻿
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AVT.Media.RTSP.SDP
{
    public class TimeDescription
    {
        private static readonly string CRLF = "\r\n";
        private static readonly Regex REGEX = new Regex(@"^t\s*=\s*(\d+)\s+(\d+)", RegexOptions.Compiled);

        public TimeDescription() : this(0,0)
        {

        }

        public TimeDescription(ulong start, ulong stop)
        {
            StartTime = start;
            StopTime = stop;
            RepeatTimes = new List<RepeatTime>();
        }

        #region Properties

        public ulong StartTime { get; set; }

        public ulong StopTime { get; set; }

        public List<RepeatTime> RepeatTimes { get; private set; }

        #endregion

        public override string ToString()
        {
            var sb = new StringBuilder("t=").Append(StartTime)
                                            .Append(' ')
                                            .Append(StopTime)
                                            .Append(CRLF);

            RepeatTimes.ForEach(r =>
            {
                sb.Append(r.ToString()).Append(CRLF);
            });

            return sb.ToString();
        }

        public static TimeDescription Parse(string line)
        {
            var match = REGEX.Match(line);

            if (!match.Success)
            {
                throw new SdpParseException($"Unable to parse malformed timing '{line}'");
            }

            ulong start;
            if (!ulong.TryParse(match.Groups[1].Value, out start))
            {
                throw new SdpParseException($"Unable to parse timing start-time '{match.Groups[1].Value}'");
            }

            ulong stop;
            if (!ulong.TryParse(match.Groups[1].Value, out stop))
            {
                throw new SdpParseException($"Unable to parse timing stop-time '{match.Groups[1].Value}'");
            }

            return new TimeDescription(start, stop);
        }
    }
}
