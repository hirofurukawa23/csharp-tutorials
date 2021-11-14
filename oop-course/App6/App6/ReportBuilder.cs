using System.Collections.Generic;

namespace App6
{
    public class ReportBuilder
    {
        public ReportBuilder()
        { }

        public List<string> Build(ReportBase report)
        {
            var r = new List<string>();
            r.Add(DecorateHeader(report.GetHeader()));
            r.Add(report.GetContent());
            return r;
        }

        private string DecorateHeader(string header)
        {
            return $"【{ header }】";
        }
    }
}
